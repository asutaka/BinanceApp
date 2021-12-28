using Quartz;
using Quartz.Impl.Matchers;
using System;
using System.Linq;

namespace BinanceApp.Common
{
    public delegate void TaskExecution();
    public delegate void TaskExecutionComplete(Exception exception);
    public delegate bool ShouldTaskExecution();
    public interface ISchedule
    {
        string Name { get; }

        event TaskExecution TaskStarted;
        event TaskExecutionComplete TaskExecuted;

        bool IsStarted();
        bool IsTaskRunning();
        bool IsPaused();

        void Start();
        void Pause();
        void Resume();

        DateTime? NextEstimatedFireTime();

    }

    //  public abstract class Schedule : ISchedule
    //  {
    //      public event TaskExecution TaskStarted;
    //      public event TaskExecution TaskVetoed;
    //      public event TaskExecutionComplete TaskExecuted;


    //      private readonly IScheduler Scheduler;

    //      public readonly string Name;
    //      private string TriggerName
    //      {
    //          get
    //          {
    //              return Name + "Trigger";
    //          }
    //      }
    //      private string JobName
    //      {
    //          get
    //          {
    //              return Name + "Job";
    //          }
    //      }
    //      private string ListenerName
    //      {
    //          get
    //          {
    //              return Name + "Listener";
    //          }
    //      }

    //      protected Schedule(IScheduler scheduler, string name)
    //      {
    //          if (String.IsNullOrEmpty(name))
    //          {
    //              throw new NullReferenceException("Schedule Name required");
    //          }
    //          if (scheduler == null)
    //          {
    //              throw new NullReferenceException("Scheduler required");
    //          }

    //          Name = name;
    //          Scheduler = scheduler;
    //      }

    //      /// <summary>
    //      /// this is not cluster aware
    //      /// </summary>
    //      /// <returns></returns>
    //      /*https://stackoverflow.com/questions/24568282/check-whether-the-job-is-running-or-not*/
    //      public bool IsTaskRunning()
    //      {
    //          bool value = Scheduler.GetCurrentlyExecutingJobs().Any(x =>
    //              x.JobDetail.Key.Name.Equals(JobName, StringComparison.OrdinalIgnoreCase));
    //          return value;
    //      }

    //      /*https://stackoverflow.com/questions/21527841/schedule-multiple-jobs-in-quartz-net*/

    //      protected void ScheduleTask(JobBuilder jobBuilder, TriggerBuilder triggerBuilder)
    //      {
    //          IJobDetail job = jobBuilder.WithIdentity(JobName).Build();
    //          ITrigger trigger = AssignTriggerName(triggerBuilder).Build();
    //          Scheduler.ScheduleJob(job, trigger);
    //      }

    //      private TriggerBuilder AssignTriggerName(TriggerBuilder triggerBuilder)
    //      {
    //          return triggerBuilder.WithIdentity(TriggerName);
    //      }

    //      //public abstract void Start();

    //      public void Pause()
    //      {
    //          Scheduler.PauseJob(new JobKey(JobName));
    //      }

    //      public void Resume()
    //      {
    //          Scheduler.ResumeJob(new JobKey(JobName));
    //      }

    //      /*
    //       * https://stackoverflow.com/questions/16334411/quartz-net-rescheduling-job-with-new-trigger-set
    //       */
    //      protected void Reschedule(TriggerBuilder triggerBuilder)
    //      {
    //          TriggerKey key = new TriggerKey(TriggerName);
    //          ITrigger trigger = AssignTriggerName(triggerBuilder).Build();
    //          Scheduler.RescheduleJob(key, trigger);
    //      }

    ///*
    //*https://www.quartz-scheduler.net/documentation/quartz-2.x/tutorial/trigger-and-job-listeners.html
    //*/
    //      protected void AttachJobListener()
    //      {
    //          ScheduleJobListener myJobListener = new ScheduleJobListener(ListenerName);
    //          myJobListener.Started += TaskStarted;
    //          myJobListener.Vetoed += TaskVetoed;
    //          myJobListener.Executed += TaskExecuted;
    //          Scheduler.ListenerManager.AddJobListener(myJobListener, KeyMatcher<JobKey>.KeyEquals(new JobKey(JobName)));
    //      }

    //      public DateTime? NextFireTime()
    //      {
    //          TriggerKey key = new TriggerKey(TriggerName);
    //          DateTimeOffset? timeUtc = Scheduler.GetTrigger(key).GetNextFireTimeUtc();
    //          DateTime? dateTime = timeUtc == null 
    //                                  ? (DateTime?) null 
    //                                  : timeUtc.Value.ToLocalTime().DateTime;

    //          return dateTime;
    //      }
    //  }         

