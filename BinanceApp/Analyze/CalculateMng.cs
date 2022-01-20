using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using BinanceApp.Model.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacTec.TA.Library;

namespace BinanceApp.Analyze
{
    public static class CalculateMng
    {
        public static void Top30()
        {
            var lstTask = new List<Task>();
            foreach (var item in StaticValues.lstCoin)
            {
                var task = Task.Run(() =>
                {
                    StaticValues.lstCryptonRank.Add(CalculateCryptonRank(item.S));
                });
                lstTask.Add(task);
            }
            Task.WaitAll(lstTask.ToArray());
            StaticValues.lstCryptonRank = StaticValues.lstCryptonRank.Where(x => x != null).OrderByDescending(x => x.Count).ThenByDescending(x => x.Rate).Take(30).ToList();
        }

        public static (bool, double) MCDX(string coin)
        {
            var data = GetData(coin, (int)enumInterval.OneHour);
            if (data == null || !data.Any())
                return (false, 0);
            var arrClose = data.Select(x => x.Close).ToArray();
            var count = arrClose.Count();

            double[] output1 = new double[1000];
            double[] output2 = new double[1000];
            Core.Rsi(0, count - 1, arrClose, 50, out int outBegIdx1, out int outNBElement1, output1);
            Core.Rsi(0, count - 1, arrClose, 40, out int outBegIdx2, out int outNBElement2, output2);
            var rsi50 = output1[count - 51];
            var rsi40 = output2[count - 41];
            var banker_rsi = 1.5 * (rsi50 - 50);
            if (banker_rsi > 20)
                banker_rsi = 20;
            if (banker_rsi < 0)
                banker_rsi = 0;
            var signal = StaticValues.basicModel.ListModel.First(x => x.Indicator == (int)enumChooseData.MCDX).Signal;
            return (banker_rsi >= signal, banker_rsi);
        }

        public static (bool, double) SPecial(string coin)
        {
            return (true, 0);
        }

        public static (bool, double) Config(string coin, AdvanceSettingModel model)
        {
            double result = 0;
            var lstTask = new List<Task>();
            foreach (var item in model.LstInterval)
            {
                if (item == (int)enumInterval.ThirteenMinute)
                {
                    var interval = (int)enumInterval.ThirteenMinute;
                    var task = Task.Run(() =>
                    {
                        result += (double)CalculateFromInterval(coin, model.LstElement15M, model.LstIndicator15M, interval);
                    });
                    lstTask.Add(task);
                }
                else if (item == (int)enumInterval.OneHour)
                {
                    var interval = (int)enumInterval.OneHour;
                    var task = Task.Run(() =>
                    {
                        result += (double)CalculateFromInterval(coin, model.LstElement1H, model.LstIndicator1H, interval);
                    });
                    lstTask.Add(task);
                }
                else if (item == (int)enumInterval.FourHour)
                {
                    var interval = (int)enumInterval.FourHour;
                    var task = Task.Run(() =>
                    {
                        result += (double)CalculateFromInterval(coin, model.LstElement4H, model.LstIndicator4H, interval);
                    });
                    lstTask.Add(task);
                }
                else if (item == (int)enumInterval.OneDay)
                {
                    var interval = (int)enumInterval.OneDay;
                    var task = Task.Run(() =>
                    {
                        result += (double)CalculateFromInterval(coin, model.LstElement1D, model.LstIndicator1D, interval);
                    });
                    lstTask.Add(task);
                }
                else if (item == (int)enumInterval.OneWeek)
                {
                    var interval = (int)enumInterval.OneWeek;
                    var task = Task.Run(() =>
                    {
                        result += (double)CalculateFromInterval(coin, model.LstElement1W, model.LstIndicator1W, interval);
                    });
                    lstTask.Add(task);
                }
                else if (item == (int)enumInterval.OneMonth)
                {
                    var interval = (int)enumInterval.OneMonth;
                    var task = Task.Run(() =>
                    {
                        result += (double)CalculateFromInterval(coin, model.LstElement1M, model.LstIndicator1M, interval);
                    });
                    lstTask.Add(task);
                }
            }
            Task.WaitAll(lstTask.ToArray());
            return (result >= (double)model.Point, result);
        }

