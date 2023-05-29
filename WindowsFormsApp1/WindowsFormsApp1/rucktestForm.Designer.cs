namespace WindowsFormsApp1
{
    partial class rucktestForm
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
            this.title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.probability = new System.Windows.Forms.Label();
            this.normal_txt = new System.Windows.Forms.Label();
            this.rare_txt = new System.Windows.Forms.Label();
            this.epic_txt = new System.Windows.Forms.Label();
            this.unique_txt = new System.Windows.Forms.Label();
            this.legend_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("배달의민족 주아", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(3, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(350, 37);
            this.title.TabIndex = 0;
            this.title.Text = "당신의 운을 시험해보세요!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(146, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "뽑기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // probability
            // 
            this.probability.AutoSize = true;
            this.probability.Font = new System.Drawing.Font("국립공원 꼬미", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.probability.Location = new System.Drawing.Point(29, 344);
            this.probability.Name = "probability";
            this.probability.Size = new System.Drawing.Size(304, 17);
            this.probability.TabIndex = 2;
            this.probability.Text = "노말:50%, 레어:30%, 에픽:15%, 유니크:4%, 레전더리:1%";
            // 
            // normal_txt
            // 
            this.normal_txt.AutoSize = true;
            this.normal_txt.Font = new System.Drawing.Font("국립공원 꼬미", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.normal_txt.Location = new System.Drawing.Point(32, 83);
            this.normal_txt.Name = "normal_txt";
            this.normal_txt.Size = new System.Drawing.Size(48, 17);
            this.normal_txt.TabIndex = 3;
            this.normal_txt.Text = "노말 : 0";
            // 
            // rare_txt
            // 
            this.rare_txt.AutoSize = true;
            this.rare_txt.Font = new System.Drawing.Font("국립공원 꼬미", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rare_txt.Location = new System.Drawing.Point(32, 100);
            this.rare_txt.Name = "rare_txt";
            this.rare_txt.Size = new System.Drawing.Size(51, 17);
            this.rare_txt.TabIndex = 4;
            this.rare_txt.Text = "레어 : 0";
            // 
            // epic_txt
            // 
            this.epic_txt.AutoSize = true;
            this.epic_txt.Font = new System.Drawing.Font("국립공원 꼬미", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.epic_txt.Location = new System.Drawing.Point(32, 117);
            this.epic_txt.Name = "epic_txt";
            this.epic_txt.Size = new System.Drawing.Size(51, 17);
            this.epic_txt.TabIndex = 5;
            this.epic_txt.Text = "에픽 : 0";
            // 
            // unique_txt
            // 
            this.unique_txt.AutoSize = true;
            this.unique_txt.Font = new System.Drawing.Font("국립공원 꼬미", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.unique_txt.Location = new System.Drawing.Point(32, 134);
            this.unique_txt.Name = "unique_txt";
            this.unique_txt.Size = new System.Drawing.Size(56, 17);
            this.unique_txt.TabIndex = 6;
            this.unique_txt.Text = "유니크 : 0";
            // 
            // legend_txt
            // 
            this.legend_txt.AutoSize = true;
            this.legend_txt.Font = new System.Drawing.Font("국립공원 꼬미", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.legend_txt.Location = new System.Drawing.Point(32, 151);
            this.legend_txt.Name = "legend_txt";
            this.legend_txt.Size = new System.Drawing.Size(73, 17);
            this.legend_txt.TabIndex = 7;
            this.legend_txt.Text = "레전더리 : 0";
            // 
            // rucktestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.legend_txt);
            this.Controls.Add(this.unique_txt);
            this.Controls.Add(this.epic_txt);
            this.Controls.Add(this.rare_txt);
            this.Controls.Add(this.normal_txt);
            this.Controls.Add(this.probability);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.title);
            this.Name = "rucktestForm";
            this.Text = "rucktestForm";
            this.Load += new System.EventHandler(this.rucktestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label probability;
        private System.Windows.Forms.Label normal_txt;
        private System.Windows.Forms.Label rare_txt;
        private System.Windows.Forms.Label epic_txt;
        private System.Windows.Forms.Label unique_txt;
        private System.Windows.Forms.Label legend_txt;
    }
}