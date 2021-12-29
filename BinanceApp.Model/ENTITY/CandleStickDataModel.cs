using System;

namespace BinanceApp.Model.ENTITY
{
    public class CandleStickDataModel
    {
        public CandleStickDataModel() { }
        public CandleStickDataModel(DateTime time, double low, double high, double open, double close, double volumne)
        {
            this.Time = time;
            this.Low = low;
            this.High = high;
            this.Open = open;
            this.Close = close;
            this.Volumne = volumne;
        }
        public DateTime Time { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Volumne { get; set; }
    }
}
