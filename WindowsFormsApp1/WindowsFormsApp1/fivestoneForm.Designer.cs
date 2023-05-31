namespace WindowsFormsApp1
{
    partial class fivestoneForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer_label = new System.Windows.Forms.Label();
            this.turn_txt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.turn_txt);
            this.panel1.Controls.Add(this.timer_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 553);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Location = new System.Drawing.Point(124, 526);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(52, 15);
            this.timer_label.TabIndex = 0;
            this.timer_label.Text = "timer : ";
            // 
            // turn_txt
            // 
            this.turn_txt.AutoSize = true;
            this.turn_txt.Location = new System.Drawing.Point(241, 526);
            this.turn_txt.Name = "turn_txt";
            this.turn_txt.Size = new System.Drawing.Size(42, 15);
            this.turn_txt.TabIndex = 1;
            this.turn_txt.Text = "흑 턴";
            // 
            // fivestoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fivestoneForm";
            this.Text = "fivestoneForm";
            this.Load += new System.EventHandler(this.fivestoneForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label turn_txt;
        private System.Windows.Forms.Label timer_label;
    }
}