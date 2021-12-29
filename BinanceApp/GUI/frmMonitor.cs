using BinanceApp.Common;
using BinanceApp.Job;
using BinanceApp.UserControl;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BinanceApp.GUI
{
    public partial class frmMonitor : XtraForm
    {
        private readonly BackgroundWorker Bw;
        public frmMonitor()
        {
            InitializeComponent();
            Bw = new BackgroundWorker();
            Bw.WorkerSupportsCancellation = true;
            Bw.DoWork += BgWorkStartScheduler;
            Bw.RunWorkerCompleted += BgWorkerCompleted;
            Bw.RunWorkerAsync();
        }

        private static frmMonitor _instance = null;
        public static frmMonitor Instance()
        {
            _instance = _instance ?? new frmMonitor();
            return _instance;
        }

        private void BgWorkStartScheduler(object sender, DoWorkEventArgs e)
        {
            /*close backgraound worker*/
            if (Bw.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            int tabCount = 1;
            foreach (var item in StaticValues.ScheduleMngObj.GetSchedules())
            {
                var user = new userMonitorSchedule();
                new ScheduleUiContainer(this, user, item).Initialize();
                AddTab($"Tab{tabCount++}", user);
            }
        }

        private void BgWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                NLogLogger.PublishException(e.Error, e.Error.Message);
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show("Error to start scheduler!");
                });
            }
        }

        private void CloseApp()
        {
            /*stop shedule*/
            StaticValues.ScheduleMngObj.Stop();

            /*close backgraound worker
             *https://stackoverflow.com/questions/4732737/how-to-stop-backgroundworker-correctly
             */
            if (Bw.IsBusy)
            {
                Bw.CancelAsync();
            }
            while (Bw.IsBusy)
            {
                Application.DoEvents();
            }

            /*kill all running process
             * https://stackoverflow.com/questions/8507978/exiting-a-c-sharp-winforms-application
             */
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            Environment.Exit(0);
        }

        private void AddTab(string TabNameAdd, System.Windows.Forms.UserControl UserControl)
        {
            this.Invoke((MethodInvoker)delegate
            {
                var TAbAdd = new XtraTabPage();
                TAbAdd.Text = TabNameAdd;
                TAbAdd.Controls.Add(UserControl);
                UserControl.Dock = DockStyle.Fill;
                tabControl.TabPages.Add(TAbAdd);
            });
        }

        public void KillAllSchedule()
        {
            /*stop shedule*/
            StaticValues.ScheduleMngObj.Stop();

            /*close backgraound worker
             *https://stackoverflow.com/questions/4732737/how-to-stop-backgroundworker-correctly
             */
            if (Bw.IsBusy)
            {
                Bw.CancelAsync();
            }
            while (Bw.IsBusy)
            {
                Application.DoEvents();
            }
            this.Close();
        }

        private void btnKillAll_Click(object sender, EventArgs e)
        {
            KillAllSchedule();
        }
    }
}