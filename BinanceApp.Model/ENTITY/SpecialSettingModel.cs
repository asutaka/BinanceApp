namespace BinanceApp.Model.ENTITY
{
    public class SpecialSettingModel
    {
        //Top 30
        public bool IsActiveTop30 { get; set; }
        public int PriorityTop30 { get; set; }
        //MCDX
        public bool IsActiveMCDX { get; set; }
        public int PriorityMCDX { get; set; }
        //Special
        public bool IsActiveSpecial { get; set; }
        public int PrioritySpecial { get; set; }
    }
}
