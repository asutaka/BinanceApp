using BinanceApp.Common;
using BinanceApp.GUI.Child;
using Quartz;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class Top30CurrentValueScheduleJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            foreach (var item in StaticValues.lstCryptonRank)
            {
                item.CurrentValue = CommonMethod.GetCurrentValue(item.Coin);
            }
            frmTop30.Instance().InitData();
        }
    }
}
