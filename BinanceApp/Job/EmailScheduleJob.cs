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
            Console.WriteLine("deo hieu kieu gi");
            //int jobDuration = Convert.ToInt32(ConfigurationManager.AppSettings["JobDurationMilliseconds"]);
            //Thread.Sleep(jobDuration);
        }
    }

    public class EmailSchedule : Schedule
    {
        public EmailSchedule(IScheduler scheduler) : base(scheduler, nameof(EmailScheduleJob))
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
