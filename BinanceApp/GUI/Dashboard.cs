using BinanceApp.Common;
using BinanceApp.Job;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BinanceApp.GUI
{
    public partial class Dashboard : Form
    {
        private readonly BackgroundWorker Bw;
        private TestScheduler _scheduleContext;

        public Dashboard()
        {
            InitializeComponent();

            Bw = new BackgroundWorker();
            Bw.WorkerSupportsCancellation = true;
            Bw.DoWork += BgWorkStartScheduler;
            Bw.RunWorkerCompleted += BgWorkerCompleted;
            Bw.RunWorkerAsync();
        }

        private void BgWorkStartScheduler(object sender, DoWorkEventArgs e)
        {
            /*close backgraound worker*/
            if (Bw.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            /*schedule*/
            _scheduleContext = TestScheduler.Instance();
            new ScheduleUiContainer(this, richTextEmailSched, checkBoxEmailSched, _scheduleContext.EmailSchedule).Initialize();
            new ScheduleUiContainer(this, richTextHrSched, checkBoxHrSched, _scheduleContext.HrSchedule).Initialize();
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
            _scheduleContext.Stop();

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

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_scheduleContext.AnyTaskRunning())
            {
                var window = MessageBox.Show(
                    "A task is in progress, do you still want to close?",
                    "Close Window",
                    MessageBoxButtons.YesNo);
                if (window == DialogResult.Yes)
                {
                    CloseApp();
                }
                e.Cancel = (window == DialogResult.No);
            }
            else
            {
                CloseApp();
            }
        }
    }
}
