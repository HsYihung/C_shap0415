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
    public partial class Form3 : Form
    {
        int Discount = 0;

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            lblClient.Text = "訂購人 : " +GlobalVar.ClientName;
            lblClientNum.Text = "訂購人電話 : "+GlobalVar.ClientNum;
            int orderNum = 1;
            foreach(Order myOrder in GlobalVar.OrderList)
            {
                string strItem = string.Format($"{orderNum}.{myOrder.drinkName} {myOrder.fdPrice}元 {myOrder.quantity}杯 共{myOrder.orderPrice:C0}元");
                lboxDSList.Items.Add(strItem);                
                orderNum++;                
            }
            顯示總價();
        }
        private void btnShowList_Click(object sender, EventArgs e)
        {
            int orderNum = 1;
            string strItem = "";
            foreach (Order myOrder in GlobalVar.OrderList)
            {
                strItem += string.Format($"{orderNum}.{myOrder.drinkName} 甜度:{myOrder.sugar} 冰塊:{myOrder.ice} {myOrder.feedName}{myOrder.fdPrice}元 {myOrder.quantity}杯 共{myOrder.orderPrice:C0}元\n");                
                orderNum++;
            }
            MessageBox.Show(strItem);
        }
        private void btnReClient_Click(object sender, EventArgs e)
        {
            GlobalVar.訂購人輸入.Show();
            this.Hide();
        }

        private void radioDis1_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.orderMath.DisNum = 1;
            GlobalVar.orderMath.discountMath();
            GlobalVar.orderMath.texMath(chkTex.Checked);
            顯示總價();
        }

        private void radioDis2_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.orderMath.DisNum = 2;
            GlobalVar.orderMath.discountMath();
            GlobalVar.orderMath.texMath(chkTex.Checked);
            顯示總價();
        }

        private void radioDis3_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.orderMath.DisNum = 3;
            GlobalVar.orderMath.discountMath();
            GlobalVar.orderMath.texMath(chkTex.Checked);
            顯示總價();
        }

        private void btnListOneClear_Click(object sender, EventArgs e)
        {
            int indexClear = -1;
            indexClear = lboxDSList.SelectedIndex;
            if (indexClear == -1)
            {
                MessageBox.Show("請選擇要刪除的訂單資料");
                return;
            }

            int reQuantity = GlobalVar.OrderList[indexClear].quantity;
            int rePrice = GlobalVar.OrderList[indexClear].fdPrice;
            GlobalVar.orderMath.reOrder(rePrice, reQuantity);
            GlobalVar.OrderList.RemoveAt(indexClear);
            lboxDSList.Items.RemoveAt(indexClear);
            GlobalVar.orderMath.discountMath();
            GlobalVar.orderMath.texMath(chkTex.Checked);
            顯示總價();


        }

        private void btnReList_Click(object sender, EventArgs e)
        {

        }

        private void btnListAllClear_Click(object sender, EventArgs e)
        {
            GlobalVar.OrderList.Clear();
            GlobalVar.orderMath.clear();
            lboxDSList.Items.Clear();
            GlobalVar.orderMath.discountMath();
            GlobalVar.orderMath.texMath(chkTex.Checked);
            顯示總價();
        }

        private void btnNewList_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVar.訂購單.Show();
        }

        private void btnListtotxt_Click(object sender, EventArgs e)
        {
            string str檔案路徑 = @"C:\Users\iii\Desktop\C_shap\上課\作業\drink shop";
            System.Random myRnd = new Random();
            int myNum = myRnd.Next(1000, 9999);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + myNum + @"訂購檔.txt";
            string str完整檔案路徑 = str檔案路徑 + @"\" + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Text File|*.txt";

            DialogResult R = sfd.ShowDialog();

            if (R == DialogResult.OK)
            {
                str完整檔案路徑 = sfd.FileName;
            }
            else
            {
                return;
            }
            ///
            List<string> list訂單資訊 = new List<string>();
            list訂單資訊.Add($"*************** {GlobalVar.newShopName} *****************");
            list訂單資訊.Add("---------------------------------------------");
            list訂單資訊.Add("訂購時間:" + DateTime.Now.ToString());
            list訂單資訊.Add(" 訂購人:" + GlobalVar.ClientName + " 訂購人電話:" + GlobalVar.ClientNum);
            list訂單資訊.Add("---------------------------------------------");
            list訂單資訊.Add("<<<< 訂購品項 >>>>");
            foreach (Order myOrder in GlobalVar.OrderList)
            {
                string 訂單資訊 = string.Format($"{myOrder.drinkName} 甜度:{myOrder.sugar} 冰塊:{myOrder.ice} 加料:{myOrder.feedName} 加料價格:{myOrder.fPrice} 飲料價格:{myOrder.dPrice} {myOrder.quantity}杯 {myOrder.orderPrice:C0}元");
                list訂單資訊.Add(訂單資訊);
            }
            list訂單資訊.Add("---------------------------------------------");            
            list訂單資訊.Add($"折扣 :{GlobalVar.orderMath.DisName} 稅金 : {GlobalVar.orderMath._texPrice:C0} 元");
            list訂單資訊.Add($"總價:{GlobalVar.orderMath.totOrderPrice:C0}元");
            list訂單資訊.Add("---------------------------------------------");
            list訂單資訊.Add("******************謝謝光臨********************");

            System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8);
            MessageBox.Show("存檔成功");
        }

        private void chkTex_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.orderMath.discountMath();
            GlobalVar.orderMath.texMath(chkTex.Checked);
            顯示總價();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.訂購單.Close();
        }

        void 顯示總價()
        {
            lblTotal.Text = string.Format($"{GlobalVar.orderMath.totOrderPrice:C0}元");
        }
        public void showForm3()
        {
            lboxDSList.Items.Clear();
            lblClient.Text = "訂購人 : " + GlobalVar.ClientName;
            lblClientNum.Text = "訂購人電話 : " + GlobalVar.ClientNum;
            int orderNum = 1;
            foreach (Order myOrder in GlobalVar.OrderList)
            {
                string strItem = string.Format($"{orderNum}.{myOrder.drinkName} {myOrder.fdPrice}元 {myOrder.quantity}杯 共{myOrder.orderPrice:C0}元");
                lboxDSList.Items.Add(strItem);
                orderNum++;
            }
            GlobalVar.orderMath.discountMath();
            GlobalVar.orderMath.texMath(chkTex.Checked);
            顯示總價();
        }


    }
}
