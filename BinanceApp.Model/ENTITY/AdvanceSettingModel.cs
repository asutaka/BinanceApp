using System.Collections.Generic;

namespace BinanceApp.Model.ENTITY
{
    public class AdvanceSettingModel
    {
        public List<int> LstInterval { get; set; }
        public List<ElementModel> LstElement15M { get; set; }
        public List<ElementModel> LstElement1H { get; set; }
        public List<ElementModel> LstElement4H { get; set; }
        public List<ElementModel> LstElement1D { get; set; }
        public List<ElementModel> LstElement1W { get; set; }
        public List<ElementModel> LstElement1M { get; set; }
        public List<IndicatorModel> LstIndicator15M { get; set; }
        public List<IndicatorModel> LstIndicator1H { get; set; }
        public List<IndicatorModel> LstIndicator4H { get; set; }
        public List<IndicatorModel> LstIndicator1D { get; set; }
        public List<IndicatorModel> LstIndicator1W { get; set; }
        public List<IndicatorModel> LstIndicator1M { get; set; }
    }
}
