namespace WindowsFormsApp1
{
    partial class aimtrainForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_label = new System.Windows.Forms.Label();
            this.shootcount_txt = new System.Windows.Forms.Label();
            this.accuracy_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(1056, 28);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(117, 30);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score : 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.aimgame_background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(78, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.Location = new System.Drawing.Point(74, 28);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(131, 30);
            this.timer_label.TabIndex = 2;
            this.timer_label.Text = "timer : 30";
            // 
            // shootcount_txt
            // 
            this.shootcount_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shootcount_txt.AutoSize = true;
            this.shootcount_txt.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootcount_txt.Location = new System.Drawing.Point(360, 28);
            this.shootcount_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shootcount_txt.Name = "shootcount_txt";
            this.shootcount_txt.Size = new System.Drawing.Size(205, 30);
            this.shootcount_txt.TabIndex = 3;
            this.shootcount_txt.Text = "shootcount : 0";
            // 
            // accuracy_txt
            // 
            this.accuracy_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accuracy_txt.AutoSize = true;
            this.accuracy_txt.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracy_txt.Location = new System.Drawing.Point(717, 26);
            this.accuracy_txt.Name = "accuracy_txt";
            this.accuracy_txt.Size = new System.Drawing.Size(191, 30);
            this.accuracy_txt.TabIndex = 4;
            this.accuracy_txt.Text = "Accuracy : 0 %";
            // 
            // aimtrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 590);
            this.Controls.Add(this.accuracy_txt);
            this.Controls.Add(this.shootcount_txt);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "aimtrainForm";
            this.Text = "aimtrainForm";
            this.Load += new System.EventHandler(this.aimtrainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Label shootcount_txt;
        private System.Windows.Forms.Label accuracy_txt;
    }
}