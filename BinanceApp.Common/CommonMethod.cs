using System;
using System.Net;

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
    }
}

