using System.Collections.Generic;

namespace BinanceApp.Model.ENTITY
{
    public class TradeListModel
    {
        public bool IsNotify { get; set; }// bật notify hay không
        public List<TradeModel> lData { get; set; }
    }

    public class TradeModel
    {
        public string Coin { get; set; }
        public List<TradeDetailModel> Config { get; set; }
    }

    public class TradeDetailModel
    {
        public bool IsAbove { get; set; }
        public decimal Value { get; set; }
    }
}
