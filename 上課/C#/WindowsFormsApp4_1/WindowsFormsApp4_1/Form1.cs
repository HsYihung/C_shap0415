using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_1
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

        private void btnCBVtest_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblCBVtest1.Text ="參數傳遞前的值:"+ x.ToString();
            testCBV(x);
            lblCBVtest3.Text = "參數傳遞後的值:"+ x.ToString();
        }

        private void btnCBRtest_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblCBRtest1.Text = "參數傳遞前的值:"+ x.ToString();
            testCBR(ref x);
            lblCBRtest3.Text = "參數傳遞後的值:"+ x.ToString();
        }

        //myMetods

        void testCBV(int y)
        {
            y++;
            lblCBVtest2.Text ="參數在方法裡面的值:"+ y.ToString();
        }
        void testCBR(ref int y)
        {
            y++;
            lblCBRtest2.Text = "參數在方法裡面的值:"+ y.ToString();
        }
    }
}
