using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinanceApp.Analyze
{
    public static class CalculateMng
    {
        public static void CryptonRank()
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
        private static CryptonRankModel CalculateCryptonRank(string code)
        {
            try
            {
                int count = 1;
                double sum = 0;
                var lSource = StaticValues.dicDatasource.First(x => x.Key == code).Value;
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
    }
}
