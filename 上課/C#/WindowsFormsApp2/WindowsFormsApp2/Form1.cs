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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn公分轉英吋_Click(object sender, EventArgs e)
        {

            if (txt公分.Text.Length > 0) // "" 空字串
            {
                try
                {
                    float myCm = 0.0f;
                    float myInch = 0.0f;
                    string strInput = txt公分.Text;
                    myCm = Convert.ToSingle(strInput);
                    myInch = myCm * 0.3937f;
                    //txt英吋.Text = Convert.ToString(myInch);
                    txt英吋.Text = string.Format($"{myInch:F2}");// 可使用格式
                }
                catch(Exception error)
                {
                    //MessageBox.Show(error.ToString(), "發生錯誤");
                    MessageBox.Show("輸入格式錯誤, 請重新輸入");
                    txt公分.Clear();
                    txt英吋.Clear();
                }

                finally
                {
                    txt平方公尺.Clear();
                    txt坪數.Clear();
                    txt公斤.Clear();
                    txt磅.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入公分數值");
            }

        }

        private void btn英吋轉公分_Click(object sender, EventArgs e)
        {

            if (txt英吋.Text != "")//
            {
                try
                {
                    float myInch = 0.0f;
                    float myCm = 0.0f;
                    string strInput = txt英吋.Text;
                    myInch = Convert.ToSingle(strInput);
                    myCm = myInch / 0.3937f;
                    txt公分.Text = string.Format($"{myCm:F2}");
                }
                catch(Exception error)
                {
                    MessageBox.Show("輸入格式錯誤, 請重新輸入");
                    txt英吋.Clear();
                    txt公分.Clear();
                }
                finally
                {

                }
            }
            else
            {
                MessageBox.Show("請輸入英吋數值");
            }

        }

        private void btn坪數轉平方公尺_Click(object sender, EventArgs e)
        {
            //double 比例3.3058
            if (txt坪數.Text != "")
            {
                try
                {
                    double myPin, myM2 = 0.0;//同時宣告不同的double變數相同初始值
                    myPin = Convert.ToDouble(txt坪數.Text);
                    myM2 = myPin * 3.3058;
                    txt平方公尺.Text = string.Format($"{myM2:F1}");
                }
                catch(Exception error)
                {
                    MessageBox.Show("輸入格式錯誤, 請重新輸入");
                    txt平方公尺.Clear();
                    txt坪數.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入坪數數值");
            }
        }

        private void btn平方公尺轉坪數_Click(object sender, EventArgs e)
        {

            if(txt平方公尺.Text !="")
            {
                try
                {
                    double myPin = 0.0;
                    double myM2 = 0.0;
                    string strInput = txt平方公尺.Text;
                    myM2 = Convert.ToDouble(strInput);
                    myPin = myM2 / 3.3058;
                    txt坪數.Text = string.Format($"{myPin:F1}");
                }
                catch(Exception error)
                {
                    MessageBox.Show("輸入格式錯誤, 請重新輸入");
                    txt平方公尺.Clear();
                    txt坪數.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入平方公尺數值");
            }

        }

        private void 公斤轉磅_Click(object sender, EventArgs e)
        {
            //double 比例 2.2
            /*if(txt公斤.Text !="")
            {
                try
                {
                    double myKg = 0.0;
                    double myIb = 0.0;
                    string strInput = txt公斤.Text;
                    myKg = Convert.ToDouble(strInput);
                    myIb = myKg * 2.2;
                    txt磅.Text = string.Format($"{myIb:F2}");
                }
                catch(Exception error)
                {
                    MessageBox.Show("輸入格式錯誤, 請重新數");
                    txt磅.Clear();
                    txt公斤.Clear();
                }
            }
            else
            {
                
            }
            */
            if (txt公斤.Text.Length > 0)
            {

                double myKg, myIb = 0.0;
                bool isRight = false;

                isRight = System.Double.TryParse(txt公斤.Text, out myKg);//試著轉換txt公斤.text ,如果轉換成功, myKg賦值,並回傳trye, 失敗回傳false

                if(isRight)
                {
                    myIb = myKg * 2.2;
                    txt磅.Text = string.Format($"{myIb:F2}");
                }
                else
                {
                    MessageBox.Show("輸入格式錯誤, 請重新輸入");
                    txt磅.Clear();
                    txt公斤.Clear();
                }

            }
            else
            {
                MessageBox.Show("請輸入公斤數值");
            }

        }

        private void 磅轉公斤_Click(object sender, EventArgs e)
        {
            if (txt磅.Text !="")
            {
                try
                {
                    double myIb = 0.0;
                    double myKg = 0.0;
                    string strInput = txt磅.Text;
                    myIb = Convert.ToDouble(strInput);
                    myKg = myIb / 2.2;
                    txt公斤.Text = string.Format($"{myKg:F2}");
                }
                catch(Exception error)
                {
                    MessageBox.Show("輸入格式錯誤, 請重新數");
                    txt磅.Clear();
                    txt公斤.Clear();
                }
            }
            else
            {

            }
        }
    }
}
