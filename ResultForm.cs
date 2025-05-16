using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapTrack
{
    public partial class ResultForm: Form
    {
        public ResultForm(string trackApp, DateTime startTime, DateTime endTime, List<string> logs)
        {
            InitializeComponent();

            lblSelectApp.Text = trackApp;
            lblTime.Text = $"{startTime} \n ~ {endTime}";

            TimeSpan duration = endTime - startTime;
            lblTotalTime.Text = $"{duration.TotalMinutes:F1} 분";

            // 사용 횟수
            int keyCount = 0;
            int mouseCount = 0;
            int shortCount = 0;

            foreach (string log in logs)
            {
                if(log.Contains("키보드"))
                {
                    keyCount++;

                    // 단축키
                    if(log.Contains("Ctrl") || log.Contains("Shift") || log.Contains("Alt"))
                    {
                        shortCount++;
                    }
                }
                else if (log.Contains("마우스"))
                {
                    mouseCount++;
                }
            }

            lblmouseCount.Text = $"마우스 클릭 횟수 : {mouseCount}회";
            lblKeyCount.Text = $"키보드 입력 획수 : {keyCount}회";
            lblShortCount.Text = $"단축키 사용 획수 : {shortCount}회";
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            var main = new MainPage();
            main.Show();

            this.Close();
        }
    }
}
