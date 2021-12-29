using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceApp.Data
{
    public class SeedData
    {
        public static List<CryptonDetailDataModel> GetCryptonList()
        {
            List<string> BLACK_LIST = new List<string> { };
            var cryptonModel = ExtensionMethod.DownloadJsonFile<CryptonDataModel>(ConstantValue.COIN_LIST);
            var output = cryptonModel.Data.Where(x => !BLACK_LIST.Contains(x.S)
                                            && x.S.Substring(x.S.Length - 4) == "USDT"
                                            && !x.S.Substring(0, x.S.Length - 4).Contains("USD")
                                            && !x.AN.Contains("Fan Token")
                                            && !x.S.Contains("UP")
                                            && !x.S.Contains("DOWN"))
                                    .OrderBy(x => x.S).ToList();
            return output;
        }
        public static List<CandleStickDataModel> LoadDatasource(string code, string interval)
        {
            var lstModel = new List<CandleStickDataModel>();
            try
            {
                var url = $"{ConstantValue.COIN_DETAIL}symbol={code}&interval={interval}";
                var arrData = ExtensionMethod.DownloadJsonArray(url);

                lstModel = arrData.Select(x => new CandleStickDataModel
                {
                    Time = ((int)((long)x[0] / 1000)).UnixTimeStampToDateTime(),
                    Open = float.Parse(x[1].ToString()),
                    High = float.Parse(x[2].ToString()),
                    Low = float.Parse(x[3].ToString()),
                    Close = float.Parse(x[4].ToString()),
                    Volumne = float.Parse(x[5].ToString())
                }).ToList();
                return lstModel;
            }
            catch
            {
                return lstModel;
            }
        }
    }
}
