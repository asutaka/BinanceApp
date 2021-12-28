using BinanceApp.Common;
using System.Collections.Specialized;

namespace BinanceApp.Job
{
    public class TestScheduler : ScheduleContext
    {
        private EmailSchedule _emailSchedule;

        public EmailSchedule EmailSchedule
        {
            get
            {
                _emailSchedule = _emailSchedule ?? new EmailSchedule(Scheduler);
                return _emailSchedule;
            }
        }

        private HrSchedule _hrSchedule;

        public HrSchedule HrSchedule
        {
            get
            {
                _hrSchedule = _hrSchedule ?? new HrSchedule(Scheduler);
                return _hrSchedule;
            }
        }

        private TestScheduler()
        {
            Props = new NameValueCollection
            {
                //{"quartz.scheduler.interruptJobsOnShutdownWithWait", "true"},
                {"quartz.scheduler.instanceName", nameof(TestScheduler)}
            };
            Start();
        }

        private static TestScheduler _instance = null;
        public static TestScheduler Instance()
        {
            _instance = _instance ?? new TestScheduler();
            return _instance;
        }

        public bool AnyTaskRunning()
        {
            var value = EmailSchedule.IsTaskRunning() && HrSchedule.IsTaskRunning();
            return value;
        }
    }
}
