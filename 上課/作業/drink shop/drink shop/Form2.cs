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
    public partial class Form2 : Form
    {
        Dictionary<string, int> drink = new Dictionary<string, int>();
        Dictionary<string, int> feed = new Dictionary<string, int>();
        List<string> listIce = new List<string>();
        List<string> listSuger = new List<string>();
        List<string> listFeed = new List<string>();
        string drinkName = "";
        string ice = "";
        string sugar = "";
        int dPrice = 0;
        int fPrice = 0;
        int dfPrice = 0;
        int quantity = 0;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblClient.Text = GlobalVar.ClientName;
            lblClientNum.Text = GlobalVar.ClientNum;
            cboxDSChoose.Items.Add(shop1.shopName);
            cboxDSChoose.Items.Add(shop2.shopName);
            cboxDSChoose.Items.Add(shop3.shopName);

            listIce.Add("正常");
            listIce.Add("少冰");
            listIce.Add("微冰");
            listIce.Add("去冰");

            listSuger.Add("正常");
            listSuger.Add("半糖");
            listSuger.Add("微糖");
            listSuger.Add("無糖");

            foreach(string myItem in listIce)
            {
                cboxIce.Items.Add(myItem);
            }
            cboxIce.SelectedIndex = 0;
            ice = listIce[cboxIce.SelectedIndex];
            foreach(string myItem in listSuger)
            {
                cboxSugar.Items.Add(myItem);
            }
            cboxSugar.SelectedIndex = 0;
            sugar = listSuger[cboxSugar.SelectedIndex];
            quantity = 1;
            txtQuantity.Text = quantity.ToString();
            顯示價格();
        }

        private void cboxDSChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboxDSChoose.SelectedIndex)
            {
                case 0:
                    shop1 shop1 = new shop1();
                    drink = shop1.drink;
                    feed = shop1.feed;
                    foreach(KeyValuePair<string,int> myDic in drink)
                    {
                        string itemKey = myDic.Key;
                        int L = 0;
                        string K = "";
                        L = itemKey.Length;
                        for (int i = 1; i <=15 - L; i++)
                        {
                            K += "--";
                        }
                        string itemValuePair = myDic.Value+"元";
                        lboxDrink.Items.Add(string.Format($"{itemKey}{K}{itemValuePair}"));
                    }
                    foreach(KeyValuePair<string, int> myDic in feed)
                    {
                        string itemKey = myDic.Key;
                        int L = 0;
                        string K = "";
                        L = itemKey.Length;
                        for (int i = 1; i <= 7 - L; i++)
                        {
                            K += "--";
                        }
                        string itemValuePair = myDic.Value + "元";
                        lboxFeed.Items.Add(string.Format($"{itemKey}{K}{itemValuePair}"));
                    }
                    GlobalVar.newShopNum = shop1.shopNum;
                    GlobalVar.newShopName = shop1.shopName;
                    lboxDrink.Enabled = true;
                    lboxFeed.Enabled = true;
                    cboxDSChoose.Enabled = false;
                    break;
                case 1:
                    shop2 shop2 = new shop2();
                    drink = shop2.drink;
                    feed = shop2.feed;
                    GlobalVar.newShopNum = shop2.shopNum;
                    GlobalVar.newShopName = shop2.shopName;
                    foreach (KeyValuePair<string, int> myDic in drink)
                    {
                        string itemKey = myDic.Key;
                        int L = 0;
                        string K = "";
                        L = itemKey.Length;
                        for (int i = 1; i <= 15 - L; i++)
                        {
                            K += "--";
                        }
                        string itemValuePair = myDic.Value + "元";
                        lboxDrink.Items.Add(string.Format($"{itemKey}{K}{itemValuePair}"));
                    }
                    foreach (KeyValuePair<string, int> myDic in feed)
                    {
                        string itemKey = myDic.Key;
                        int L = 0;
                        string K = "";
                        L = itemKey.Length;
                        for (int i = 1; i <= 7 - L; i++)
                        {
                            K += "--";
                        }
                        string itemValuePair = myDic.Value + "元";
                        lboxFeed.Items.Add(string.Format($"{itemKey}{K}{itemValuePair}"));
                    }
                    lboxDrink.Enabled = true;
                    lboxFeed.Enabled = true;
                    cboxDSChoose.Enabled = false;
                    break;
                case 2:
                    shop3 shop3 = new shop3();
                    drink = shop3.drink;
                    feed = shop3.feed;
                    GlobalVar.newShopNum = shop3.shopNum;
                    GlobalVar.newShopName = shop3.shopName;
                    foreach (KeyValuePair<string, int> myDic in drink)
                    {
                        string itemKey = myDic.Key;
                        int L = 0;
                        string K = "";
                        L = itemKey.Length;
                        for (int i = 1; i <= 15 - L; i++)
                        {
                            K += "--";
                        }
                        string itemValuePair = myDic.Value + "元";
                        lboxDrink.Items.Add(string.Format($"{itemKey}{K}{itemValuePair}"));
                    }
                    foreach (KeyValuePair<string, int> myDic in feed)
                    {
                        string itemKey = myDic.Key;
                        int L = 0;
                        string K = "";
                        L = itemKey.Length;
                        for (int i = 1; i <= 7 - L; i++)
                        {
                            K += "--";
                        }
                        string itemValuePair = myDic.Value + "元";
                        lboxFeed.Items.Add(string.Format($"{itemKey}{K}{itemValuePair}"));
                    }
                    lboxDrink.Enabled = true;
                    lboxFeed.Enabled = true;
                    cboxDSChoose.Enabled = false;
                    break;
            }
        }
        private void btnShopReChoose_Click(object sender, EventArgs e)
        {
            if(GlobalVar.OrderList.Count!=0)
            {
                DialogResult R = MessageBox.Show("重新選擇店家將會清除購物清單","清除確認",MessageBoxButtons.YesNo);
                if(R == DialogResult.No)
                {
                    return;
                }
            }
            cboxDSChoose.Enabled = true;
            lboxDrink.Items.Clear();
            lboxFeed.Items.Clear();
            lboxDrink.Enabled = false;
            lboxFeed.Enabled = false;
            dPrice = 0;
            fPrice = 0;
            drinkName = "";
            顯示價格();

            GlobalVar.OrderList.Clear();
        }

        private void lboxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lboxDrink.SelectedIndex;
            try
            {
                drinkName = drink.ElementAt(index).Key;
                dPrice = drink.ElementAt(index).Value;
                顯示價格();
            }
            catch
            {

            }

        }

        private void cboxSugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            sugar = listSuger[cboxSugar.SelectedIndex];
        }

        private void cboxIce_SelectedIndexChanged(object sender, EventArgs e)
        {
            ice = listIce[cboxIce.SelectedIndex];
        }

        private void lboxFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fPrice = 0;
                listFeed.Clear();
                for (int i = 0; i < 4; i++)
                {
                    if (lboxFeed.GetSelected(i))
                    {
                        listFeed.Add(feed.ElementAt(i).Key);
                        fPrice += feed.ElementAt(i).Value;
                    }
                }
                顯示價格();
            }
            catch
            {

            }
        }

        private void btnFeedClear_Click(object sender, EventArgs e)
        {
            fPrice = 0;
            listFeed.Clear();
            for (int i = 0; i < 4; i++)
            {
                lboxFeed.SetSelected(i, false);

            }
            顯示價格();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text != "")
            {
                if (Int32.TryParse(txtQuantity.Text, out quantity))
                {
                    if (quantity < 1)
                    {
                        quantity = 1;
                    }
                }
                else
                {
                    txtQuantity.Text = "1";
                }
            }
        }

        private void btnJoinOrder_Click(object sender, EventArgs e)
        {
            if(drinkName == "")
            {
                MessageBox.Show("未選擇飲料");
                return;
            }
            Order order = new Order();
            order.drinkName = drinkName;
            order.quantity = quantity;
            foreach(string item in listFeed)
            {
                order.feedName += item + " ";
            }
            order.fPrice = fPrice;
            order.dPrice = dPrice;
            order.sugar = sugar;
            order.ice = ice;
            order.orderPrice = GlobalVar.orderMath.orderPrice(order.fdPrice, order.quantity);
            order.shopNum = GlobalVar.newShopNum;
            GlobalVar.OrderList.Add(order);
            //orderReset();
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            if (GlobalVar.結帳單 == null)
            {
                Form3 結帳單 = new Form3();
                GlobalVar.結帳單 = 結帳單;
            }
            GlobalVar.結帳單.Show();
            this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVar.訂購人輸入.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.訂購人輸入.Close();
        }
        //
        void 顯示價格()
        {
            dfPrice = dPrice + fPrice;
            int thistotal = dfPrice * quantity;
            lblPrice.Text = dfPrice.ToString();
            lblTotal.Text = thistotal.ToString();
        }
        void orderReset()
        {
            drinkName = "";
            lboxDrink.SetSelected(lboxDrink.SelectedIndex, false);
            fPrice = 0;
            listFeed.Clear();
            for (int i = 0; i < 4; i++)
            {
                lboxFeed.SetSelected(i, false);
            }
        }
    }
}
