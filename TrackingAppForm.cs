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
    public partial class TrackingAppForm: Form
    {
        private string appToTrack;
        public TrackingAppForm(string selectedApp)
        {
            InitializeComponent();

            // 추적중인 앱 가져오기 
            appToTrack = selectedApp;
            lblSelectApp.Text = appToTrack;
        }



        private void TrackingApp_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {

        }
    }
}
