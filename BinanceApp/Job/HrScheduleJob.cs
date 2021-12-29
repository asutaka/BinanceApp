using Quartz;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class HrScheduleJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            //int jobDuration = Convert.ToInt32(ConfigurationManager.AppSettings["JobDurationMilliseconds"]);
            //Thread.Sleep(jobDuration);
        }
    }
}
