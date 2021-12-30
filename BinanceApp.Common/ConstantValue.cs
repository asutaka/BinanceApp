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
        //Telegram
        public const string strBuyCode = "Danh sách gói code:" +
                                         "\nGói dùng thử 3 ngày: miễn phí(duy nhất 1 lần) - Mã: FREE" +
                                         "\nGói 1 tháng: xK/tháng - Mã: 1M" +
                                         "\nGói 3 tháng: yK/tháng - Mã: 3M" +
                                         "\nGói 6 tháng: zK/tháng - Mã: 6M" +
                                         "\nGói 1 năm: tK/tháng - Mã: 1Y" +
                                         "\n\nVui lòng chat tại đây để nhận tư vấn hoặc" +
                                         "\nchuyển tiền với nội dung: DK Mã_gói Email_sử_dụng SĐT_Telegram" +
                                         "\ntới STK:xxx - tại ngân hàng VCB, người nhận: Nguyễn Văn A";
        public const string strSupport = "<Tin nhắn tự động>Bạn cần hỗ trợ gì?";
        public const string apiIdBot1 = "5128731";
        public const string apiHashBot1 = "a894a079cfeadf0bd0646f53bf2587c6";
        //Google Drive
        public const string strVersion = "https://drive.google.com/file/d/1o-ahy7uHCK_sVkdJ_G7iaVWyDGUU7Nli/view?usp=sharing";
        public const string strBotBuyCode = "https://drive.google.com/file/d/1hakAvnesXwXbr4WsHx4ilZhfJPa4PjFi/view?usp=sharing";
        public const string strBotSupport = "https://drive.google.com/file/d/1hakAvnesXwXbr4WsHx4ilZhfJPa4PjFi/view?usp=sharing";
    }
}
