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
            this.fireworksPictureBox1 = new System.Windows.Forms.PictureBox();
            this.fireworksPictureBox3 = new System.Windows.Forms.PictureBox();
            this.fireworksPictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fireworksPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireworksPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireworksPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("배달의민족 주아", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(18, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(350, 37);
            this.title.TabIndex = 0;
            this.title.Text = "당신의 운을 시험해보세요!";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("배달의민족 주아", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(125, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "뽑기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // probability
            // 
            this.probability.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.probability.AutoSize = true;
            this.probability.Font = new System.Drawing.Font("국립공원 꼬미", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.probability.ForeColor = System.Drawing.Color.White;
            this.probability.Location = new System.Drawing.Point(101, 322);
            this.probability.Name = "probability";
            this.probability.Size = new System.Drawing.Size(182, 34);
            this.probability.TabIndex = 2;
            this.probability.Text = "노말: 50% 레어: 30% 에픽: 15% \r\n유니크: 4% 레전더리: 1%";
            this.probability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // normal_txt
            // 
            this.normal_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.normal_txt.AutoSize = true;
            this.normal_txt.Font = new System.Drawing.Font("국립공원 꼬미", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.normal_txt.ForeColor = System.Drawing.Color.White;
            this.normal_txt.Location = new System.Drawing.Point(149, 140);
            this.normal_txt.Name = "normal_txt";
            this.normal_txt.Size = new System.Drawing.Size(63, 23);
            this.normal_txt.TabIndex = 3;
            this.normal_txt.Text = "노말 : 0";
            // 
            // rare_txt
            // 
            this.rare_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rare_txt.AutoSize = true;
            this.rare_txt.Font = new System.Drawing.Font("국립공원 꼬미", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rare_txt.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rare_txt.Location = new System.Drawing.Point(147, 161);
            this.rare_txt.Name = "rare_txt";
            this.rare_txt.Size = new System.Drawing.Size(67, 23);
            this.rare_txt.TabIndex = 4;
            this.rare_txt.Text = "레어 : 0";
            // 
            // epic_txt
            // 
            this.epic_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.epic_txt.AutoSize = true;
            this.epic_txt.Font = new System.Drawing.Font("국립공원 꼬미", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.epic_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.epic_txt.Location = new System.Drawing.Point(148, 180);
            this.epic_txt.Name = "epic_txt";
            this.epic_txt.Size = new System.Drawing.Size(67, 23);
            this.epic_txt.TabIndex = 5;
            this.epic_txt.Text = "에픽 : 0";
            // 
            // unique_txt
            // 
            this.unique_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unique_txt.AutoSize = true;
            this.unique_txt.Font = new System.Drawing.Font("국립공원 꼬미", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.unique_txt.ForeColor = System.Drawing.Color.Yellow;
            this.unique_txt.Location = new System.Drawing.Point(144, 198);
            this.unique_txt.Name = "unique_txt";
            this.unique_txt.Size = new System.Drawing.Size(73, 23);
            this.unique_txt.TabIndex = 6;
            this.unique_txt.Text = "유니크 : 0";
            // 
            // legend_txt
            // 
            this.legend_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.legend_txt.AutoSize = true;
            this.legend_txt.Font = new System.Drawing.Font("국립공원 꼬미", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.legend_txt.ForeColor = System.Drawing.Color.Lime;
            this.legend_txt.Location = new System.Drawing.Point(128, 217);
            this.legend_txt.Name = "legend_txt";
            this.legend_txt.Size = new System.Drawing.Size(95, 23);
            this.legend_txt.TabIndex = 7;
            this.legend_txt.Text = "레전더리 : 0";
            // 
            // fireworksPictureBox1
            // 
            this.fireworksPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fireworksPictureBox1.Location = new System.Drawing.Point(247, 99);
            this.fireworksPictureBox1.Name = "fireworksPictureBox1";
            this.fireworksPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.fireworksPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fireworksPictureBox1.TabIndex = 8;
            this.fireworksPictureBox1.TabStop = false;
            this.fireworksPictureBox1.Visible = false;
            // 
            // fireworksPictureBox3
            // 
            this.fireworksPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fireworksPictureBox3.Location = new System.Drawing.Point(247, 190);
            this.fireworksPictureBox3.Name = "fireworksPictureBox3";
            this.fireworksPictureBox3.Size = new System.Drawing.Size(50, 50);
            this.fireworksPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fireworksPictureBox3.TabIndex = 9;
            this.fireworksPictureBox3.TabStop = false;
            this.fireworksPictureBox3.Visible = false;
            // 
            // fireworksPictureBox2
            // 
            this.fireworksPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fireworksPictureBox2.Location = new System.Drawing.Point(69, 140);
            this.fireworksPictureBox2.Name = "fireworksPictureBox2";
            this.fireworksPictureBox2.Size = new System.Drawing.Size(50, 50);
            this.fireworksPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fireworksPictureBox2.TabIndex = 10;
            this.fireworksPictureBox2.TabStop = false;
            this.fireworksPictureBox2.Visible = false;
            // 
            // rucktestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.fireworksPictureBox2);
            this.Controls.Add(this.fireworksPictureBox3);
            this.Controls.Add(this.fireworksPictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.fireworksPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireworksPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireworksPictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox fireworksPictureBox1;
        private System.Windows.Forms.PictureBox fireworksPictureBox3;
        private System.Windows.Forms.PictureBox fireworksPictureBox2;
    }
}