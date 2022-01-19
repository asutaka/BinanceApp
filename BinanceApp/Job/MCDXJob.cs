using BinanceApp.Analyze;
using BinanceApp.Common;
using BinanceApp.GUI.Child;
using BinanceApp.Model.ENTITY;
using Quartz;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class MCDXJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                if (StaticValues.IsExecMCDX)
                    return;
                StaticValues.IsExecMCDX = true;
                StaticValues.lstMCDX.Clear();
                var lstTask = new List<Task>();
                foreach (var item in StaticValues.lstCoinFilter)
                {
                    var task = Task.Run(() =>
                    {
                        var val = CalculateMng.MCDX(item.S);
                        if (val.Item1)
                        {
                            var current = CommonMethod.GetCurrentValue(item.S);
                            var bottom = CommonMethod.GetBottomValue(item.S);
                            StaticValues.lstMCDX.Add(new MCDXModel
                            {
                                Coin = item.S,
                                Value = val.Item2,
                                OriginValue = current,
                                CurrentValue = current,
                                BottomRecent = bottom
                            });
                        }
                    });
                    lstTask.Add(task);
                }
                Task.WaitAll(lstTask.ToArray());
                StaticValues.lstMCDX = StaticValues.lstMCDX.OrderByDescending(x => x.Value).ToList();
                frmMCDX.Instance().InitData();
                StaticValues.IsExecMCDX = false;
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"MCDXJob:Execute: {ex.Message}");
            }
        }
    }
}
