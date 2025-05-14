namespace TapTrack
{
    partial class MainPage
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxApp = new System.Windows.Forms.ComboBox();
            this.btnStartTrack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "추적할 앱을 선택해 주세요.";
            // 
            // comboBoxApp
            // 
            this.comboBoxApp.FormattingEnabled = true;
            this.comboBoxApp.Location = new System.Drawing.Point(154, 154);
            this.comboBoxApp.Name = "comboBoxApp";
            this.comboBoxApp.Size = new System.Drawing.Size(268, 20);
            this.comboBoxApp.TabIndex = 1;
            // 
            // btnStartTrack
            // 
            this.btnStartTrack.Location = new System.Drawing.Point(154, 236);
            this.btnStartTrack.Name = "btnStartTrack";
            this.btnStartTrack.Size = new System.Drawing.Size(121, 23);
            this.btnStartTrack.TabIndex = 2;
            this.btnStartTrack.Text = "추적 시작하기";
            this.btnStartTrack.UseVisualStyleBackColor = true;
            this.btnStartTrack.Click += new System.EventHandler(this.btnStartTrack_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnStartTrack);
            this.Controls.Add(this.comboBoxApp);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "TapTrack";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxApp;
        private System.Windows.Forms.Button btnStartTrack;
    }
}