        private static decimal CalculateFromInterval(string coin, List<ElementModel> elementModels, List<IndicatorModel> indicatorModels, int interval)
        {
            var lstOutputIndicator = new List<OutputIndicatorModel>();
            var data = GetData(coin, (int)enumInterval.OneHour);
            if (data == null || !data.Any())
                return 0;
            var arrOpen = data.Select(x => x.Open).ToArray();
            var arrClose = data.Select(x => x.Close).ToArray();
            var arrHigh = data.Select(x => x.High).ToArray();
            var arrLow = data.Select(x => x.Low).ToArray();
            var arrVolumne = data.Select(x => x.Volumne).ToArray();
            var count = arrClose.Count();

            var lstTask = new List<Task>();
            foreach (var item in elementModels.To<List<GeneralModel>>())
            {
                var task = Task.Run(() =>
                {
                    lstOutputIndicator.Add(CalculateIndicator(coin, item, arrOpen, arrClose, arrHigh, arrLow, arrVolumne, count));
                });
                lstTask.Add(task);
            }
            Task.WaitAll(lstTask.ToArray());
            return MethodMark(coin, lstOutputIndicator, indicatorModels);
        }
        private static OutputIndicatorModel CalculateIndicator(string coin, GeneralModel model, double[] arrOpen, double[] arrClose, double[] arrHigh, double[] arrLow, double[] arrVolumne, int count)
        {
            var outputModel = new OutputIndicatorModel { Indicator = model.Indicator, Period = model.Period, Value = 0 };
            double[] output1 = new double[1000];
            double[] output2 = new double[1000];
            double[] output3 = new double[1000];
            if (model.Indicator == (int)enumChooseData.MA)
            {
                Core.MovingAverage(0, count - 1, arrClose, model.Period, Core.MAType.Sma, out int outBegIdx, out int outNBElement, output1);
                outputModel.Value = output1[count - model.Period];
            }
            else if (model.Indicator == (int)enumChooseData.EMA)
            {
                Core.MovingAverage(0, count - 1, arrClose, model.Period, Core.MAType.Ema, out int outBegIdx, out int outNBElement, output1);
                outputModel.Value = output1[count - model.Period];
            }
            else if (model.Indicator == (int)enumChooseData.Volumne)
            {
                Core.MovingAverage(0, count - 1, arrVolumne, model.Period, Core.MAType.Sma, out int outBegIdx, out int outNBElement, output1);
                outputModel.Value = output1[count - model.Period];
            }
            else if (model.Indicator == (int)enumChooseData.CandleStick_1)
            {
                var takeNum = 1;
                if (model.Period == (int)enumCandleStick.O)
                {
                    outputModel.Value = arrOpen.ElementAt(count - takeNum);
                }
                if (model.Period == (int)enumCandleStick.H)
                {
                    outputModel.Value = arrHigh.ElementAt(count - takeNum);
                }
                if (model.Period == (int)enumCandleStick.L)
                {
                    outputModel.Value = arrLow.ElementAt(count - takeNum);
                }
                if (model.Period == (int)enumCandleStick.C)
                {
                    outputModel.Value = arrClose.ElementAt(count - takeNum);
                }
            }
            else if (model.Indicator == (int)enumChooseData.CandleStick_2)
            {
                var takeNum = 2;
                if (model.Period == (int)enumCandleStick.O)
                {
                    outputModel.Value = arrOpen.ElementAt(count - takeNum);
                }
                if (model.Period == (int)enumCandleStick.H)
                {
                    outputModel.Value = arrHigh.ElementAt(count - takeNum);
                }
                if (model.Period == (int)enumCandleStick.L)
                {
                    outputModel.Value = arrLow.ElementAt(count - takeNum);
                }
                if (model.Period == (int)enumCandleStick.C)
                {
                    outputModel.Value = arrClose.ElementAt(count - takeNum);
                }
            }
            else if (model.Indicator == (int)enumChooseData.MACD)
            {
                Core.Macd(0, count - 1, arrClose, model.Low, model.High, model.Signal, out int outBegIdx, out int outNbElement, output1, output2, output3);
                outputModel.Value = output1[count - 1];
            }
            else if (model.Indicator == (int)enumChooseData.RSI)
            {
                Core.Rsi(0, count - 1, arrClose, model.Period, out int outBegIdx, out int outNBElement, output1);
                outputModel.Value = output1[count - model.Period];
            }
            else if (model.Indicator == (int)enumChooseData.ADX)
            {
                Core.Adx(0, count - 1, arrHigh, arrLow, arrClose, model.Period, out int outBegIdx, out int outNBElement, output1);
                outputModel.Value = output1[count - model.Period];
            }
            else if (model.Indicator == (int)enumChooseData.CurrentValue)
            {
                outputModel.Value = CommonMethod.GetCurrentValue(coin);
            }
            return outputModel;
        }
        private static decimal MethodMark(string coin, List<OutputIndicatorModel> lstModel, List<IndicatorModel> indicatorModels)
        {
            decimal point = 0;
            var lstTask = new List<Task>();
            foreach (var item in indicatorModels)
            {
                var task = Task.Run(() =>
                {
                    point += MethodMarkUnit(coin, lstModel, item);
                });
                lstTask.Add(task);
            }
            Task.WaitAll(lstTask.ToArray());
            return point;
        }
        private static decimal MethodMarkUnit(string coin, List<OutputIndicatorModel> lstModel, IndicatorModel indicator)
        {
            decimal point = 0;
            var indicator1 = indicator.Element1.To<GeneralModel>();
            var indicator2 = indicator.Element2.To<GeneralModel>();
            double result = (double)indicator.Result;

            if (indicator.Unit == (int)enumUnit.Ratio)
            {
                var currentValue = CommonMethod.GetCurrentValue(coin);
                result = (double)indicator.Result * currentValue / 100;
            }
            double firstValue = lstModel.FirstOrDefault(x => x.Indicator == indicator1.Indicator && x.Period == indicator1.Period).Value;
            double secondValue = 0;
            if (indicator2 != null)
                secondValue = lstModel.FirstOrDefault(x => x.Indicator == indicator2.Indicator && x.Period == indicator2.Period).Value;
            double div = firstValue - secondValue;
            if (div < 0)
                return point;
            if (indicator.Operator == (int)enumOperator.Equal
                && div == result)
            {
                point += indicator.Point;
            }
            else if (indicator.Operator == (int)enumOperator.Greater
                && div > result)
            {
                point += indicator.Point;
            }
            else if (indicator.Operator == (int)enumOperator.GreaterOrEqual
                && div >= result)
            {
                point += indicator.Point;
            }
            else if (indicator.Operator == (int)enumOperator.LessThan
                && div < result)
            {
                point += indicator.Point;
            }
            else if (indicator.Operator == (int)enumOperator.LessThanOrEqual
                && div <= result)
            {
                point += indicator.Point;
            }
            return point;
        }
        public static CryptonRankModel CalculateCryptonRank(string code)
        {
            try
            {
                int count = 1;
                double sum = 0;
                var lSource = StaticValues.dicDatasource1H.First(x => x.Key == code).Value;
                if (lSource == null)
                    return new CryptonRankModel { Coin = code, Count = count, Rate = Math.Round(sum / count, 2) };

                DateTime dtMin = DateTime.MinValue, dtMax = DateTime.MinValue, dtMin_Temp = DateTime.MinValue;
                int leftMax = 0, rightMin = 0, rightMax = 0;
                double min = 0, max = 0, min_Temp = 0;
                foreach (var item in lSource)
                {
                    CheckMinMax();
                    if (rightMax >= 2)
                    {
                        var rate = Math.Round((max - min) * 100 / min, 0);
                        if (leftMax >= 2 && rate >= 10)
                        {
                            sum += rate;
                            count++;
                        }
                        min = min_Temp;
                        dtMin = dtMin_Temp;
                        min_Temp = 0;
                        dtMin_Temp = DateTime.MinValue;
                        rightMin = 0;
                        rightMax = 0;
                        leftMax = 0;
                        max = 0;
                        dtMax = DateTime.MinValue;
                        CheckMinMax();
                    }
                    else if (rightMax > 0)
                    {
                        min_Temp = item.Low;
                        dtMin_Temp = item.Time;
                    }

                    void CheckMinMax()
                    {
                        if (min == 0)
                        {
                            min = item.Low;
                            dtMin = item.Time;
                        }
                        if (item.Low < min)
                        {
                            rightMin = 0;
                            min = item.Low;
                            dtMin = item.Time;
                        }
                        else
                        {
                            rightMin++;
                        }
                        //reset
                        if (rightMin == 0)
                        {
                            max = 0;
                            leftMax = 0;
                            rightMax = 0;
                        }
                        else
                        {
                            if (max < item.High)
                            {
                                rightMax = 0;
                                leftMax++;
                                max = item.High;
                                dtMax = item.Time;
                            }
                            else
                            {
                                rightMax++;
                            }
                        }
                    }
                }

                return new CryptonRankModel { Coin = code, Count = count, Rate = Math.Round(sum / count, 2), OriginValue = CommonMethod.GetCurrentValue(code) };
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"CalculateMng|CalculateCryptonRank|{code}: {ex.Message}");
                return new CryptonRankModel { Coin = code, Count = 1, Rate = 0 };
            }
        }
        private static double ADX(double[] arrHigh, double[] arrLow, double[] arrClose, int period, int count)
        {
            try
            {
                var output = new double[1000];
                Core.Adx(0, count - 1, arrHigh, arrLow, arrClose, period, out var outBegIdx, out var outNBElement, output);
                return output[count - period];
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"CalculateMng:ADX: {ex.Message}");
            }
            return 0;
        }
        private static List<CandleStickDataModel> CandleSticks(string code, int interval, int num)
        {
            var lstResult = new List<CandleStickDataModel>();
            var url = $"{ConstantValue.COIN_DETAIL}symbol={code}&interval={((enumInterval)interval).GetDisplayName()}&limit={num}";
            var arrData = CommonMethod.DownloadJsonArray(url);
            if (arrData == null)
                return lstResult;
            foreach (var item in arrData)
            {
                lstResult.Add(new CandleStickDataModel
                {
                    Open = double.Parse(arrData[0][1].ToString()),
                    High = double.Parse(arrData[0][2].ToString()),
                    Low = double.Parse(arrData[0][3].ToString()),
                    Close = double.Parse(arrData[0][4].ToString()),
                });
            }
            return lstResult;
        }
        private static double CurrentValue(string code)
        {
            return CommonMethod.GetCurrentValue(code);
        }
        private static double MA(double [] arrInput, Core.MAType type, int period, int count)
        {
            try
            {
                var output = new double[1000];
                Core.MovingAverage(0, count - 1, arrInput, period, Core.MAType.Sma, out var outBegIdx, out var outNBElement, output);
                return output[count - period];
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"CalculateMng:MA: {ex.Message}");
            }
            return 0;
        }
        private static double MACD(double[] arrInput, int high, int low, int signal, int count)
        {
            try
            {
                var output = new double[1000];
                Core.Macd(0, count - 1, arrInput, low, high, signal, out var outBegIdx, out var outNbElement, output, new double[1000], new double[1000]);
                return output[count - 1];
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"CalculateMng:MACD: {ex.Message}");
            }
            return 0;
        }
        private static (double, double) MCDX(double[] arrInput, int count)
        {
            try
            {
                var rsi50 = RSI(arrInput, 50, count);
                var rsi40 = RSI(arrInput, 40, count); ;
                //
                var banker_rsi = 1.5 * (rsi50 - 50);
                if (banker_rsi > 20)
                    banker_rsi = 20;
                if (banker_rsi < 0)
                    banker_rsi = 0;
                //
                var hot_rsi = 0.7 * (rsi40 - 30);
                if (hot_rsi > 20)
                    hot_rsi = 20;
                if (hot_rsi < 0)
                    hot_rsi = 0;

                return (banker_rsi, hot_rsi);
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"CalculateMng:MCDX: {ex.Message}");
            }
            return (0, 0);

        }
        private static double RSI(double[] arrInput, int period, int count)
        {
            try
            {
                var output = new double[1000];
                Core.Rsi(0, count - 1, arrInput, period, out var outBegIdx, out var outNBElement, output);
                return output[count - period];
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"CalculateMng:RSI: {ex.Message}");
            }
            return 0;
        }
        private static List<CandleStickDataModel> GetLocalData(string coin, int interval)
        {
            switch (interval)
            {
                case (int)enumInterval.ThirteenMinute: return StaticValues.dicDatasource15M[coin];
                case (int)enumInterval.OneHour: return StaticValues.dicDatasource1H[coin];
                case (int)enumInterval.FourHour: return StaticValues.dicDatasource4H[coin];
                case (int)enumInterval.OneDay: return StaticValues.dicDatasource1D[coin];
                case (int)enumInterval.OneWeek: return StaticValues.dicDatasource1W[coin];
                case (int)enumInterval.OneMonth: return StaticValues.dicDatasource1Month[coin];
                default: return new List<CandleStickDataModel>();
            }
        }
        private static List<CandleStickDataModel> GetData(string coin, int interval)
        {
            var data = GetLocalData(coin, interval);
            var lstLatest = CandleSticks(coin, interval, 2);
            if (lstLatest == null || !lstLatest.Any())
                return null;
            if (data.ElementAt(0).Time == lstLatest.ElementAt(1).Time)
            {
                var modelUpdate = lstLatest.ElementAt(1);
                data.ElementAt(0).High = modelUpdate.High;
                data.ElementAt(0).Low = modelUpdate.Low;
                data.ElementAt(0).Open = modelUpdate.Open;
                data.ElementAt(0).Close = modelUpdate.Close;
                data.ElementAt(0).Time = modelUpdate.Time;
                data.ElementAt(0).Volumne = modelUpdate.Volumne;

                var model = lstLatest.ElementAt(0);
                data.Insert(0, model);
            }
            else
            {
                var modelUpdate = lstLatest.ElementAt(0);
                data.ElementAt(0).High = modelUpdate.High;
                data.ElementAt(0).Low = modelUpdate.Low;
                data.ElementAt(0).Open = modelUpdate.Open;
                data.ElementAt(0).Close = modelUpdate.Close;
                data.ElementAt(0).Time = modelUpdate.Time;
                data.ElementAt(0).Volumne = modelUpdate.Volumne;
            }
            return data;
        }
        private class OutputIndicatorModel
        {
            public int Indicator { get; set; }
            public int Period { get; set; }
            public double Value { get; set; }
        }
    }
}
