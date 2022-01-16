using BinanceApp.Analyze;
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
    public class FollowListJob : IJob
    {
        private FollowModel followList = StaticValues.followList;
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                if (!followList.IsNotify 
                    || !followList.Coins.Any() 
                    || !followList.Follows.Any())
                    return;

                var lstTask = new List<Task>();
                foreach (var coin in followList.Coins)
                {
                    var task = Task.Run(() =>
                    {
                        foreach (var item in followList.Follows)
                        {
                            //Top30
                            var isTop30 = false;
                            if (item.IsTop30)
                            {
                                isTop30 = StaticValues.lstCryptonRank.Any(x => x.Coin == coin);
                            }
                            else
                            {
                                isTop30 = true;
                            }
                            //MCDX
                            var isMCDX = false;
                            if (item.IsMCDX)
                            {
                                isMCDX = CalculateMng.MCDX(coin).Item1;
                            }
                            else
                            {
                                isTop30 = true;
                            }
                            //Thiết lập 2
                            var isConfig2 = false;
                            if (item.IsConfig2)
                            {
                                isConfig2 = CalculateMng.Config(coin, StaticValues.advanceModel1).Item1;
                            }
                            else
                            {
                                isConfig2 = true;
                            }
                            //Thiết lập 3
                            var isConfig3 = false;
                            if (item.IsConfig3)
                            {
                                isConfig3 = CalculateMng.Config(coin, StaticValues.advanceModel2).Item1;
                            }
                            else
                            {
                                isConfig3 = true;
                            }
                            //Thiết lập 4
                            var isConfig4 = false;
                            if (item.IsConfig4)
                            {
                                isConfig4 = CalculateMng.Config(coin, StaticValues.advanceModel3).Item1;
                            }
                            else
                            {
                                isConfig4 = true;
                            }
                            //Thiết lập 5
                            var isConfig5 = false;
                            if (item.IsConfig5)
                            {
                                isConfig5 = CalculateMng.Config(coin, StaticValues.advanceModel4).Item1;
                            }
                            else
                            {
                                isConfig5 = true;
                            }
                            if (isTop30 && isMCDX && isConfig2 && isConfig3 && isConfig4 && isConfig5)
                                StaticValues.lNotify.Enqueue($"{coin}: Follow cho tín hiệu: {item.Title}");
                        }
                    });
                    lstTask.Add(task);
                }
                Task.WaitAll(lstTask.ToArray());
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"FollowListJob:Execute: {ex.Message}");
            }
        }
    }
}
