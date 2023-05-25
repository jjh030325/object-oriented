﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private Pen pen;
        private Brush wBrush, bBrush;

        private bool turn = false; // false: 흑돌, true: 백돌
        enum STONE { none, black, white };
        STONE[,] fivestonemap = new STONE[19, 19];

        public fivestoneForm()
        {
            InitializeComponent();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            drawfivestonemap();
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

            // 돌 그리기
            Rectangle r = new Rectangle(10 + gridsize * x - stonesize / 2,
                 10 + gridsize * y - stonesize / 2, stonesize, stonesize);

            if (turn == false)    // 검은 돌
            {
                g.FillEllipse(bBrush, r);
                fivestonemap[x, y] = STONE.black;
            }
            else  // 흰돌
            {
                g.FillEllipse(wBrush, r);
                fivestonemap[x, y] = STONE.white;
            }
            turn = !turn;  // 돌 색깔을 토글
            checkOmok(x, y);  // 오목이 만들어졌는지 체크하는 함수
        }
        private void checkOmok(int x, int y)
        {
            if (checkLR(x, y) >= 5)
                MessageBox.Show(fivestonemap[x, y] + " wins");
            if (checkUD(x, y) >= 5)
                MessageBox.Show(fivestonemap[x, y] + " wins");
            if (checkSLASH(x, y) >= 5)
                MessageBox.Show(fivestonemap[x, y] + " wins");
            if (checkBACKSLASH(x, y) >= 5)
                MessageBox.Show(fivestonemap[x, y] + " wins");
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