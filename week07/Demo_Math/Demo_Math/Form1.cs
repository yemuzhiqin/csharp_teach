﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_a.Text);
            int b = Convert.ToInt32(txt_b.Text);
            int x = Convert.ToInt32(txt_c.Text);

            if (x == a+b)
            {
                lbl_Msg.Text = "你答对了，真棒！";
            }
            else
            {
                lbl_Msg.Text = "你答错了，加油！";
                txt_c.Focus();
            }
        }

    }
}
