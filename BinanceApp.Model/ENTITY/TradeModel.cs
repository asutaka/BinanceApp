using System.Collections.Generic;

namespace BinanceApp.Model.ENTITY
{
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
