﻿using System;
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
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
