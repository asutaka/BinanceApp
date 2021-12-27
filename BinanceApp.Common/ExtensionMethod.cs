using Newtonsoft.Json;
using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceApp.Common
{
    public static class ExtensionMethod
    {
        //public static long DateToInt(this DateTime value)
        //{
        //    return long.Parse(value.ToString("yyyyMMddHHssmm"));
        //}

        public static T LoadJsonFile<T>(this T val, string fileName)
        {
            try
            {
                string path = $"{Directory.GetCurrentDirectory()}\\{fileName}";
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    var result = JsonConvert.DeserializeObject<T>(json);
                    return result;
                }
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"ExtensionMethod:LoadJsonFile: {ex.Message}");
                return default(T);
            }
        }

        public static bool UpdateJson<T>(this T _model, string fileName)
        {
            try
            {
                string path = $"{Directory.GetCurrentDirectory()}\\{fileName}";
                string json = JsonConvert.SerializeObject(_model);
                //write string to file
                File.WriteAllText(path, json);
                return true;
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"ExtensionMethod:UpdateJson: {ex.Message}");
                return false;
            }
        }

        public static string PhoneFormat(this string input, bool isCharacter = true)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;
            var region = string.Empty;
            if (input.Substring(0, 1) != "+")
                region = "VN";
            var val = GetPhone(input, region);
            return isCharacter ? val.Item2 : val.Item2.Replace("+", "");
        }

        private static (int, string) GetPhone(string input, string region = "")
        {
            try
            {
                var phoneUtil = PhoneNumberUtil.GetInstance();
                if (input.Length >= 9 && input.Length <= 20)
                {
                    var numberProto = phoneUtil.Parse(input.Trim(), region);
                    int countryCode = numberProto.CountryCode;
                    var formattedPhone = phoneUtil.Format(numberProto, PhoneNumberFormat.INTERNATIONAL).Replace(" ", "");
                    return (countryCode, formattedPhone);
                }
                return (0, string.Empty);
            }
            catch (NumberParseException ex)
            {
                NLogLogger.PublishException(ex, $"ExtensionMethod:GetPhone: {ex.Message}");
                return (0, string.Empty);
            }
        }
    }
}
