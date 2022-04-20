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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_test1_Click(object sender, EventArgs e)
        {
            btn_1.Text = "222";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_test1.Text = btn_1.Text;

            MessageBox.Show(btn_1.Text);
        }
    }
}
