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
            Console.WriteLine("第一個Windows Form程式");
            Console.WriteLine("小數位數的控制 pi: {0:F2}", 3.141592);//格式化字元 :F 小數點後幾位預設2
            Console.WriteLine("百分比號: {0:P}", 0.9751);// 百分比號:P   
            Console.WriteLine("科學記號: {0:E}",1004413215000.0000000000000000);//科學記號 :E
            Console.WriteLine("金融符號: {0:C}", 1000000); //金融符號
            Console.WriteLine("整數補零: {0:D8}", 1234);// 整數補零到八位

            Console.WriteLine("現在時間: {0}", System.DateTime.Now);


            Console.WriteLine("{0:d}", DateTime.Now);
            Console.WriteLine("{0:D}", DateTime.Now);
            Console.WriteLine("{0:F}", DateTime.Now);
            Console.WriteLine("{0:T}",DateTime.Now);
            Console.WriteLine("{0:t}", DateTime.Now);
            Console.WriteLine("{0:M}", DateTime.Now);

            System.Windows.Forms.MessageBox.Show("歡迎使用本程式");
            MessageBox.Show("Windows Form App 開發", "標題" , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            lbl標題.Text = "Super好喝自動販賣機";
            lbl回應訊息.Text = "請選擇您要購買的飲料";

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void btn紅茶_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "您選擇了紅茶, 請投入  20 元";

        }

        private void btn綠茶_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "您選擇了綠茶, 請投入  25 元";
        }

        private void btn奶茶_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "您選擇了奶茶, 請投入  30 元";
        }

        private void btnCoke_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "您選擇了可樂, 請投入  15 元";
        }
    }
}
