using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution]
    public class TradeListJob : IJob
    {
        private bool isPrepare;
        private List<TradeListJobModel> lstTradeList = null; 
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                if (!isPrepare)
                {
                    Prepare();
                    isPrepare = true;
                }

                var lstTask = new List<Task>();
                foreach (var item in lstTradeList)
                {
                    var task = Task.Run(() =>
                    {
                        if (item.Cycle > item.Count)
                        {
                            item.Count++;
                        }
                        else
                        {
                            item.Count = 1;
                            var currentVal = CommonMethod.GetCurrentValue(item.Coin);
                            var above = item.Config.Where(x => x.IsAbove && currentVal > (double)x.Value).OrderByDescending(x => x.Value).FirstOrDefault();
                            if (above != null)
                            {
                                var strNoti = $"{item.Coin} Above { above.Value }";
                                if (!item.NotifyAboveText.Equals(strNoti))
                                {
                                    item.NotifyAboveText = strNoti;
                                    StaticValues.lNotify.Enqueue(strNoti);
                                }
                            }
                            var below = item.Config.Where(x => !x.IsAbove && currentVal < (double)x.Value).OrderBy(x => x.Value).FirstOrDefault();
                            if (below != null)
                            {
                                var strNoti = $"{item.Coin} Below { above.Value }";
                                if (!item.NotifyBelowText.Equals(strNoti))
                                {
                                    item.NotifyBelowText = strNoti;
                                    StaticValues.lNotify.Enqueue(strNoti);
                                }
                            }
                        }
                    });
                    lstTask.Add(task);
                }
                Task.WaitAll(lstTask.ToArray());
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"TradeListJob:Execute: {ex.Message}");
            }
        }
        private void Prepare()
        {
            var dicInterval = new Dictionary<int, int>();
            dicInterval.Add(0,1);
            dicInterval.Add(1,2);
            dicInterval.Add(2,5);
            dicInterval.Add(3,10);
            dicInterval.Add(4,15);
            dicInterval.Add(5,60);
            dicInterval.Add(6,120);
            dicInterval.Add(7,240);
            dicInterval.Add(8,300);
            dicInterval.Add(9,720);
            dicInterval.Add(10,1440);
            lstTradeList = (from entityTrade in StaticValues.tradeList.lData.Where(x => x.IsNotify)
                            join entityDic in dicInterval.AsEnumerable() on entityTrade.Interval equals entityDic.Key
                            select new TradeListJobModel { Coin = entityTrade.Coin, Config = entityTrade.Config, Cycle = entityDic.Value / StaticValues.Scron_TradeList_Value, Count = 1 }).ToList();
        }

        private class TradeListJobModel
        {
            public string Coin { get; set; }
            public List<TradeDetailModel> Config { get; set; }
            public int Cycle { get; set; }
            public int Count { get; set; }
            public string NotifyAboveText { get; set; }
            public string NotifyBelowText { get; set; }
        }
    }
}
