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
        public rucktestForm()
        {
            InitializeComponent();
            random = new Random();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int randomNumber = random.Next(1, 10001);

            if(randomNumber <= 5000)
            {
                MessageBox.Show("normal");
                normal++;
            }else if(randomNumber <= 8000)
            {
                MessageBox.Show("rare!");
                rare++;
            }else if(randomNumber <= 9500)
            {
                MessageBox.Show("epic!!");
                epic++;
            }else if(randomNumber <= 9900)
            {
                MessageBox.Show("!!!unique!!!");
                unique++;
            }
            else
            {
                MessageBox.Show("!!!!!legend!!!!!");
                legend++;
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
        private void rucktestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
