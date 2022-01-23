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
    public class MCDXCalculateJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                if (StaticValues.IsExecMCDX)
                    return;
                StaticValues.IsExecMCDX = true;
                StaticValues.lstMCDX = CalculateMng.MCDX();
                frmMCDX.Instance().InitData();
                StaticValues.IsExecMCDX = false;
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"MCDXCalculateJob:Execute: {ex.Message}");
            }
        }
    }
}
