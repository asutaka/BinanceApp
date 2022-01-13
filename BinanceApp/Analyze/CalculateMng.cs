using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
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
            return (true, 0);
        }

        public static (bool, double) SPecial(string coin)
        {
            return (true, 0);
        }

        public static (bool, double) Config2(string coin)
        {
            return (true, 0);
        }
        public static (bool, double) Config3(string coin)
        {
            return (true, 0);
        }
        public static (bool, double) Config4(string coin)
        {
            return (true, 0);
        }
        public static (bool, double) Config5(string coin)
        {
            return (true, 0);
        }

        private static CryptonRankModel CalculateCryptonRank(string code)
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
            var url = $"{ConstantValue.COIN_DETAIL}symbol={code}&interval={interval}&limit={num}";
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
    }
}
