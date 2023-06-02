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
    public partial class rucktestForm : Form
    {
        private Random random;
        private int normal = 0;
        private int rare = 0;
        private int epic = 0;
        private int unique = 0;
        private int legend = 0;
        // Timer 컨트롤을 폼에 추가하고 설정합니다.
        private Timer fireworksTimer;

        public rucktestForm()
        {
            InitializeComponent();
            random = new Random();

            fireworksTimer = new Timer();
            fireworksTimer.Interval = 3000;
            fireworksTimer.Enabled = false;
            fireworksTimer.Tick += FireworksTimer_Tick;
        }

        private void FireworksTimer_Tick(object sender, EventArgs e)
        {
            // Timer 이벤트 핸들러에서 폭죽 이미지를 숨깁니다.
            fireworksPictureBox1.Visible = false;
            fireworksPictureBox2.Visible = false;
            fireworksPictureBox3.Visible = false;
            fireworksTimer.Stop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int randomNumber = random.Next(1, 10001);

            if (randomNumber <= 5000)
            {
                MessageBox.Show("normal");
                normal++;
            }
            else if (randomNumber <= 8000)
            {
                MessageBox.Show("rare!");
                rare++;
            }
            else if (randomNumber <= 9500)
            {
                MessageBox.Show("epic!!");
                epic++;
            }
            else if (randomNumber <= 9900)
            {
                MessageBox.Show("!!!unique!!!");
                unique++;
                // 유니크일 때 폭죽 움짤 표시
                fireworksPictureBox1.Image = Image.FromFile(@"..\..\fireworks.gif");
                fireworksPictureBox1.Visible = true;
                fireworksPictureBox2.Image = Image.FromFile(@"..\..\fireworks.gif");
                fireworksPictureBox2.Visible = true;
                fireworksPictureBox3.Image = Image.FromFile(@"..\..\fireworks.gif");
                fireworksPictureBox3.Visible = true;
                fireworksTimer.Start();
            }
            else
            {
                MessageBox.Show("!!!!!legend!!!!!");
                legend++;
                // 레전더리일 때 폭죽 움짤 표시
                fireworksPictureBox1.Image = Image.FromFile(@"..\..\fireworks.gif");
                fireworksPictureBox1.Visible = true;
                fireworksPictureBox2.Image = Image.FromFile(@"..\..\fireworks.gif");
                fireworksPictureBox2.Visible = true;
                fireworksPictureBox3.Image = Image.FromFile(@"..\..\fireworks.gif");
                fireworksPictureBox3.Visible = true;
                fireworksTimer.Start();
            }
            setcard();
        }
        private void setcard() 
        {
            normal_txt.Text = "노말 : " + normal;
            rare_txt.Text = "레어 : " + rare;
            epic_txt.Text = "에픽 : " + epic;
            unique_txt.Text = "유니크 : " + unique;
            legend_txt.Text = "레전더리 : " + legend;
        }
    }
}
