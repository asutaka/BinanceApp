using BinanceApp.Common;
using Quartz;
using System;
using System.Configuration;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class EmailScheduleJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            //int jobDuration = Convert.ToInt32(ConfigurationManager.AppSettings["JobDurationMilliseconds"]);
            //Thread.Sleep(jobDuration);
        }
    }
}
