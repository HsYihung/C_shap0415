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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            string str帳號 = "黃小貓";
            string strPass = "23456";

            if ((txt使用者名稱.Text == str帳號) && (txt密碼.Text == strPass))
            {
                MessageBox.Show("登入成功");
                GlobalVar.目前的使用者 = txt使用者名稱.Text; 
                Form1 form人員建立 = new Form1();
                form人員建立.Show();
            }
            else
            {
                lbl回應訊息.Text = "輸入帳號密碼錯誤";
            }

        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt使用者名稱.Clear();
            txt密碼.Clear();
            lbl回應訊息.Text = "";
        }
    }
}
