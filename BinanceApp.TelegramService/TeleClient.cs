using BinanceApp.Common;
using BinanceApp.Model.ENUM;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TL;
using WTelegram;

namespace BinanceApp.TelegramService
{
    public class TeleClient
    {
        private static Client _clientService, _clientSupport;
        private static string _api_id, _api_hash, _phone_number, _session_pathname;
        private static string Config(string what)
        {
            switch (what)
            {
                case "api_id": return _api_id;
                case "api_hash": return _api_hash;
                case "phone_number": return _phone_number;
                case "session_pathname": return _session_pathname;
                default: return null;
            }
        }

        private static async Task<bool> InitTelegram(bool isService)
        {
            try
            {
                if (isService)
                {
                    _api_id = ConstantValue.apiIdService;
                    _api_hash = ConstantValue.apiHashService;
                    _phone_number = ConstantValue.phoneService;
                    _session_pathname = $"{_phone_number.Replace("+", "")}.session";

                    _clientService = new Client(Config);
                    await _clientService.ConnectAsync();
                }
                else
                {
                    _api_id = ConstantValue.apiIdSupport;
                    _api_hash = ConstantValue.apiHashSupport;
                    _phone_number = ConstantValue.phoneSupport;
                    _session_pathname = $"{_phone_number.Replace("+", "")}.session";

                    _clientSupport = new Client(Config);
                    await _clientSupport.ConnectAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"TeleClient:GenerateSession: {ex.Message}");
                return false;
            }
        }

        public static async Task<int> SendMessage(string phone, string content, bool isService = false)
        {
            try
            {
                if (!await InitTelegram(isService))
                    return (int)enumTelegramSendMessage.UnknownError; 
                //_clientSupport = new Client(Config);
                //await _clientSupport.ConnectAsync();
                var phoneUser = phone.PhoneFormat();
                if (string.IsNullOrWhiteSpace(phoneUser))
                    return (int)enumTelegramSendMessage.PhoneInValid;
                if (isService)
                {
                    var result = await _clientService.Contacts_ImportContacts(new[] { new InputPhoneContact { phone = phoneUser } });
                    if (result != null)
                    {
                        await _clientService.SendMessageAsync(result.users.First().Value, content);
                    }
                }
                else
                {
                    var result = await _clientSupport.Contacts_ImportContacts(new[] { new InputPhoneContact { phone = phoneUser } });
                    if (result != null)
                    {
                        await _clientSupport.SendMessageAsync(result.users.First().Value, content);
                    }
                }
                Thread.Sleep(1000);
                return (int)enumTelegramSendMessage.Success;
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"TeleClient:SendMessage:  { ex.Message }");
                return (int)enumTelegramSendMessage.UnknownError;
            }
        }
    }
}
