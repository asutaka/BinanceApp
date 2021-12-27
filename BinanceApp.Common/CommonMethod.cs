using BinanceApp.Model.ENTITY;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BinanceApp.Common
{
    public static class CommonMethod
    {
        public static bool CheckForInternetConnection(int timeoutMs = 10000)
        {
            try
            {
                var url = "https://www.google.com.vn/";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Timeout = timeoutMs;
                using (var response = (HttpWebResponse)request.GetResponse())
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckFileExist(string fileName)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\{fileName}";
            return File.Exists(path);
        }

        public static async Task<long> GetTimeAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    var response = await client.GetAsync(ConstantValue.timeURL);
                    var result = response.Content.ReadAsStringAsync().Result;
                    var resultModel = JsonConvert.DeserializeObject<TimeModel>(result);
                    return resultModel.TimeStamp;
                }
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"CommonMethod:GetTimeAsync: { ex.Message }");
                return 0;
            }
        }

        public static void LockObject(this bool obj, bool val)
        {
            Monitor.Enter(obj);
            try
            {
                obj = val;
            }
            finally { Monitor.Exit(obj); }
        }
    }
}

