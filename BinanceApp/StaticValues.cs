using BinanceApp.Job.ScheduleJob;
using BinanceApp.Model.ENTITY;

namespace BinanceApp
{
    public class StaticValues
    {
        public static ProfileModel profile = new ProfileModel();
        public static bool IsCodeActive = false;
        public static bool IsExecCheckCodeActive = false;
        public static ScheduleMng ScheduleMngObj = ScheduleMng.Instance();
    }
}
