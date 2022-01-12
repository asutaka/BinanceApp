using BinanceApp.Common.ScheduleJob.ScheduleJobLib;
using Quartz;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace BinanceApp.Job.ScheduleJob
{
    public class ScheduleMng : ScheduleContext
    {
        private List<ScheduleMember> _lstSchedule = new List<ScheduleMember>();

        private ScheduleMng()
        {
            Props = new NameValueCollection
            {
                //{"quartz.scheduler.interruptJobsOnShutdownWithWait", "true"},
                {"quartz.scheduler.instanceName", nameof(ScheduleMng)}
            };
            Start();
        }

        private static ScheduleMng _instance = null;
        public static ScheduleMng Instance()
        {
            _instance = _instance ?? new ScheduleMng();
            return _instance;
        }

        public void AddSchedule(ScheduleMember schedule)
        {
            _lstSchedule.Add(schedule);
        }

        public List<ScheduleMember> GetSchedules()
        {
            return _lstSchedule;
        }
        
        public IScheduler GetScheduler()
        {
            return Scheduler;
        }

        public bool AnyTaskRunning()
        {
            var value = _lstSchedule.Any(x => x.IsTaskRunning());
            return value;
        }

        public void StartAllJob()
        {
            foreach (var item in _lstSchedule)
            {
                if (!item.IsStarted())
                {
                    item.Start();
                }
                else
                {
                    item.Resume();
                }
            }
        }

        public void StopAllJob()
        {
            foreach (var item in _lstSchedule)
            {
                item.Pause();
            }
        }
    }

    public class ScheduleMember : Schedule
    {
        private readonly JobBuilder _job;
        private readonly string _cron;
        public ScheduleMember(IScheduler scheduler, JobBuilder job, string cron, string name) : base(scheduler, name)
        {
            _cron = cron;
            _job = job;
        }

        protected override Tuple<JobBuilder, TriggerBuilder> Settings()
        {
            string cronJobExpression = _cron;
            TriggerBuilder triggerBuilder = TriggerBuilder.Create().WithCronSchedule(cronJobExpression);
            //JobBuilder jobBuilder = JobBuilder.Create<IJob>();
            return new Tuple<JobBuilder, TriggerBuilder>(_job, triggerBuilder);
        }
    }
}
