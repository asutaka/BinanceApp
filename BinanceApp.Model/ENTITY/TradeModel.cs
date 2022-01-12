using System.Collections.Generic;

namespace BinanceApp.Model.ENTITY
{
    public class TradeListModel
    {
        public string Cron { get; set; }
        public int CronValue { get; set; }
        public List<TradeModel> lData { get; set; }
    }

    public class TradeModel
    {
        public string Coin { get; set; }
        public List<TradeDetailModel> Config { get; set; }
        public bool IsNotify { get; set; }// bật notify hay không
        public int Interval { get; set; }// 1 lần duy nhất, mỗi ngày một lần, theo chu kỳ
    }

    public class TradeDetailModel
    {
        public bool IsAbove { get; set; }
        public decimal Value { get; set; }
    }
}
