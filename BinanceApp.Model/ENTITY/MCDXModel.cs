namespace BinanceApp.Model.ENTITY
{
    public class MCDXModel
    {
        public int STT { get; set; }
        public string Coin { get; set; }
        public string CoinName { get; set; }
        public double RefValue { get; set; }
        public double Value { get; set; }
        public double BottomRecent { get; set; }
        public double MCDXValue { get; set; }
        public double RateValue { get; set; }
        public double WaveRecent { get; set; }
        public int CountTime { get; set; }
    }
}
