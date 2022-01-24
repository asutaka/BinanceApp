using System;

namespace BinanceApp.Model.ENTITY
{
    public class SendNotifyModel
    {
        public string Coin { get; set; }
        public decimal Value { get; set; }
        public DateTime SendTime { get; set; }
    }
}
