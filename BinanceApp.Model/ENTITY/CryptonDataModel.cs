using System.Collections.Generic;

namespace BinanceApp.Model.ENTITY
{
    public class CryptonDataModel
    {
        public List<CryptonDetailDataModel> Data { get; set; }
    }
    public class CryptonDetailDataModel
    {
        public string S { get; set; }
        public string AN { get; set; }
    }
}
