namespace TapTrack
{
    partial class ResultForm
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
            this.lblSelectApp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKeyCount = new System.Windows.Forms.Label();
            this.lblmouseCount = new System.Windows.Forms.Label();
            this.lblShortCount = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectApp
            // 
            this.lblSelectApp.AutoSize = true;
            this.lblSelectApp.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSelectApp.Location = new System.Drawing.Point(179, 27);
            this.lblSelectApp.Name = "lblSelectApp";
            this.lblSelectApp.Size = new System.Drawing.Size(44, 37);
            this.lblSelectApp.TabIndex = 4;
            this.lblSelectApp.Text = "앱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "추적한 앱 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "추적 시간 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(25, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "총 추적 시간 :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTime.Location = new System.Drawing.Point(147, 99);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 25);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "시간";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalTime.Location = new System.Drawing.Point(175, 159);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(69, 25);
            this.lblTotalTime.TabIndex = 8;
            this.lblTotalTime.Text = "총시간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(25, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "이벤트 사용 횟수";
            // 
            // lblKeyCount
            // 
            this.lblKeyCount.AutoSize = true;
            this.lblKeyCount.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeyCount.Location = new System.Drawing.Point(35, 309);
            this.lblKeyCount.Name = "lblKeyCount";
            this.lblKeyCount.Size = new System.Drawing.Size(185, 25);
            this.lblKeyCount.TabIndex = 10;
            this.lblKeyCount.Text = "키보드 입력 횟수 : -";
            // 
            // lblmouseCount
            // 
            this.lblmouseCount.AutoSize = true;
            this.lblmouseCount.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblmouseCount.Location = new System.Drawing.Point(35, 264);
            this.lblmouseCount.Name = "lblmouseCount";
            this.lblmouseCount.Size = new System.Drawing.Size(185, 25);
            this.lblmouseCount.TabIndex = 11;
            this.lblmouseCount.Text = "마우스 입력 횟수 : -";
            // 
            // lblShortCount
            // 
            this.lblShortCount.AutoSize = true;
            this.lblShortCount.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblShortCount.Location = new System.Drawing.Point(35, 354);
            this.lblShortCount.Name = "lblShortCount";
            this.lblShortCount.Size = new System.Drawing.Size(185, 25);
            this.lblShortCount.TabIndex = 12;
            this.lblShortCount.Text = "단축키 입력 횟수 : -";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRestart.Location = new System.Drawing.Point(60, 487);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(163, 45);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "추적 다시하기";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEnd.Location = new System.Drawing.Point(252, 487);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(163, 45);
            this.btnEnd.TabIndex = 14;
            this.btnEnd.Text = "종료하기";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblShortCount);
            this.Controls.Add(this.lblmouseCount);
            this.Controls.Add(this.lblKeyCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSelectApp);
            this.Controls.Add(this.label1);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKeyCount;
        private System.Windows.Forms.Label lblmouseCount;
        private System.Windows.Forms.Label lblShortCount;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnEnd;
    }
}