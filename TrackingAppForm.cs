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
        private IKeyboardMouseEvents globalHook;



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

        // 리스트뷰 셋팅
        private void setupListview()
        {
            listViewLog.View = View.Details;
            listViewLog.Columns.Clear();
            //listViewLog.Columns.Add("시간", 100);
            //listViewLog.Columns.Add("이벤트", 300);

            listViewLog.Columns.Add("Time", 100);
            listViewLog.Columns.Add("Type", 80);
            listViewLog.Columns.Add("Detail", 200);
        }

        private bool IsTargetAppFocused()
        {
            IntPtr fWn = GetForegroundWindow();
            GetWindowThreadProcessId(fWn, out uint pid);
            return pid == trackProcess.Id;
        }

        //private string getProcessName()
        //{
        //    IntPtr fwn = GetForegroundWindow();
        //    GetWindowThreadProcessId(fwn, out uint pid);

        //    try
        //    {
        //        Process proc = Process.GetProcessById((int)pid);
        //        return proc.ProcessName;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        // 후킹 시작
        private void StartGlobalHook()
        {
            globalHook = Hook.GlobalEvents();
            globalHook.KeyDown += OnKeyDown;
            globalHook.MouseDown += OnMouseDown;
        }

        // 후킹 해제
        private void StopGlobalHook()
        {
            if (globalHook != null)
            {
                globalHook.KeyDown -= OnKeyDown;
                globalHook.MouseDown -= OnMouseDown;
                globalHook.Dispose();
                globalHook = null;
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (IsTargetAppFocused())
            {
                AddLog("Keyboard", e.KeyCode.ToString());
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (IsTargetAppFocused())
            {
                AddLog("Mouse", e.Button.ToString());
            }
        }


        // 로그 추가 (ListView)
        private void AddLog(string type, string detail)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            ListViewItem item = new ListViewItem(new[] { time, type, detail });

            // UI 스레드 안전 처리
            Invoke((MethodInvoker)(() => listViewLog.Items.Add(item)));
        }



        private void TrackingApp_Load(object sender, EventArgs e)
        {
            setupListview();
            StartGlobalHook();
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void TrackingAppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopGlobalHook();
            Application.Exit(); // 종료
        }
    }
}
