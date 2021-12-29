using BinanceApp.GUI;
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
        public static frmMonitor frmMonitorObj = null;
        //Scron <second> <minute> <hour> <day-of-month> <month> <day-of-week> <year>
        public static string Scron_CheckStatus = "0 0 0/5 * * ?";
    }
}
