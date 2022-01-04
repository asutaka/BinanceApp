using System.Collections.Generic;

namespace BinanceApp.Model.ENTITY
{
    public class FollowModel
    {
        public bool IsNotify { get; set; }// bật notify hay không
        public int Interval { get; set; }// 1 lần duy nhất, mỗi ngày một lần, theo chu kỳ
        public List<string> Coins { get; set; }
        public List<FollowFxModel> Follows { get; set; }
    }

    public class FollowFxModel
    {
        public bool IsTop30 { get; set; }
        public bool IsMCDX { get; set; }
        public bool IsSpecial { get; set; }
        public bool IsConfig2 { get; set; }
        public bool IsConfig3 { get; set; }
        public bool IsConfig4 { get; set; }
        public bool IsConfig5 { get; set; }
    }
}
