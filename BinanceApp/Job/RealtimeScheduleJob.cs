using BinanceApp.Analyze;
using BinanceApp.Common;
using Quartz;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class RealtimeScheduleJob : IJob
    {
        private const int FLAG = 600;
        public void Execute(IJobExecutionContext context)
        {
            var countRecord = StaticValues.dtRealTime.Rows.Count;
            var lstTask = new List<Task>();
            for (int i = 0; i < countRecord; i++)
            {
                var task = Task.Run(() =>
                {
                    var coin = StaticValues.dtRealTime.Rows[i]["Coin"].ToString();
                    Console.WriteLine($"{coin}|i:{i}");
                    var countTime = int.Parse(StaticValues.dtRealTime.Rows[i]["CountTime"].ToString());
                    var bottomRecent = double.Parse(StaticValues.dtRealTime.Rows[i]["BottomRecent"].ToString());
                    var refValue = double.Parse(StaticValues.dtRealTime.Rows[i]["RefValue"].ToString());

                    var curValue = CommonMethod.GetCurrentValue(coin);
                    if (refValue <= 0)
                    {
                        refValue = curValue;
                    }
                    if (countTime <= 0)
                    {
                        bottomRecent = CommonMethod.GetBottomValue(coin); 
                        StaticValues.dtRealTime.Rows[i]["RefValue"] = curValue;
                        StaticValues.dtRealTime.Rows[i]["BottomRecent"] = bottomRecent;

                        var rank = CalculateMng.CalculateCryptonRank(coin);
                        StaticValues.dtRealTime.Rows[i]["Count"] = rank.Count;
                        StaticValues.dtRealTime.Rows[i]["Rate"] = rank.Rate;
                    }

                    if(countTime >= FLAG)
                    {
                        StaticValues.dtRealTime.Rows[i]["CountTime"] = 0;
                    }
                    StaticValues.dtRealTime.Rows[i]["Value"] = curValue;
                    var rateValue = Math.Round((-1 + (curValue / refValue)) * 100, 2);
                    var waveRecent = bottomRecent <= 0 ? 0 : Math.Round((-1 + (curValue / bottomRecent)) * 100, 2);
                    StaticValues.dtRealTime.Rows[i]["RateValue"] = rateValue;
                    StaticValues.dtRealTime.Rows[i]["WaveRecent"] = waveRecent;
                });
                lstTask.Add(task);
            }
            Task.WaitAll(lstTask.ToArray());
        }
    }
}
