using BinanceApp.GUI;
using BinanceApp.Job.ScheduleJob;
using BinanceApp.Model.ENTITY;
using System.Collections.Generic;

namespace BinanceApp
{
    public class StaticValues
    {
        public static ProfileModel profile;
        public static bool IsCodeActive = false;
        public static bool IsAccessMain = false;
        public static bool IsExecMCDX = false;
        public static bool IsExecTop30 = false;
        public static bool IsExecCheckCodeActive = false;
        public static bool IsTradeListChange = false;
        //
        public static bool IsRealTimeDeleted = false;
        public static int Level { get; set; }
        public static ScheduleMng ScheduleMngObj = ScheduleMng.Instance();
        public static frmMonitor frmMonitorObj = null;
        public static frmMain frmMainObj = null;
        //Scron <second> <minute> <hour> <day-of-month> <month> <day-of-week> <year>
        public static string Scron_CheckStatus = "0 0 0/5 * * ?";
        public static string Scron_RealTimeValue = "0/1 * * * * ?";
        public static string Scron_Top30_Calculate = "0 0 0/6 * * ?";
        public static string Scron_Top30_Value = "0/1 * * * * ?";
        public static string Scron_MCDX_Calculate = "0 0/5 * * * ?";
        public static string Scron_MCDX_Value = "0/1 * * * * ?";
        public static string Scron_SendNoti = "0/1 * * * * ?";
        public static string Scron_TradeList_Noti = "0/1 * * * * ?";
        //Notify
        public static Queue<string> lNotify = new Queue<string>();
        //Coin
        public static List<CryptonDetailDataModel> lstCoin = new List<CryptonDetailDataModel>();
        public static List<CryptonDetailDataModel> lstCoinFilter = new List<CryptonDetailDataModel>();
        public static List<Top30Model> lstCryptonRank = new List<Top30Model>();
        public static List<MCDXModel> lstMCDX = new List<MCDXModel>();
        public static Dictionary<string, List<CandleStickDataModel>> dicDatasource15M = new Dictionary<string, List<CandleStickDataModel>>();
        public static Dictionary<string, List<CandleStickDataModel>> dicDatasource1H = new Dictionary<string, List<CandleStickDataModel>>();
        public static Dictionary<string, List<CandleStickDataModel>> dicDatasource4H = new Dictionary<string, List<CandleStickDataModel>>();
        public static Dictionary<string, List<CandleStickDataModel>> dicDatasource1D = new Dictionary<string, List<CandleStickDataModel>>();
        public static Dictionary<string, List<CandleStickDataModel>> dicDatasource1W = new Dictionary<string, List<CandleStickDataModel>>();
        public static Dictionary<string, List<CandleStickDataModel>> dicDatasource1Month = new Dictionary<string, List<CandleStickDataModel>>();
        //Setting Model
        public static BasicSettingModel basicModel;
        public static SpecialSettingModel specialModel;
        public static AdvanceSettingModel advanceModel1;
        public static AdvanceSettingModel advanceModel2;
        public static AdvanceSettingModel advanceModel3;
        public static AdvanceSettingModel advanceModel4;
        public static List<CryptonDetailDataModel> lstBlackList;
        public static List<CryptonDetailDataModel> lstRealTime;
        public static List<Top30Model> lstRealTimeShow = new List<Top30Model>();
        public static TradeListModel tradeList;
        public static FollowModel followList;
        //Local 
        public static List<SendNotifyModel> lstNotiTrade = new List<SendNotifyModel>();
    }
}
