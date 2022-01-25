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
    public class TradeListNotifyJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                var model = StaticValues.tradeList;
                if (!model.IsNotify || StaticValues.IsTradeListChange)
                    return;

                var lstTask = new List<Task>();
                var lstNotify = new List<string>();
                foreach (var item in model.lData)
                {
                    var task = Task.Run(() =>
                    {
                        var currentVal = CommonMethod.GetCurrentValue(item.Coin);
                        var entity = StaticValues.lstNotiTrade.FirstOrDefault(x => x.Coin == item.Coin);
                        if(entity == null)
                        {
                            entity = new SendNotifyModel { Coin = item.Coin, Value = 0 };
                            StaticValues.lstNotiTrade.Add(entity);
                        }

                        var lAbove = item.Config.Where(x => x.IsAbove && currentVal > (double)x.Value && (x.Value > entity.Value || entity.Value == 0)).OrderBy(x => x.Value);
                        if (lAbove != null)
                        {
                            foreach (var itemAbove in lAbove)
                            {
                                var strNoti = $"{item.Coin} vượt lên trên { itemAbove.Value }";
                                lstNotify.Add(strNoti);
                                entity.Value = itemAbove.Value;
                            }
                        }

                        var lBelow = item.Config.Where(x => !x.IsAbove && currentVal < (double)x.Value && (x.Value <= entity.Value || entity.Value == 0)).OrderByDescending(x => x.Value);
                        if (lBelow != null)
                        {
                            foreach (var itemBelow in lBelow)
                            {
                                var strNoti = $"{item.Coin} giảm xuống dưới { itemBelow.Value }";
                                lstNotify.Add(strNoti);
                                entity.Value = itemBelow.Value;
                            }
                        }
                    });
                    lstTask.Add(task);
                }
                Task.WaitAll(lstTask.ToArray());
                if (lstNotify.Any())
                {
                    var strNotify = string.Join("\n", lstNotify.ToArray());
                    if (strNotify.Length > 500)
                        strNotify = strNotify.Substring(0, 500);
                    strNotify.CreateFile(nameof(TradeListNotifyJob));
                }
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"TradeListJob:Execute: {ex.Message}");
            }
        }
    }
}
