namespace BinanceApp.Model.ENTITY
{
    public class IndicatorModel
    {
        public ElementModel Element1 { get; set; }
        public ElementModel Element2 { get; set; }
        public int Operator { get; set; }
        public decimal Result { get; set; }
        public int Unit { get; set; }
        public decimal Point { get; set; }
    }
}
