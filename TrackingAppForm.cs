using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace TapTrack
{
    public partial class TrackingAppForm: Form
    {
        private Process trackProcess;

        // 포커스된 윈도우 핸들을 가져오는 WinAPI 함수
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        // 프로세스 ID를 가져오는 WinAPI 함수
        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);


        private string appToTrack;
        public TrackingAppForm(Process processToTrack)
        {
            InitializeComponent();

            // 추적중인 앱 가져오기 
            //appToTrack = selectedApp;
            //lblSelectApp.Text = appToTrack;
            //this.trackProcess = trackProcess;

            trackProcess = processToTrack;

            //lblSelectApp.Text = $"{trackProcess.ProcessName} (PID: {trackProcess.Id})";
            lblSelectApp.Text = $"{trackProcess.ProcessName}";

        }

        private string getProcessName()
        {
            IntPtr fwn = GetForegroundWindow();
            GetWindowThreadProcessId(fwn, out uint pid);

            try
            {
                Process proc = Process.GetProcessById((int)pid);
                return proc.ProcessName;
            }
            catch
            {
                return null;
            }
        }



        private void TrackingApp_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {

        }
    }
}
