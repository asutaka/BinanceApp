namespace BinanceApp.Model.ENTITY
{
    public class CryptonRankModel
    {
        public string Coin { get; set; }
        public int Count { get; set; }
        public double Rate { get; set; }
        public double OriginValue { get; set; }
        public double CurrentValue { get; set; }
        public double BottomRecent { get; set; }
    }
}
