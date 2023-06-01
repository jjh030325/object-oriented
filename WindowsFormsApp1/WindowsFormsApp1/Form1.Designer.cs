namespace WindowsFormsApp1
{
    partial class Form1
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
            this.fivestone_start_btn = new System.Windows.Forms.Button();
            this.aimtraining_btn = new System.Windows.Forms.Button();
            this.rucktest_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fivestone_start_btn
            // 
            this.fivestone_start_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fivestone_start_btn.Location = new System.Drawing.Point(135, 130);
            this.fivestone_start_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fivestone_start_btn.Name = "fivestone_start_btn";
            this.fivestone_start_btn.Size = new System.Drawing.Size(94, 28);
            this.fivestone_start_btn.TabIndex = 0;
            this.fivestone_start_btn.Text = "오목";
            this.fivestone_start_btn.UseVisualStyleBackColor = true;
            this.fivestone_start_btn.Click += new System.EventHandler(this.fivestone_start_btn_Click);
            // 
            // aimtraining_btn
            // 
            this.aimtraining_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aimtraining_btn.Location = new System.Drawing.Point(135, 187);
            this.aimtraining_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aimtraining_btn.Name = "aimtraining_btn";
            this.aimtraining_btn.Size = new System.Drawing.Size(94, 28);
            this.aimtraining_btn.TabIndex = 1;
            this.aimtraining_btn.Text = "에임연습";
            this.aimtraining_btn.UseVisualStyleBackColor = true;
            this.aimtraining_btn.Click += new System.EventHandler(this.aimtraining_btn_Click);
            // 
            // rucktest_btn
            // 
            this.rucktest_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rucktest_btn.Location = new System.Drawing.Point(135, 242);
            this.rucktest_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rucktest_btn.Name = "rucktest_btn";
            this.rucktest_btn.Size = new System.Drawing.Size(94, 28);
            this.rucktest_btn.TabIndex = 2;
            this.rucktest_btn.Text = "운테스트";
            this.rucktest_btn.UseVisualStyleBackColor = true;
            this.rucktest_btn.Click += new System.EventHandler(this.rucktest_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("안동엄마까투리", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(69, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "아케이드 게임";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "==하고싶은 게임을 선택하세요!==";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rucktest_btn);
            this.Controls.Add(this.aimtraining_btn);
            this.Controls.Add(this.fivestone_start_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fivestone_start_btn;
        private System.Windows.Forms.Button aimtraining_btn;
        private System.Windows.Forms.Button rucktest_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

