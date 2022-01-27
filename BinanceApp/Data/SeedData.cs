using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using BinanceApp.Model.ENUM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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
        public static List<CandleStickDataModel> LoadDatasource(string code, int interval)
        {
            var lstModel = new List<CandleStickDataModel>();
            try
            {
                var url = $"{ConstantValue.COIN_DETAIL}symbol={code}&interval={((enumInterval)interval).GetDisplayName()}";
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

            //dt.Rows.Add(dr1);
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

        public static DataTable GetDataInternalNotifyFollow()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

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

        public static void InitData()
        {
            var wrkr = new BackgroundWorker();
            wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                var lstTask = new List<Task>();
                foreach (var item in StaticValues.lstCoinFilter)
                {
                    var task = Task.Run(() =>
                    {
                        StaticValues.dicDatasource15M.Add(item.S, LoadDatasource(item.S, (int)enumInterval.ThirteenMinute));
                    });
                    lstTask.Add(task);
                }
                Task.WaitAll(lstTask.ToArray());
            };
            wrkr.RunWorkerAsync();
        }

        private void tmp(int interval)
        {
            var files = Directory.EnumerateFiles($"{Directory.GetCurrentDirectory()}\\data\\{((enumInterval)interval).GetDisplayName()}", "*.*", SearchOption.AllDirectories);
            var lstEmptyLoad = StaticValues.lstCoinFilter.Where(x => !files.Any(y => y.Contains(x.S)));
            if (lstEmptyLoad.Any())
            {
                if(((enumInterval)interval) == enumInterval.ThirteenMinute)
                {
                    var wrkr = new BackgroundWorker();
                    wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                        var lstTask = new List<Task>();
                        foreach (var item in lstEmptyLoad)
                        {
                            var task = Task.Run(() =>
                            {
                                StaticValues.dicDatasource15M.Add(item.S, LoadDatasource(item.S, (int)enumInterval.ThirteenMinute));
                            });
                            lstTask.Add(task);
                        }
                        Task.WaitAll(lstTask.ToArray());
                    };
                    wrkr.RunWorkerAsync();
                }
                else if (((enumInterval)interval) == enumInterval.OneHour)
                {
                    var wrkr = new BackgroundWorker();
                    wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                        var lstTask = new List<Task>();
                        foreach (var item in lstEmptyLoad)
                        {
                            var task = Task.Run(() =>
                            {
                                StaticValues.dicDatasource1H.Add(item.S, LoadDatasource(item.S, (int)enumInterval.ThirteenMinute));
                            });
                            lstTask.Add(task);
                        }
                        Task.WaitAll(lstTask.ToArray());
                    };
                    wrkr.RunWorkerAsync();
                }
                else if (((enumInterval)interval) == enumInterval.FourHour)
                {
                    var wrkr = new BackgroundWorker();
                    wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                        var lstTask = new List<Task>();
                        foreach (var item in lstEmptyLoad)
                        {
                            var task = Task.Run(() =>
                            {
                                StaticValues.dicDatasource4H.Add(item.S, LoadDatasource(item.S, (int)enumInterval.ThirteenMinute));
                            });
                            lstTask.Add(task);
                        }
                        Task.WaitAll(lstTask.ToArray());
                    };
                    wrkr.RunWorkerAsync();
                }
                else if (((enumInterval)interval) == enumInterval.OneDay)
                {
                    var wrkr = new BackgroundWorker();
                    wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                        var lstTask = new List<Task>();
                        foreach (var item in lstEmptyLoad)
                        {
                            var task = Task.Run(() =>
                            {
                                StaticValues.dicDatasource1D.Add(item.S, LoadDatasource(item.S, (int)enumInterval.ThirteenMinute));
                            });
                            lstTask.Add(task);
                        }
                        Task.WaitAll(lstTask.ToArray());
                    };
                    wrkr.RunWorkerAsync();
                }
                else if (((enumInterval)interval) == enumInterval.OneWeek)
                {
                    var wrkr = new BackgroundWorker();
                    wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                        var lstTask = new List<Task>();
                        foreach (var item in lstEmptyLoad)
                        {
                            var task = Task.Run(() =>
                            {
                                StaticValues.dicDatasource1W.Add(item.S, LoadDatasource(item.S, (int)enumInterval.ThirteenMinute));
                            });
                            lstTask.Add(task);
                        }
                        Task.WaitAll(lstTask.ToArray());
                    };
                    wrkr.RunWorkerAsync();
                }
                else if (((enumInterval)interval) == enumInterval.OneMonth)
                {
                    var wrkr = new BackgroundWorker();
                    wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                        var lstTask = new List<Task>();
                        foreach (var item in lstEmptyLoad)
                        {
                            var task = Task.Run(() =>
                            {
                                StaticValues.dicDatasource1Month.Add(item.S, LoadDatasource(item.S, (int)enumInterval.ThirteenMinute));
                            });
                            lstTask.Add(task);
                        }
                        Task.WaitAll(lstTask.ToArray());
                    };
                    wrkr.RunWorkerAsync();
                }
            }
            //


            //foreach (var fileName in files)
            //{
            //    var isService = fileName.Contains("@service");
            //    using (var streamReader = File.OpenText(fileName))
            //    {
            //        var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //        if (lines.Length > 0)
            //        {
            //            lstRemoveFile.Add(fileName);
            //        }
            //        var strTemp = string.Empty;
            //        foreach (var line in lines)
            //        {
            //            if (line.Contains("#*#"))
            //            {
            //                strTemp += line.Replace("#*#", "");
            //                lstSend.Add(strTemp);
            //                strTemp = string.Empty;
            //            }
            //            else
            //            {
            //                strTemp += $"{line}\r\n";
            //            }
            //        }
            //    }
            //    foreach (var item in lstSend)
            //    {
            //        //send
            //        var result = await TeleClient.SendMessage(objUser.Phone, item, isService);
            //        Thread.Sleep(1000);
            //    }
            //    lstSend.Clear();
            //}
        }

        private void tmp1(string code, int interval)
        {
            //var path = $"{Directory.GetCurrentDirectory()}\\settings\\{fileName}";
            //var tmp = new List<CandleStickDataModel>().LoadJsonData("");


            try
            {
                string path = $"{Directory.GetCurrentDirectory()}\\data\\{((enumInterval)interval).GetDisplayName()}\\{fileName}";
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    var result = JsonConvert.DeserializeObject<T>(json);
                    return result;
                }
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"ExtensionMethod:LoadJsonFile: {ex.Message}");
                return default(T);
            }
        }
    }
}
