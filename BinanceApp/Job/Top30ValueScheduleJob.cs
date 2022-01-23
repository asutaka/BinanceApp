using BinanceApp.Common;
using BinanceApp.GUI.Child;
using Quartz;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class Top30ValueScheduleJob : IJob
    {
        private int FLAG = CommonMethod.GetFlag(StaticValues.basicModel);
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                if (StaticValues.IsRealTimeDeleted)
                    return;
                var lstTask = new List<Task>();
                var lstResult = StaticValues.lstCryptonRank;
                foreach (var item in lstResult)
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
                if (StaticValues.IsRealTimeDeleted)
                    return;
                StaticValues.lstCryptonRank = lstResult;
                frmTop30.Instance().InitData();
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"Top30ValueScheduleJob:Execute: {ex.Message}");
            }
        }
    }
}
