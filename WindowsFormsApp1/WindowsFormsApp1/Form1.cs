﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fivestone_start_btn_Click(object sender, EventArgs e)
        {
            fivestoneForm form = new fivestoneForm();
            form.ShowDialog();
        }

        private void aimtraining_btn_Click(object sender, EventArgs e)
        {
            aimtrainForm form = new aimtrainForm();
            form.ShowDialog();
        }

        private void rucktest_btn_Click(object sender, EventArgs e)
        {
            rucktestForm form = new rucktestForm();
            form.ShowDialog();
        }
    }
}
