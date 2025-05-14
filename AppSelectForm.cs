using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // 앱 추적

namespace TapTrack
{
    public partial class MainPage: Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // 앱 불러오기
        public void RunningApp()
        {
            comboBoxApp.Items.Clear();

            Process[] processes = Process.GetProcesses();

            foreach(Process p in processes)
            {
                // 창에 있는 앱
                if(!string.IsNullOrWhiteSpace(p.MainWindowTitle))
                {
                    comboBoxApp.Items.Add(p.MainWindowTitle);
                }
            }

            if(comboBoxApp.Items.Count > 0)
            {
                comboBoxApp.SelectedIndex = 0;
            }

        }

        // TrackingApp form으로 추적중인 앱 전달
        private void btnStartTrack_Click(object sender, EventArgs e)
        {
            string selectApp = comboBoxApp.SelectedItem?.ToString();

            if(!string.IsNullOrEmpty(selectApp))
            {
                TrackingAppForm trackingApp = new TrackingAppForm(selectApp);
                trackingApp.Show();
                this.Hide(); // AppSelect 숨기기
            }
            else
            {
                MessageBox.Show("앱을 선택해주세요.");
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            RunningApp();
        }
    }
}
