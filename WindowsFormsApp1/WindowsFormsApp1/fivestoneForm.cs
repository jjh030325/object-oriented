﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fivestoneForm : Form
    {
        private int stonesize = 18;
        private int gridsize = 20;
        private int dotsize = 8;
        private int endcheck = 0;
        private Pen pen;
        private Brush wBrush, bBrush;
        private int counttime = 30;

        private bool turn = false; // false: 흑돌, true: 백돌
        enum STONE { none, black, white };
        STONE[,] fivestonemap = new STONE[19, 19];

        private Timer play_timer;     //타이머 추가
        private int elapsedTime; //경과시간

        public fivestoneForm()
        {
            InitializeComponent();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);
            this.Text = "흑의 턴";

            panel1.Paint += (s, e) =>
            {
                drawfivestonemap();
            };
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

                if (turn == true)
                {
                    MessageBox.Show("black " + " wins");
                    endcheck = 1;
                }
                else
                {
                    MessageBox.Show("white " + " wins");
                    endcheck = 1;
                }
            }
        }
        private void drawfivestonemap()
        {
            Graphics g = panel1.CreateGraphics();
            for (int x = 0; x < 19; x++)
                g.DrawLine(pen, 10, 10 + x * gridsize, 370, 10 + x * gridsize);
            for (int x = 0; x < 19; x++)
                g.DrawLine(pen, 10 + x * gridsize, 10, 10 + x * gridsize, 10 + 18 * gridsize);
            drawdot(g);
        }
        private void drawdot(Graphics g)
        {
            for (int x = 3; x <= 15; x += 6)
                for (int y = 3; y <= 15; y += 6)
                {
                    Rectangle r = new Rectangle(10 + gridsize * x - dotsize / 2, 10 + gridsize * y - dotsize / 2, dotsize, dotsize);
                    g.FillEllipse(bBrush, r);
                }
        }
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            int x, y;
            x = e.X / gridsize;
            y = e.Y / gridsize;
            if (x < 0 || x >= 19 || y < 0 || y >= 19)
                return;
            drawstone(x, y);
        }
        private void drawstone(int x, int y)
        {
            Graphics g = panel1.CreateGraphics();

            // 이미 어떤 돌이 놓여져 있으면 return
            if (fivestonemap[x, y] == STONE.black || fivestonemap[x, y] == STONE.white)
                return;

            if(endcheck == 0)
            {
                // 돌 그리기
                Rectangle r = new Rectangle(10 + gridsize * x - stonesize / 2,
                     10 + gridsize * y - stonesize / 2, stonesize, stonesize);

                if (turn == false)    // 검은 돌
                {
                    fivestonemap[x, y] = STONE.black;
                    if (checksixmok(x, y) == true)
                    {
                        fivestonemap[x, y] = STONE.none;
                        turn = !turn;
                    }
                    else if (check33(x, y) == true)
                    {
                        fivestonemap[x, y] = STONE.none;
                        turn = !turn;
                    }
                    else if (check44(x, y) == true)
                    {
                        fivestonemap[x, y] = STONE.none;
                        turn = !turn;
                    }
                    else
                    {
                        g.FillEllipse(bBrush, r);
                        fivestonemap[x, y] = STONE.black;
                        this.Text = "백의 턴";
                        turn_txt.Text = "백의 턴";
                        turn_txt.ForeColor = Color.White;
                        elapsedTime = 0;
                        timer_label.Text = "timer : " + counttime.ToString(); // 경과 시간 표시
                        play_timer.Start();
                    }
                }
                else  // 흰돌
                {
                    g.FillEllipse(wBrush, r);
                    fivestonemap[x, y] = STONE.white;
                    this.Text = "흑의 턴";
                    turn_txt.Text = "흑의 턴";
                    turn_txt.ForeColor = Color.Black;
                    elapsedTime = 0;
                    timer_label.Text = "timer : " + counttime.ToString(); // 경과 시간 표시
                    play_timer.Start();
                }
                turn = !turn;  // 돌 색깔을 토글
                checkOmok(x, y);  // 오목이 만들어졌는지 체크하는 함수
            }
            
        }
        private bool checksixmok(int x, int y)
        {
            if (checkLR(x, y) >= 6)
            {
                MessageBox.Show("흑은 6목을 둘 수 없습니다.");
                return true;
            }
            else if (checkUD(x, y) >= 6)
            {
                MessageBox.Show("흑은 6목을 둘 수 없습니다.");
                return true;
            }
            else if (checkSLASH(x, y) >= 6)
            {
                MessageBox.Show("흑은 6목을 둘 수 없습니다.");
                return true;
            }
            else if (checkBACKSLASH(x, y) >= 6)
            {
                MessageBox.Show("흑은 6목을 둘 수 없습니다.");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void checkOmok(int x, int y)
        {
            if (checkLR(x, y) >= 5 && fivestonemap[x, y] != STONE.none)
            {
                play_timer.Stop(); // 타이머 멈춤
                turn_txt.Text = fivestonemap[x, y] + " wins";
                if (turn == true)
                {
                    turn_txt.ForeColor = Color.Black;
                }
                else
                {
                    turn_txt.ForeColor = Color.White;
                }
                MessageBox.Show(fivestonemap[x, y] + " wins");
                endcheck = 1;
            }
            else if (checkUD(x, y) >= 5 && fivestonemap[x, y] != STONE.none)
            {
                play_timer.Stop(); // 타이머 멈춤
                turn_txt.Text = fivestonemap[x, y] + " wins";
                if (turn == true)
                {
                    turn_txt.ForeColor = Color.Black;
                }
                else
                {
                    turn_txt.ForeColor = Color.White;
                }
                MessageBox.Show(fivestonemap[x, y] + " wins");
                endcheck = 1;
            }
            else if (checkSLASH(x, y) >= 5 && fivestonemap[x, y] != STONE.none)
            {
                play_timer.Stop(); // 타이머 멈춤
                turn_txt.Text = fivestonemap[x, y] + " wins";
                if (turn == true)
                {
                    turn_txt.ForeColor = Color.Black;
                }
                else
                {
                    turn_txt.ForeColor = Color.White;
                }
                MessageBox.Show(fivestonemap[x, y] + " wins");
                endcheck = 1;
            }
            else if (checkBACKSLASH(x, y) >= 5 && fivestonemap[x, y] != STONE.none)
            {
                play_timer.Stop(); // 타이머 멈춤
                turn_txt.Text = fivestonemap[x, y] + " wins";
                if (turn == true)
                {
                    turn_txt.ForeColor = Color.Black;
                }
                else
                {
                    turn_txt.ForeColor = Color.White;
                }
                MessageBox.Show(fivestonemap[x, y] + " wins");
                endcheck = 1;
            }
        }
        private bool check33(int x, int y)
        {
            int check = 0;
            if (checkLR(x, y) == 3 && fivestonemap[x, y] == STONE.black)
            {
                check++;
            }
            if (checkUD(x, y) == 3 && fivestonemap[x, y] == STONE.black)
            {
                check++;
            }
            if (checkSLASH(x, y) == 3 && fivestonemap[x, y] == STONE.black)
            {
                check++;
            }
            if (checkBACKSLASH(x, y) == 3 && fivestonemap[x, y] == STONE.black)
            {
                check++;
            }
            if (check >= 2)
            {
                MessageBox.Show("흑은 33수를 둘 수 없습니다.");
                return true;
            }
            return false;
        }

        private bool check44(int x, int y)
        {
            int check = 0;
            if (checkLR(x, y) == 4 && fivestonemap[x, y] == STONE.black)
            {
                check++;
            }
            if (checkUD(x, y) == 4 && fivestonemap[x, y] == STONE.black)
            {
                check++;
            }
            if (checkSLASH(x, y) == 4 && fivestonemap[x, y] == STONE.black)
            {
                check++;
            }
            if (checkBACKSLASH(x, y) == 4 && fivestonemap[x, y] == STONE.black)
            {
                check++;
            }
            if (check >= 2)
            {
                MessageBox.Show("흑은 44수를 둘 수 없습니다.");
                return true;
            }
            return false;
        }

        private int checkLR(int x, int y)
        {
            int cnt = 1;
            for (int i = 1; i < 5; i++)
                if (x + i <= 18 && fivestonemap[x + i, y] == fivestonemap[x, y])
                    cnt++;
                else
                    break;
            for (int i = 1; i < 5; i++)
                if (x - i >= 0 && fivestonemap[x - i, y] == fivestonemap[x, y])
                    cnt++;
                else
                    break;
            return cnt;
        }
        private int checkUD(int x, int y)
        {
            int cnt = 1;
            for (int i = 1; i < 5; i++)
                if (y + i <= 18 && fivestonemap[x, y + i] == fivestonemap[x, y])
                    cnt++;
                else
                    break;
            for (int i = 1; i < 5; i++)
                if (y - i >= 0 && fivestonemap[x, y - i] == fivestonemap[x, y])
                    cnt++;
                else
                    break;
            return cnt;
        }
        private int checkSLASH(int x, int y)
        {
            int cnt = 1;
            for (int i = 1; i < 5; i++)
                if (x + i <= 18 && y + i <= 18 && fivestonemap[x + i, y + i] == fivestonemap[x, y])
                    cnt++;
                else
                    break;
            for (int i = 1; i < 5; i++)
                if (x - i >= 0 && y - i >= 0 && fivestonemap[x - i, y - i] == fivestonemap[x, y])
                    cnt++;
                else
                    break;
            return cnt;
        }
        private int checkBACKSLASH(int x, int y)
        {
            int cnt = 1;
            for (int i = 1; i < 5; i++)
                if (x + i <= 18 && y - i >= 0 && fivestonemap[x + i, y - i] == fivestonemap[x, y])
                    cnt++;
                else
                    break;
            for (int i = 1; i < 5; i++)
                if (x - i >= 0 && y + i <= 18 && fivestonemap[x - i, y + i] == fivestonemap[x, y])
                    cnt++;
                else
                    break;
            return cnt;
        }

        private void fivestoneForm_Load(object sender, EventArgs e)
        {

        }
    }
}
