using BinanceApp.Analyze;
using BinanceApp.Common;
using BinanceApp.GUI.Child;
using BinanceApp.Model.ENUM;
using Quartz;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class RealtimeScheduleJob : IJob
    {
        private int FLAG = GetFlag();
        private static int GetFlag()
        {
            var model = StaticValues.basicModel;
            var div = 1;
            if(model.TimeZone == (int)enumTimeZone.OneHour)
            {
                div = div * 4;
            }
            else if(model.TimeZone == (int)enumTimeZone.FourHour)
            {
                div = div * 4 * 4;
            }
            else if (model.TimeZone == (int)enumTimeZone.OneDay)
            {
                div = div * 4 * 4 * 6;
            }
            else if (model.TimeZone == (int)enumTimeZone.OneWeek)
            {
                div = div * 4 * 4 * 6 * 7;
            }
            else if (model.TimeZone == (int)enumTimeZone.OneMonth)
            {
                div = div * 4 * 4 * 6 * 7 * 4;
            }
            var result = 1800 * model.Interval * div;
            return result; 
        }
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                if (StaticValues.IsRealTimeDeleted)
                {
                    return;
                }
                var lstTask = new List<Task>();
                foreach (var item in StaticValues.lstRealTimeShow)
                {
                    var task = Task.Run(() =>
                    {
                        var coin = item.Coin;
                        var curValue = CommonMethod.GetCurrentValue(coin);
                        if (curValue <= 0)
                            return;
                        if (item.RefValue <= 0)
                        {
                            item.RefValue = curValue;
                        }

                        if (item.CountTime <= 0)
                        {
                            item.BottomRecent = CommonMethod.GetBottomValue(coin);
                            item.RefValue = curValue;
                        }

                        if(item.CountTime <= 0 || item.Rate <= 0)
                        {
                            var rank = CalculateMng.CalculateCryptonRank(coin);
                            item.Count = rank.Count;
                            item.Rate = rank.Rate;
                        }

                        if (item.CountTime >= FLAG)
                        {
                            item.CountTime = 0;
                        }
                        item.Value = curValue;
                        var rateValue = Math.Round((-1 + (curValue / item.RefValue)) * 100, 2);
                        var waveRecent = item.BottomRecent <= 0 ? 0 : Math.Round((-1 + (curValue / item.BottomRecent)) * 100, 2);
                        item.RateValue = rateValue;
                        item.WaveRecent = waveRecent;
                        item.CountTime++;
                    });
                    lstTask.Add(task);
                }
                Task.WaitAll(lstTask.ToArray());
                frmRealTime.Instance().InitData();
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"RealtimeScheduleJob:Execute: {ex.Message}");
            }
        }
    }
}
