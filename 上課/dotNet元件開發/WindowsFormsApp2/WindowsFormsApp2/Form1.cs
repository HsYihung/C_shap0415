using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public delegate void MyDelegate(string msg);


        public Form1()
        {
            InitializeComponent();
        }

        void passDelegateMethOne(MyDelegate myDelegateObj)
        {
            myDelegateObj("成功執行 !!");
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        } 

        void MethodOne(string myMsg)
        {
            string strOut = "MethodOne 執行, 傳遞參數:" + myMsg;
            MessageBox.Show(strOut);
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            MyDelegate delegateTest = MethodOne;
            passDelegateMethOne(delegateTest);


        }

        private void btnAction_Click(object sender, EventArgs e)
        {

        }

        private void btnFunc_Click(object sender, EventArgs e)
        {

        }



    }
}
