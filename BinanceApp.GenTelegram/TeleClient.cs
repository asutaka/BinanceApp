using System;
using System.Threading.Tasks;
using WTelegram;

namespace BinanceApp.GenTelegram
{
    public class TeleClient
    {
        private static Client _clientService, _clientSupport;
        private static string _api_id, _api_hash, _phone_number, _session_pathname, _verification_code;
        private static string Config(string what)
        {
            switch (what)
            {
                case "api_id": return _api_id;
                case "api_hash": return _api_hash;
                case "phone_number": return _phone_number;
                case "session_pathname": return _session_pathname;
                case "verification_code": return _verification_code;
                default: return null;
            }
        }

        public static async Task<bool> GenerateSession(string phoneNumber, string apiId, string apiHash, string verifyCode, bool isService)
        {
            try
            {
                _api_id = apiId;
                _api_hash = apiHash;
                _phone_number = phoneNumber;
                _session_pathname = $"{_phone_number.Replace("+", "")}.session";
                _verification_code = verifyCode;
                if (isService)
                {
                    _clientService = new Client(Config);
                    await _clientService.ConnectAsync();
                    var user = await _clientService.LoginUserIfNeeded();
                    //NLogLogger.LogInfo($"You are logged-in as {user.username ?? user.first_name + " " + user.last_name} (id {user.id})");
                }
                else
                {
                    _clientSupport = new Client(Config);
                    await _clientSupport.ConnectAsync();
                    var user = await _clientSupport.LoginUserIfNeeded();
                    //NLogLogger.LogInfo($"You are logged-in as {user.username ?? user.first_name + " " + user.last_name} (id {user.id})");
                }
                return true;
            }
            catch(Exception ex)
            {
                //NLogLogger.PublishException(ex, $"TeleClient:GenerateSession: {ex.Message}");
                return false;
            }
        }
    }
}
