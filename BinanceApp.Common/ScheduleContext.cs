using Quartz;
using Quartz.Impl;
using System.Collections.Specialized;

namespace BinanceApp.Common
{
    public abstract class ScheduleContext
    {
        protected NameValueCollection Props { get; set; }

        protected IScheduler Scheduler { get; private set; }

        protected void Start()
        {
            var factory = Props == null ? new StdSchedulerFactory() : new StdSchedulerFactory(Props);
            Scheduler = factory.GetScheduler();
            Scheduler.Start(); /*impt*/
        }

        //public abstract void Rebuild();

        //public void PauseAll()
        //{
        //    Scheduler.PauseAll();
        //}

        //public void ResumeAll()
        //{
        //    Scheduler.ResumeAll();
        //}


        /*http://www.quartz-scheduler.org/documentation/quartz-2.x/cookbook/ShutdownScheduler.html*/
        /// <summary>
        /// force stop
        /// </summary>
        public void Stop()
        {
            if (!Scheduler.IsShutdown)
            {
                Scheduler.Shutdown();
                Scheduler = null;
            }
        }

        /// <summary>
        /// scheduler will not allow this method to return until all currently executing jobs have completed.
        /// (hang up, if triggered middle of a job)
        /// </summary>
        public void WaitAndStop()
        {
            if (!Scheduler.IsShutdown)
            {
                Scheduler.Shutdown(true);
                Scheduler = null;
            }
        }
    }
}
