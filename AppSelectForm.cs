using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates; // 앱 추적

namespace TapTrack
{
    public partial class MainPage: Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public class AppItem
        {
            public string DisplayText { get; set; }
            public Process Process { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
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
                    string displayText = $"{p.ProcessName} ({p.MainWindowTitle.Substring(0, Math.Min(30, p.MainWindowTitle.Length))})";
                    comboBoxApp.Items.Add(new AppItem
                    {
                        DisplayText = displayText,
                        Process = p
                    });
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
            //string selectApp = comboBoxApp.SelectedItem?.ToString();

            //if(!string.IsNullOrEmpty(selectApp))
            //{
            //    TrackingAppForm trackingApp = new TrackingAppForm(selectApp);
            //    trackingApp.Show();
            //    this.Hide(); // AppSelect 숨기기
            //}
            //else
            //{
            //    MessageBox.Show("앱을 선택해주세요.");
            //}

            if(comboBoxApp.SelectedItem is AppItem selectedItem)
            {
                TrackingAppForm trackingApp = new TrackingAppForm(selectedItem.Process);
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
