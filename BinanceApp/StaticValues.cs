using BinanceApp.GUI;
using BinanceApp.Job.ScheduleJob;
using BinanceApp.Model.ENTITY;
using System.Collections.Generic;

namespace BinanceApp
{
    public class StaticValues
    {
        public static ProfileModel profile = new ProfileModel();
        public static bool IsCodeActive = false;
        public static bool IsAccessMain = false;
        public static bool IsExecCheckCodeActive = false;
        public static ScheduleMng ScheduleMngObj = ScheduleMng.Instance();
        public static frmMonitor frmMonitorObj = null;
        public static frmMain frmMainObj = null;
        //Scron <second> <minute> <hour> <day-of-month> <month> <day-of-week> <year>
        public static string Scron_CheckStatus = "0 0 0/5 * * ?";
        //Coin
        public static List<CryptonDetailDataModel> lstCoin;
        public static List<CryptonRankModel> lstCryptonRank = new List<CryptonRankModel>();
        public static Dictionary<string, List<CandleStickDataModel>> dicDatasource = new Dictionary<string, List<CandleStickDataModel>>();
    }
}
