using BinanceApp.Model.ENTITY;
using Quartz;
using System.Collections.Generic;
using System.Linq;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class TradeListJob : IJob
    {
        private bool isPrepare;
        private List<(string, List<TradeDetailModel>, int, int)> lstTradeList = null; 
        public void Execute(IJobExecutionContext context)
        {
            if (!isPrepare)
            {
                Prepare();
                isPrepare = true;
            }
                
            foreach (var item in lstTradeList)
            {
                if(item.Item3 > item.Item4)
                {
                    item.Item4 = item.Item4 + 1;
                }
                else
                {
                    item.Item4 = 1;

                }
                //item.CurrentValue = CommonMethod.GetCurrentValue(item.Coin);
            }
            //frmTop30.Instance().InitData();
        }
        private void Prepare()
        {
            lstTradeList = StaticValues.lstTradeList.Where(x => x.IsNotify).Select(x => (x.Coin, x.Config, x.Interval / StaticValues.Scron_TradeList_Value, 1)).ToList();//interval phải có giá trị thật thay vì index như bjo
        }
    }
}
//public class TradeModel
//{
//    public string Coin { get; set; }
//    public List<TradeDetailModel> Config { get; set; }
//    public bool IsNotify { get; set; }// bật notify hay không
//    public int Interval { get; set; }// 1 lần duy nhất, mỗi ngày một lần, theo chu kỳ
//}

//public class TradeDetailModel
//{
//    public bool IsAbove { get; set; }
//    public decimal Value { get; set; }
//}