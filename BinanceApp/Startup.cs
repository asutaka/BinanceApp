using BinanceApp.Job;
using BinanceApp.Job.ScheduleJob;
using Quartz;

namespace BinanceApp
{
    public class Startup
    {
        private Startup()
        {
            Init();
        }
        private static Startup _instance = null;
        public static Startup Instance()
        {
            _instance = _instance ?? new Startup();
            return _instance;
        }
        private void Init()
        {
            StaticValues.ScheduleMngObj.AddSchedule(new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<EmailScheduleJob>(), "0/5 0-59 0-23 * * ?", nameof(EmailScheduleJob)));
            StaticValues.ScheduleMngObj.AddSchedule(new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<HrScheduleJob>(), "0/5 0-59 0-23 * * ?", nameof(HrScheduleJob)));
        }
    }
}
