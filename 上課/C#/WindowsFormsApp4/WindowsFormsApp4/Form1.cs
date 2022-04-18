using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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

        private void btnCbv測試_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblCbv1.Text = "變數在傳遞前的值" + x.ToString();
            callByValue(x);
            lblCbv3.Text = "變數在傳遞後的值" + x.ToString();
        }

        private void btnCbr測試_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblCbr1.Text = "變數在傳遞前的值" + x.ToString();
            callByRefence(ref x);
            lblCbr3.Text = "變數在傳遞後的值" + x.ToString();
        }

        //myMethods
        void callByValue(int y)
        {
            y += 1;
            lblCbv2.Text = "參數在方法裡面的值 :" + y.ToString();
        }
        void callByRefence(ref int y)
        {
            y++;
            lblCbr2.Text = "參數在方法裡面的值 :" + y.ToString();
        }
    }
}
