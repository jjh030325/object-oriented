using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class aimtrainForm : Form
    {
        private Random random;
        private int score;
        private PictureBox crosshair;
        private PictureBox target;
        public aimtrainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            random = new Random();
            score = 0;
            crosshair = new PictureBox();
            crosshair.BackColor = Color.Red;
            crosshair.Size = new Size(20, 20);
            crosshair.Visible = true;
            pictureBox1.Controls.Add(crosshair); // pictureBox에 crosshair를 추가

            target = new PictureBox();
            target.BackColor = Color.Blue;
            target.Size = new Size(50, 50);
            target.Visible = true;
            pictureBox1.Controls.Add(target); // pictureBox에 target을 추가
            target.Click += target_Click; // target의 클릭 이벤트 핸들러 추가
            pictureBox1.MouseMove += pictureBox_MouseMove; // pictureBox1의 마우스 이동 이벤트 핸들러 추가
        }

        private void aimtrainForm_Load(object sender, EventArgs e)
        {
            // 게임 초기화
            ResetGame();
        }

        private void ResetGame()
        {
            score = 0;
            scoreLabel.Text = "Score: 0";
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 타이머 이벤트 핸들러
            int x = random.Next(pictureBox1.Width - target.Width);
            int y = random.Next(pictureBox1.Height - target.Height);
            target.Location = new Point(x, y);
        }
        private void target_Click(object sender, EventArgs e)
        {
            // 타겟 클릭 이벤트 핸들러
            score++;
            scoreLabel.Text = "Score: " + score.ToString();

            // target의 위치를 랜덤하게 이동
            int x = random.Next(pictureBox1.Width - target.Width);
            int y = random.Next(pictureBox1.Height - target.Height);
            target.Location = new Point(x, y);
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스 이동 이벤트 핸들러
            int x = e.X - crosshair.Width / 2;
            int y = e.Y - crosshair.Height / 2;
            crosshair.Location = new Point(x, y);
        }
    }
}