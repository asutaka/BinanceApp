using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceApp.Common
{
    public static class ConstantValue
    {
        //Signin Google
        public const string clientId = "761897430379-8nf5v577simq1v4hqiaedbt92vcuhee5.apps.googleusercontent.com";
        public const string clientSecret = "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";
        public const string scopes = "https://www.googleapis.com/auth/userinfo.email https://www.googleapis.com/auth/userinfo.profile";
        public const string redirectURI = "urn:ietf:wg:oauth:2.0:oob";
        //Security
        public const string PasswordHash = "P@$Sw0rd";
        public const string SaltKey = "Phunv@AI";
        public const string VIKey = "Phunv@Huy456aA@1";
        //Time
        public const string timeURL = "https://api.timezonedb.com/v2/get-time-zone?key=PJBB6AVAAMO0&format=json&by=zone&zone=Asia/Bangkok";
        //Coin
        public const string COIN_LIST = "https://www.binance.com/bapi/asset/v2/public/asset-service/product/get-products?includeEtf=true";
        public const string COIN_DETAIL = "https://www.binance.com/api/v1/klines?";
        public const string COIN_SINGLE = "https://www.binance.com/vi/trade/";
    }
}
