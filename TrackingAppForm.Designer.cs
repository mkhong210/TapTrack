namespace TapTrack
{
    partial class TrackingAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripNewStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectApp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logtimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNewStart,
            this.toolStripSeparator1,
            this.ToolStripExit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // ToolStripNewStart
            // 
            this.ToolStripNewStart.Name = "ToolStripNewStart";
            this.ToolStripNewStart.Size = new System.Drawing.Size(150, 22);
            this.ToolStripNewStart.Text = "새로 시작하기";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // ToolStripExit
            // 
            this.ToolStripExit.Name = "ToolStripExit";
            this.ToolStripExit.Size = new System.Drawing.Size(150, 22);
            this.ToolStripExit.Text = "종료하기";
            this.ToolStripExit.Click += new System.EventHandler(this.ToolStripExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "현재 추적중인 앱 :";
            // 
            // lblSelectApp
            // 
            this.lblSelectApp.AutoSize = true;
            this.lblSelectApp.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSelectApp.Location = new System.Drawing.Point(279, 50);
            this.lblSelectApp.Name = "lblSelectApp";
            this.lblSelectApp.Size = new System.Drawing.Size(44, 37);
            this.lblSelectApp.TabIndex = 2;
            this.lblSelectApp.Text = "앱";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(40, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 336);
            this.panel1.TabIndex = 3;
            // 
            // logtimer
            // 
            this.logtimer.Interval = 1000;
            // 
            // TrackingAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSelectApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrackingAppForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TrackingApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripNewStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer logtimer;
    }
}