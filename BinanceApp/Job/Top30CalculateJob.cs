using BinanceApp.Analyze;
using BinanceApp.Common;
using BinanceApp.GUI.Child;
using Quartz;
using System;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class Top30CalculateJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                if (StaticValues.IsExecTop30)
                    return;
                StaticValues.IsExecTop30 = true;
                StaticValues.lstCryptonRank = CalculateMng.Top30();
                frmTop30.Instance().InitData();
                StaticValues.IsExecTop30 = false;
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"Top30CalculateJob:Execute: {ex.Message}");
            }
        }
    }
}
