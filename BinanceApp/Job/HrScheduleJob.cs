using BinanceApp.Common;
using Quartz;
using System;
using System.Configuration;

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

    public class HrSchedule : Schedule
    {
        public HrSchedule(IScheduler scheduler) : base(scheduler, nameof(HrScheduleJob))
        {
        }

        protected override Tuple<JobBuilder, TriggerBuilder> Settings()
        {
            string cronJobExpression = ConfigurationManager.AppSettings["CronJobExpression"];
            TriggerBuilder triggerBuilder = TriggerBuilder.Create().WithCronSchedule(cronJobExpression);
            JobBuilder jobBuilder = JobBuilder.Create<EmailScheduleJob>();
            return new Tuple<JobBuilder, TriggerBuilder>(jobBuilder, triggerBuilder);
        }
    }
}
