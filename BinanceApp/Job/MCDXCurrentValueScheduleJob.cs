using BinanceApp.Common;
using BinanceApp.GUI.Child;
using Quartz;
using System;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class MCDXCurrentValueScheduleJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                if (StaticValues.IsExecMCDX)
                    return;
                foreach (var item in StaticValues.lstMCDX)
                {
                    var val = CommonMethod.GetCurrentValue(item.Coin);
                    if (StaticValues.IsExecMCDX)
                        return;
                    item.CurrentValue = val;
                }
                frmMCDX.Instance().InitData();
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"MCDXBottomValueScheduleJob:Execute: {ex.Message}");
            }
        }
    }
}
