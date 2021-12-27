using Newtonsoft.Json;
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
        public static long DateToInt(this DateTime value)
        {
            return long.Parse(value.ToString("yyyyMMddHHssmm"));
        }

        public static T LoadJsonFile<T>(this T val, string fileName)
        {
            try
            {
                string path = $"{Directory.GetCurrentDirectory()}\\{fileName}.json";
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
                string path = $"{Directory.GetCurrentDirectory()}\\{fileName}.json";
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
    }
}
