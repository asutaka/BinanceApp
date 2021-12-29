using BinanceApp.Common;
using BinanceApp.GUI;
using Quartz;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class EmailScheduleJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            //Console.WriteLine("Deo hieu kieu gi");
            //int jobDuration = Convert.ToInt32(ConfigurationManager.AppSettings["JobDurationMilliseconds"]);
            //Thread.Sleep(jobDuration);
        }
    }
}