    /// <summary>
    /// Schedule adapter using Quartz
    /// </summary>
    public abstract class Schedule : ISchedule
    {
        public event TaskExecution TaskStarted;
        public event TaskExecution TaskVetoed;
        public event TaskExecutionComplete TaskExecuted;
        public event ShouldTaskExecution TaskShouldBeVetoed;


        private readonly IScheduler Scheduler;

        public readonly string ScheduleName;
        public string Name
        {
            get
            {
                return ScheduleName;
            }
        }
        private string TriggerName
        {
            get
            {
                return ScheduleName + "Trigger";
            }
        }
        private string JobName
        {
            get
            {
                return ScheduleName + "Job";
            }
        }
        private string JobListenerName
        {
            get
            {
                return ScheduleName + "JobListener";
            }
        }

        private string TriggerListenerName
        {
            get
            {
                return ScheduleName + "TriggerListener";
            }
        }


        private bool _isStarted;

        protected Schedule(IScheduler scheduler, string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Schedule Name required");
            }
            if (scheduler == null)
            {
                throw new NullReferenceException("Scheduler required");
            }

            ScheduleName = name;
            Scheduler = scheduler;
        }

        /// <summary>
        /// this is not cluster aware
        /// </summary>
        /// <returns></returns>
        /*https://stackoverflow.com/questions/24568282/check-whether-the-job-is-running-or-not*/
        public bool IsTaskRunning()
        {
            bool value = Scheduler.GetCurrentlyExecutingJobs().Any(x =>
                x.JobDetail.Key.Name.Equals(JobName, StringComparison.OrdinalIgnoreCase));
            return value;
        }

        /*https://stackoverflow.com/questions/21527841/schedule-multiple-jobs-in-quartz-net*/

        protected void ScheduleTask(JobBuilder jobBuilder, TriggerBuilder triggerBuilder)
        {
            IJobDetail job = jobBuilder.WithIdentity(JobName).Build();
            ITrigger trigger = AssignTriggerName(triggerBuilder).Build();
            Scheduler.ScheduleJob(job, trigger);
        }

        private TriggerBuilder AssignTriggerName(TriggerBuilder triggerBuilder)
        {
            return triggerBuilder.WithIdentity(TriggerName);
        }

        protected abstract Tuple<JobBuilder, TriggerBuilder> Settings();

        public bool IsStarted()
        {
            bool value = _isStarted;
            return value;
        }

        public void Start()
        {
            Tuple<JobBuilder, TriggerBuilder> setting = Settings();
            ScheduleTask(setting.Item1, setting.Item2);
            AttachJobListener();
            _isStarted = true;
        }

        public bool IsPaused()
        {
            TriggerKey key = new TriggerKey(TriggerName);
            bool value = Scheduler.GetTriggerState(key) == TriggerState.Paused;
            return value;
        }

        public void Pause()
        {
            Scheduler.PauseJob(new JobKey(JobName));
        }

        public void Interrupt()
        {
            Scheduler.Interrupt(new JobKey(JobName));
        }

        public void Resume()
        {
            Scheduler.ResumeJob(new JobKey(JobName));
        }

        /*
        * https://stackoverflow.com/questions/16334411/quartz-net-rescheduling-job-with-new-trigger-set
        */
        protected void Reschedule(TriggerBuilder triggerBuilder)
        {
            TriggerKey key = new TriggerKey(TriggerName);
            ITrigger trigger = AssignTriggerName(triggerBuilder).Build();
            Scheduler.RescheduleJob(key, trigger);
        }

        /*
		*https://www.quartz-scheduler.net/documentation/quartz-2.x/tutorial/trigger-and-job-listeners.html
		*/
        protected void AttachJobListener()
        {
            ScheduleJobListener jobListener = new ScheduleJobListener(JobListenerName);
            jobListener.Started += TaskStarted;
            jobListener.Vetoed += TaskVetoed;
            jobListener.Executed += TaskExecuted;
            Scheduler.ListenerManager.AddJobListener(jobListener, KeyMatcher<JobKey>.KeyEquals(new JobKey(JobName)));

            ScheduleTriggerListener triggerListener = new ScheduleTriggerListener(TriggerListenerName);
            triggerListener.ShouldVeto += TaskShouldBeVetoed;
            Scheduler.ListenerManager.AddTriggerListener(triggerListener, KeyMatcher<TriggerKey>.KeyEquals(new TriggerKey(TriggerName)));
        }

        public DateTime? NextEstimatedFireTime()
        {
            TriggerKey key = new TriggerKey(TriggerName);
            DateTimeOffset? timeUtc = Scheduler.GetTrigger(key).GetNextFireTimeUtc();
            DateTime? dateTime = timeUtc == null
                                    ? (DateTime?)null
                                    : timeUtc.Value.ToLocalTime().DateTime;

            return dateTime;
        }
    }
}
