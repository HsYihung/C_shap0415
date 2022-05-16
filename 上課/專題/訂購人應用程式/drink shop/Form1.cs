using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drink_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtClient.Text != ""||txtClientNum.Text!="")
            {
                GlobalVar.ClientName = txtClient.Text;
                GlobalVar.ClientNum = txtClientNum.Text;

                if(GlobalVar.訂購單 == null)
                {
                    Form2 訂購單 = new Form2();
                    GlobalVar.訂購單 = 訂購單;
                    GlobalVar.訂購人輸入 = this;
                }
                else
                {
                    GlobalVar.訂購單.Form2show();
                }                                         
                GlobalVar.訂購單.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("請輸入訂購人資訊");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClient.Clear();
            txtClientNum.Clear();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
