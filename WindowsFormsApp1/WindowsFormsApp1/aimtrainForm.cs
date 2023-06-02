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
        private int shootcount;
        private double accuracy;
        private PictureBox crosshair;
        private PictureBox target;

        private int counttime = 30;
        private Timer play_timer;     //타이머 추가
        private int elapsedTime; //경과시간
        private bool startcheck = false;

        public aimtrainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            random = new Random();
            score = 0;
            shootcount = 0;
            crosshair = new PictureBox();
            crosshair.SizeMode = PictureBoxSizeMode.Zoom;
            crosshair.Size = new Size(20, 20);
            crosshair.Visible = true;
            pictureBox1.Controls.Add(crosshair); // pictureBox에 crosshair를 추가
            crosshair.Image = Properties.Resources.aim_image; 

            target = new PictureBox();
            target.BackColor = Color.Blue;
            target.Size = new Size(50, 50);
            target.Visible = true;
            pictureBox1.Controls.Add(target); // pictureBox에 target을 추가
            target.Click += target_Click; // target의 클릭 이벤트 핸들러 추가
            pictureBox1.MouseMove += pictureBox_MouseMove; // pictureBox1의 마우스 이동 이벤트 핸들러 추가
            target.MouseMove += target_MouseMove;
            crosshair.Click += crosshair_Click;

            // 타이머 초기화
            play_timer = new Timer();
            play_timer.Interval = 1000; // 1초마다 타이머 이벤트 발생
            play_timer.Tick += Timer_Tick;
            elapsedTime = 0;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime++; // 경과 시간 증가
            timer_label.Text = "timer : " + (counttime - elapsedTime).ToString(); // 경과 시간 표시

            if (counttime - elapsedTime <= 0)
            {
                play_timer.Stop(); // 타이머 멈춤
                pictureBox1.Controls.Remove(target); // target PictureBox 제거
                MessageBox.Show("time over");
            }
        }
        private void aimtrainForm_Load(object sender, EventArgs e)
        {
            // 게임 초기화
            ResetGame();
        }

        private void ResetGame()
        {
            score = 0;
            scoreLabel.Text = "Score : 0";
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
            if (counttime - elapsedTime > 0)
            {
                // 타겟 클릭 이벤트 핸들러
                score++;
                shootcount++;
                scoreLabel.Text = "Score : " + score.ToString();
                shootcount_txt.Text = "Shootcount : " + shootcount.ToString();
                accuracy = (double)score / shootcount * 100;
                accuracy_txt.Text = "Accuracy : " + accuracy.ToString("0.00") + " %";
                if (startcheck == false)
                {
                    startcheck = true;
                    play_timer.Start();
                }

                // target의 위치를 랜덤하게 이동
                int x = random.Next(pictureBox1.Width - target.Width);
                int y = random.Next(pictureBox1.Height - target.Height);
                target.Location = new Point(x, y);
            }
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스 이동 이벤트 핸들러
            int x = e.X - crosshair.Width / 2;
            int y = e.Y - crosshair.Height / 2;
            crosshair.Location = new Point(x, y);
        }

        private void target_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X - crosshair.Width / 2;
            int y = e.Y - crosshair.Height / 2;
            crosshair.Location = new Point(target.Left + x, target.Top + y);
        }

        private void crosshair_Click(object sender, EventArgs e)
        {
            if (counttime - elapsedTime > 0)
            {
                if (crosshair.Bounds.IntersectsWith(target.Bounds))
                {
                    // 겹쳐져 있다면 target을 클릭한 것으로 처리
                    target_Click(target, EventArgs.Empty);
                }
                else if (startcheck == true)
                {
                    shootcount++;
                    shootcount_txt.Text = "Shootcount : " + shootcount.ToString();
                    accuracy = (double)score / shootcount * 100;
                    accuracy_txt.Text = "Accuracy : " + accuracy.ToString("0.00") + " %";
                }
            }
        }
    }
}