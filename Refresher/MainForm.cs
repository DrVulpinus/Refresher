using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refresher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        WindowSwitcher ws;
        Process targetProcess;
        private void MainForm_Load(object sender, EventArgs e)
        {
            ws = new WindowSwitcher(this);
            tmr_Refresh.Stop();
        }
        private void btn_SetTargetWindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After acknowledging this message, please switch to the window you want the events to be sent to.  You will have 5 seconds to select the correct window.  When the window has been selected you will be notified");
            System.Threading.Thread.Sleep(5000);
            targetProcess = ws.getCurrentProcess();
            this.Activate();
            MessageBox.Show("The title bar name of the selected target is: '" + targetProcess.MainWindowTitle + "'.");        
        }

        private void btn_GoToTarget_Click(object sender, EventArgs e)
        {
            ws.switchToTarget(targetProcess);
            System.Threading.Thread.Sleep(500);
            ws.returnToOrigin();
        }

        private void btn_StartRefreshing_Click(object sender, EventArgs e)
        {
            tmr_Refresh.Start();

        }

        private void btn_StopRefreshing_Click(object sender, EventArgs e)
        {
            tmr_Refresh.Stop();
        }

        private void tmr_Refresh_Tick(object sender, EventArgs e)
        {
            ws.switchToTarget(targetProcess);
            System.Threading.Thread.Sleep(500);
            ws.returnToOrigin();
        }
    }
}
