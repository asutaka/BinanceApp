using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using BinanceApp.Model.ENUM;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BinanceApp.Data
{
    public class SeedData
    {
        public static List<CryptonDetailDataModel> GetCryptonList()
        {
            var cryptonModel = CommonMethod.DownloadJsonFile<CryptonDataModel>(ConstantValue.COIN_LIST);
            var output = cryptonModel.Data.Where(x => x.S.Substring(x.S.Length - 4) == "USDT"
                                            && !x.S.Substring(0, x.S.Length - 4).Contains("USD")
                                            && !x.AN.Contains("Fan Token")
                                            && !x.S.Contains("UP")
                                            && !x.S.Contains("DOWN"))
                                    .OrderBy(x => x.S).ToList();
            return output;
        }
        public static List<CryptonDetailDataModel> GetCryptonListWithFilter()
        {
            var cryptonModel = CommonMethod.DownloadJsonFile<CryptonDataModel>(ConstantValue.COIN_LIST);
            var output = cryptonModel.Data.Where(x => !StaticValues.lstBlackList.Any(y => y.S == x.S)
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
                var arrData = CommonMethod.DownloadJsonArray(url);

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

        public static DataTable GetDataChooseData()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumChooseData.MA;
            dr1["Name"] = enumChooseData.MA.GetDisplayName();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumChooseData.EMA;
            dr2["Name"] = enumChooseData.EMA.GetDisplayName();

            var dr3 = dt.NewRow();
            dr3["Id"] = (int)enumChooseData.Volumne;
            dr3["Name"] = enumChooseData.Volumne.GetDisplayName();

            var dr4 = dt.NewRow();
            dr4["Id"] = (int)enumChooseData.CandleStick_1;
            dr4["Name"] = enumChooseData.CandleStick_1.GetDisplayName();

            var dr5 = dt.NewRow();
            dr5["Id"] = (int)enumChooseData.CandleStick_2;
            dr5["Name"] = enumChooseData.CandleStick_2.GetDisplayName();

            var dr6 = dt.NewRow();
            dr6["Id"] = (int)enumChooseData.MACD;
            dr6["Name"] = enumChooseData.MACD.GetDisplayName();

            var dr7 = dt.NewRow();
            dr7["Id"] = (int)enumChooseData.RSI;
            dr7["Name"] = enumChooseData.RSI.GetDisplayName();

            var dr8 = dt.NewRow();
            dr8["Id"] = (int)enumChooseData.ADX;
            dr8["Name"] = enumChooseData.ADX.GetDisplayName();

            var dr9 = dt.NewRow();
            dr9["Id"] = (int)enumChooseData.CurrentValue;
            dr9["Name"] = enumChooseData.CurrentValue.GetDisplayName();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            dt.Rows.Add(dr5);
            dt.Rows.Add(dr6);
            dt.Rows.Add(dr7);
            dt.Rows.Add(dr8);
            dt.Rows.Add(dr9);
            return dt;
        }

        public static DataTable GetDataCandleStick()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumCandleStick.O;
            dr1["Name"] = enumCandleStick.O.GetDisplayName();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumCandleStick.H;
            dr2["Name"] = enumCandleStick.H.GetDisplayName();

            var dr3 = dt.NewRow();
            dr3["Id"] = (int)enumCandleStick.L;
            dr3["Name"] = enumCandleStick.L.GetDisplayName();

            var dr4 = dt.NewRow();
            dr4["Id"] = (int)enumCandleStick.C;
            dr4["Name"] = enumCandleStick.C.GetDisplayName();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            return dt;
        }

        public static DataTable GetOperator()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumOperator.Greater;
            dr1["Name"] = enumOperator.Greater.GetDisplayName();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumOperator.GreaterOrEqual;
            dr2["Name"] = enumOperator.GreaterOrEqual.GetDisplayName();

            var dr3 = dt.NewRow();
            dr3["Id"] = (int)enumOperator.Equal;
            dr3["Name"] = enumOperator.Equal.GetDisplayName();

            var dr4 = dt.NewRow();
            dr4["Id"] = (int)enumOperator.LessThanOrEqual;
            dr4["Name"] = enumOperator.LessThanOrEqual.GetDisplayName();

            var dr5 = dt.NewRow();
            dr5["Id"] = (int)enumOperator.LessThan;
            dr5["Name"] = enumOperator.LessThan.GetDisplayName();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            dt.Rows.Add(dr5);
            return dt;
        }

        public static DataTable GetUnit()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumUnit.Ratio;
            dr1["Name"] = enumUnit.Ratio.GetDisplayName();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumUnit.Value;
            dr2["Name"] = enumUnit.Value.GetDisplayName();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            return dt;
        }

        public static DataTable GetDataTimeZone()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumTimeZone.ThirteenMinute;
            dr1["Name"] = enumTimeZone.ThirteenMinute.GetDisplayName();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumTimeZone.OneHour;
            dr2["Name"] = enumTimeZone.OneHour.GetDisplayName();

            var dr3 = dt.NewRow();
            dr3["Id"] = (int)enumTimeZone.FourHour;
            dr3["Name"] = enumTimeZone.FourHour.GetDisplayName();

            var dr4 = dt.NewRow();
            dr4["Id"] = (int)enumTimeZone.OneDay;
            dr4["Name"] = enumTimeZone.OneDay.GetDisplayName();

            var dr5 = dt.NewRow();
            dr5["Id"] = (int)enumTimeZone.OneWeek;
            dr5["Name"] = enumTimeZone.OneWeek.GetDisplayName();

            var dr6 = dt.NewRow();
            dr6["Id"] = (int)enumTimeZone.OneMonth;
            dr6["Name"] = enumTimeZone.OneMonth.GetDisplayName();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            dt.Rows.Add(dr5);
            dt.Rows.Add(dr6);
            return dt;
        }

        public static DataTable GetDataPriority()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumPriority.Low;
            dr1["Name"] = enumPriority.Low.GetDisplayName();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumPriority.Normal;
            dr2["Name"] = enumPriority.Normal.GetDisplayName();

            var dr3 = dt.NewRow();
            dr3["Id"] = (int)enumPriority.High;
            dr3["Name"] = enumPriority.High.GetDisplayName();

            var dr4 = dt.NewRow();
            dr4["Id"] = (int)enumPriority.Important;
            dr4["Name"] = enumPriority.Important.GetDisplayName();

            var dr5 = dt.NewRow();
            dr5["Id"] = (int)enumPriority.VeryImportant;
            dr5["Name"] = enumPriority.VeryImportant.GetDisplayName();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            dt.Rows.Add(dr5);
            return dt;
        }

        public static DataTable GetDataInternalNotify()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            var dr1 = dt.NewRow();
            dr1["Id"] = (int)enumIntervalNotify.Only;
            dr1["Name"] = enumIntervalNotify.Only.GetDisplayName();

            var dr2 = dt.NewRow();
            dr2["Id"] = (int)enumIntervalNotify.OneMinute;
            dr2["Name"] = enumIntervalNotify.OneMinute.GetDisplayName();

            var dr3 = dt.NewRow();
            dr3["Id"] = (int)enumIntervalNotify.TwoMinute;
            dr3["Name"] = enumIntervalNotify.TwoMinute.GetDisplayName();

            var dr4 = dt.NewRow();
            dr4["Id"] = (int)enumIntervalNotify.FiveMinute;
            dr4["Name"] = enumIntervalNotify.FiveMinute.GetDisplayName();

            var dr5 = dt.NewRow();
            dr5["Id"] = (int)enumIntervalNotify.TenMinute;
            dr5["Name"] = enumIntervalNotify.TenMinute.GetDisplayName();

            var dr6 = dt.NewRow();
            dr6["Id"] = (int)enumIntervalNotify.FifteenMinute;
            dr6["Name"] = enumIntervalNotify.FifteenMinute.GetDisplayName();

            var dr7 = dt.NewRow();
            dr7["Id"] = (int)enumIntervalNotify.ThirtyMintue;
            dr7["Name"] = enumIntervalNotify.ThirtyMintue.GetDisplayName();

            var dr8 = dt.NewRow();
            dr8["Id"] = (int)enumIntervalNotify.OneHour;
            dr8["Name"] = enumIntervalNotify.OneHour.GetDisplayName();

            var dr9 = dt.NewRow();
            dr9["Id"] = (int)enumIntervalNotify.TwoHour;
            dr9["Name"] = enumIntervalNotify.TwoHour.GetDisplayName();

            var dr10 = dt.NewRow();
            dr10["Id"] = (int)enumIntervalNotify.FourHour;
            dr10["Name"] = enumIntervalNotify.FourHour.GetDisplayName();

            var dr11 = dt.NewRow();
            dr11["Id"] = (int)enumIntervalNotify.FiveHour;
            dr11["Name"] = enumIntervalNotify.FiveHour.GetDisplayName();

            var dr12 = dt.NewRow();
            dr12["Id"] = (int)enumIntervalNotify.TwelveHour;
            dr12["Name"] = enumIntervalNotify.TwelveHour.GetDisplayName();

            var dr13 = dt.NewRow();
            dr13["Id"] = (int)enumIntervalNotify.OneDay;
            dr13["Name"] = enumIntervalNotify.OneDay.GetDisplayName();

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            dt.Rows.Add(dr5);
            dt.Rows.Add(dr6);
            dt.Rows.Add(dr7);
            dt.Rows.Add(dr8);
            dt.Rows.Add(dr9);
            dt.Rows.Add(dr10);
            dt.Rows.Add(dr11);
            dt.Rows.Add(dr12);
            dt.Rows.Add(dr13);
            return dt;
        }
    }
}
