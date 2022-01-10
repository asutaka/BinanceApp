using System.ComponentModel.DataAnnotations;

namespace BinanceApp.Model.ENUM
{
    public enum enumTimeZone
    {
        [Display(Name = "15 Phút")]
        ThirteenMinute = 0,
        [Display(Name = "1 Giờ")]
        OneHour = 1,
        [Display(Name = "4 Giờ")]
        FourHour = 2,
        [Display(Name = "1 Ngày")]
        OneDay = 3,
        [Display(Name = "1 Tuần")]
        OneWeek = 4,
        [Display(Name = "1 Tháng")]
        OneMonth = 5,
    }
    public enum enumInterval
    {
        [Display(Name = "15m")]
        ThirteenMinute = 0,
        [Display(Name = "1h")]
        OneHour = 1,
        [Display(Name = "4h")]
        FourHour = 2,
        [Display(Name = "1d")]
        OneDay = 3,
        [Display(Name = "1w")]
        OneWeek = 4,
        [Display(Name = "1m")]
        OneMonth = 5,
    }
    public enum enumCandleStick
    {
        [Display(Name = "Open")]
        O = 0,
        [Display(Name = "High")]
        H = 1,
        [Display(Name = "Low")]
        L = 2,
        [Display(Name = "Close")]
        C = 3
    }
    public enum enumChooseData
    {
        [Display(Name = "MA")]
        MA = 0,
        [Display(Name = "EMA")]
        EMA = 1,
        [Display(Name = "Volumne")]
        Volumne = 2,
        [Display(Name = "Nến 1")]
        CandleStick_1 = 3,
        [Display(Name = "Nến 2")]
        CandleStick_2 = 4,
        [Display(Name = "MACD")]
        MACD = 5,
        [Display(Name = "RSI")]
        RSI = 6,
        [Display(Name = "ADX")]
        ADX = 7,
        [Display(Name = "Giá hiện tại")]
        CurrentValue = 8
    }
    public enum enumUnit
    {
        [Display(Name = "%")]
        Ratio = 0,
        [Display(Name = "giá trị")]
        Value = 1,
    }
    public enum enumOperator
    {
        [Display(Name = ">")]
        Greater = 0,
        [Display(Name = ">=")]
        GreaterOrEqual = 1,
        [Display(Name = "=")]
        Equal = 2,
        [Display(Name = "<=")]
        LessThanOrEqual = 3,
        [Display(Name = "<")]
        LessThan = 4
    }

    public enum enumOptionTime
    {
        [Display(Name = "3 ngày")]
        ThreeDays = 1,
        [Display(Name = "1 tháng")]
        AMonth = 2,
        [Display(Name = "3 tháng")]
        ThreeMonths = 3,
        [Display(Name = "6 tháng")]
        SixMonths = 4,
        [Display(Name = "1 năm")]
        AYear = 5
    }

    public enum enumTime
    {
        Seconds = 1,
        Minutes = 2,
        Hours = 3,
        DayOfMonth = 4,
        Month = 5,
        DayOfWeek = 6,
        Year = 7,
    }

    public enum enumPriority
    {
        [Display(Name = "Ưu tiên thấp")]
        Low = 0,
        [Display(Name = "Ưu tiên")]
        Normal = 1,
        [Display(Name = "Ưu tiên cao")]
        High = 2,
        [Display(Name = "Quan trọng")]
        Important = 3,
        [Display(Name = "Rất quan trọng")]
        VeryImportant = 4
    }

    public enum enumIntervalNotify
    {
        [Display(Name = "Một lần")]
        Only = 0,
        [Display(Name = "Một phút/ lần")]
        OneMinute = 1,
        [Display(Name = "Hai phút/ lần")]
        TwoMinute = 2,
        [Display(Name = "Năm phút/ lần")]
        FiveMinute = 3,
        [Display(Name = "Mười phút/ lần")]
        TenMinute = 4,
        [Display(Name = "Mười năm phút/ lần")]
        FifteenMinute = 5,
        [Display(Name = "Ba mươi phút/ lần")]
        ThirtyMintue = 6,
        [Display(Name = "Một giờ/ lần")]
        OneHour = 7,
        [Display(Name = "Hai giờ/ lần")]
        TwoHour = 8,
        [Display(Name = "Bốn giờ/ lần")]
        FourHour = 9,
        [Display(Name = "Năm giờ/ lần")]
        FiveHour = 10,
        [Display(Name = "Mười hai giờ/ lần")]
        TwelveHour = 11,
        [Display(Name = "Một ngày/ lần")]
        OneDay = 12
    }

    public enum enumTelegramSendMessage
    {
        [Display(Name = "Thành công")]
        Success = 0,
        [Display(Name = "SĐT không hợp lệ")]
        PhoneInValid = -1,
        [Display(Name = "Telegram không sẵn sàng")]
        TelegramNotReady = -2,
        [Display(Name = "Lỗi không xác định")]
        UnknownError = -99
    }
}
