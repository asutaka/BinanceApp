using BinanceApp.Common;
using Quartz;
using System;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class MCDXBottomValueScheduleJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                if (StaticValues.IsExecMCDX)
                    return;
                foreach (var item in StaticValues.lstMCDX)
                {
                    var val = CommonMethod.GetBottomValue(item.Coin);
                    if (StaticValues.IsExecMCDX)
                        return;
                    item.BottomRecent = val;
                }
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"MCDXBottomValueScheduleJob:Execute: {ex.Message}");
            }
        }
    }
}
