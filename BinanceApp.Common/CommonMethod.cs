using BinanceApp.Model.ENTITY;
using BinanceApp.Model.ENUM;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
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
            string path = $"{Directory.GetCurrentDirectory()}\\settings\\{fileName}";
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

        public static string ScronString(List<ScronModel> lstModel)
        {
            var strOutput = new StringBuilder();
            foreach (var item in lstModel)
            {
                if (strOutput.Length > 0)
                    strOutput.Append(" ");
                var val = (item.Value < 0)? "*" : item.Value.ToString();
                strOutput.Append(item.Frequence? $"0/":"" + val);
            }
            return strOutput.ToString();
        }

        public static T DownloadJsonFile<T>(string url)
        {
            if (WebRequest.Create(url) is HttpWebRequest webRequest)
            {
                webRequest.ContentType = "application/json";
                webRequest.UserAgent = "Nothing";

                using (var s = webRequest.GetResponse().GetResponseStream())
                {
                    using (var sr = new StreamReader(s))
                    {
                        var contributorsAsJson = sr.ReadToEnd();
                        var contributors = JsonConvert.DeserializeObject<T>(contributorsAsJson);
                        return (T)Convert.ChangeType(contributors, typeof(T));
                    }
                }
            }
            return (T)Convert.ChangeType(null, typeof(T));
        }

        public static JArray DownloadJsonArray(string url)
        {
            if (WebRequest.Create(url) is HttpWebRequest webRequest)
            {
                webRequest.ContentType = "application/json";
                webRequest.UserAgent = "Nothing";
                try
                {
                    using (var s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (var sr = new StreamReader(s))
                        {
                            var contributorsAsJson = sr.ReadToEnd();
                            var contributors = JArray.Parse(contributorsAsJson);
                            return contributors;
                        }
                    }
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        public static double GetCurrentValue(string code)
        {
            try
            {
                var url = $"{ConstantValue.COIN_DETAIL}symbol={code}&interval=15m&limit=1";
                var arrData = DownloadJsonArray(url);
                if (arrData == null)
                    return 0;
                var currentVal = double.Parse(arrData[0][4].ToString());
                return currentVal;
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"CommonMethod:GetCurrentValue: {ex.Message}");
                return 0;
            }
        }

        public static double GetBottomValue(string code)
        {
            var url = $"{ConstantValue.COIN_DETAIL}symbol={code}&interval={enumInterval.OneHour.GetDisplayName()}&limit=15";
            var arrData = DownloadJsonArray(url);
            if (arrData == null || arrData.Count < 15)
                return 0;
            var count = arrData.Count;
            double min = double.Parse(arrData[0][3].ToString());
            var countConfirm = 0;
            for (int i = 1; i < count; i++)
            {
                var val = double.Parse(arrData[i][3].ToString());
                if(min <= val)
                {
                    if(++countConfirm == 3)
                    {
                        return min;
                    }
                }
                else
                {
                    countConfirm = 0;
                    min = val;
                }
            }
            return min;
        }

        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        public static int GetFlag(BasicSettingModel model)
        {
            var div = 1;
            if (model.TimeZone == (int)enumTimeZone.OneHour)
            {
                div = div * 4;
            }
            else if (model.TimeZone == (int)enumTimeZone.FourHour)
            {
                div = div * 4 * 4;
            }
            else if (model.TimeZone == (int)enumTimeZone.OneDay)
            {
                div = div * 4 * 4 * 6;
            }
            else if (model.TimeZone == (int)enumTimeZone.OneWeek)
            {
                div = div * 4 * 4 * 6 * 7;
            }
            else if (model.TimeZone == (int)enumTimeZone.OneMonth)
            {
                div = div * 4 * 4 * 6 * 7 * 4;
            }
            var result = 1800 * model.Interval * div;
            return result;
        }
    }
}

