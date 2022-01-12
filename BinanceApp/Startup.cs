using BinanceApp.Common;
using BinanceApp.Data;
using BinanceApp.Job;
using BinanceApp.Job.ScheduleJob;
using BinanceApp.Model.ENTITY;
using Quartz;
using System.Collections.Generic;

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
            //Load JSonFile
            StaticValues.basicModel = new BasicSettingModel().LoadJsonFile("basic_setting.json");
            var obj = new AdvanceSettingModel();
            StaticValues.advanceModel1 = obj.LoadJsonFile("advance_setting1.json");
            StaticValues.advanceModel2 = obj.LoadJsonFile("advance_setting2.json");
            StaticValues.advanceModel3 = obj.LoadJsonFile("advance_setting3.json");
            StaticValues.advanceModel4 = obj.LoadJsonFile("advance_setting4.json");
            StaticValues.specialModel = new SpecialSettingModel().LoadJsonFile("special_setting.json");
            StaticValues.lstBlackList = new List<CryptonDetailDataModel>().LoadJsonFile("blacklist.json");
            StaticValues.tradeList = new TradeListModel().LoadJsonFile("tradelist.json");
            StaticValues.followList = new FollowModel().LoadJsonFile("followlist.json");
            
            //Load ListCoin
            StaticValues.lstCoin = SeedData.GetCryptonList();
            StaticValues.lstCoinFilter = SeedData.GetCryptonListWithFilter();

            //Schedule
            StaticValues.ScheduleMngObj.AddSchedule(new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<CheckStatusJob>(), StaticValues.Scron_CheckStatus, nameof(CheckStatusJob)));
            //StaticValues.ScheduleMngObj.AddSchedule(new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<Top30CurrentValueScheduleJob>(), StaticValues.Scron_Top30CurrentValue, nameof(Top30CurrentValueScheduleJob)));
            //foreach (var Schedule in StaticValues.ScheduleMngObj.GetSchedules())
            //{
            //    if (!Schedule.IsStarted())
            //    {
            //        Schedule.Start();
            //    }
            //    else
            //    {
            //        Schedule.Resume();
            //    }
            //}
            //StaticValues.ScheduleMngObj.AddSchedule(new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<HrScheduleJob>(), "0/5 0-59 0-23 * * ?", nameof(HrScheduleJob)));
        }
    }
}
