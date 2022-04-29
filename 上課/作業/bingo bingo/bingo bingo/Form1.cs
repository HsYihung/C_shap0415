using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bingo_bingo
{
    public partial class Form1 : Form
    {
        int lotteType = 0;
        int lotteTypeStar = 0;
        int lotteLength = 0;
        int[] betArray;
        int[] lotteArray;
        int x = 0;
        int supLotteNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lotteArray = new int[20];
            betArray = new int[10];
        }

        private void btnBet_Click(object sender, EventArgs e)
        {


            if (lotteType >= 8 && x < lotteType && lotteType <= 10)
            {
                if (betConfirm(txtBetNuber.Text))
                {
                    betArray[x] = Convert.ToInt32(txtBetNuber.Text);
                    lblBetNumber.Text += $"{txtBetNuber.Text.PadLeft(2, '0')} ";
                    x += 1;
                }
            }
            else if(lotteType > 100)
            {
                MessageBox.Show("超過投注上限");
            }
            else if (lotteType > 10 )
            {
                MessageBox.Show("所選擇玩法不需要投注號碼");
            }
            else if (lotteType == 0)
            {
                MessageBox.Show("尚未選擇玩法");
            }           
            if(x == lotteType )
            {
                lotteType += 100;
            }
            txtBetNuber.Clear();
        }

        private void btnBet10_Click(object sender, EventArgs e)
        {
            lotteType = 10;
            lotteClear();
        }

        private void btnBet9_Click(object sender, EventArgs e)
        {
            lotteType = 9;
            lotteClear();
        }

        private void btnBet8_Click(object sender, EventArgs e)
        {
            lotteType = 8;
            lotteClear();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            lotteType = 11;
            lotteClear();
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            lotteType = 12;
            lotteClear();
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            lotteType = 13;
            lotteClear();
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            lotteType = 14;
            lotteClear();
        }

        private void bntLottery_Click(object sender, EventArgs e)
        {
            if (lotteType <= 10)
            {
                if (lotteType == 0)
                {
                    MessageBox.Show("請選擇玩法");
                }
                else
                {
                    MessageBox.Show("投注號碼數目不正確");
                }
            }
            else
            {
                testLotte();
                switch (lotteType)
                {
                    case 11:
                        int singleNumber = 20 - winEven();
                        if(singleNumber>=13)
                        {
                            lblWinning.Text= $"單號數量{singleNumber}個 中獎了";
                        }
                        break;
                    case 12:
                        int evenNumber = winEven();
                        if (evenNumber >= 13)
                        {
                            lblWinning.Text = $"雙號數量{evenNumber}個 中獎了";
                        }
                        else
                        {
                            lblWinning.Text = $"雙號數量{evenNumber}個 沒有中獎";
                        }
                        break;
                    case 13:

                        break;
                    case 14:

                        break;
                    case 108:
                        int winNumber = winStar();
                        if(winNumber>=4)
                        {

                        }
                        else
                        {
                            lblWinning.Text += "\n沒有中獎";
                        }
                        
                        break;
                    case 109:

                        break;
                    case 110:

                        break;
                }
                lotteType = 0;
            }
        }
       
        //myMethods
        bool betConfirm(string a)
        {
            bool betConfirm = true;
            try
            {
                int b = Convert.ToInt32(a);
                if (b>0 && b<=80)
                {
                    if (betArray.Length > 0)
                    {
                        for (int i = 0; i < betArray.Length; i++)
                        {
                            if (betArray[i] == b)
                            {
                                betConfirm = false;
                                MessageBox.Show("重複輸入請重新輸入");
                                break;
                            }
                        }
                    }
                }
                else
                {
                    betConfirm = false;
                    MessageBox.Show("請1~80整數數字");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("請輸入數字");
                betConfirm = false;
            }
            return betConfirm;
        }
        void testLotte()
        {
            int[] testLotteArray = new int[20] { 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 14, 67, 63, 65, 2, 4, 6, 8, 10 };
            Array.Copy(testLotteArray, lotteArray, testLotteArray.Length);
            supLotteNumber = lotteArray[lotteArray.GetUpperBound(0)];
            Array.Sort(lotteArray);
            for(int i = 0; i<lotteArray.Length;i++)
            {
                lblLottoNumbers.Text += string.Format($"{lotteArray[i]:D2} ");
            }            
        }
        int winStar()
        {
            int myWinning = 0;
            string winNumber = "";
            for (int i = 0; i < lotteArray.Length; i++)
            {
                if (Array.IndexOf(betArray, lotteArray[i]) > -1)
                {
                    winNumber += string.Format($"{lotteArray[i]:D2} ");
                    myWinning += 1;
                }
            }
            lblWinning.Text =string.Format($"超級號號:{supLotteNumber:D2}\n中獎號碼:{winNumber}\n中了{myWinning}個號碼") ;
            return myWinning;
        }
        int winEven()
        {
            int MyEvenNumber = 0;

            for (int i = 0; i < lotteArray.Length; i++)
            {
                if(lotteArray[i]%2 == 0)
                {
                    MyEvenNumber++;
                }

            }

            return MyEvenNumber;
        }
        int winSize()
        {
            int myBigNumber = 0;
            for(int i = 0; i < lotteArray.Length; i++)
            {
                if (lotteArray[i] > 40)
                {
                    myBigNumber++;
                }
            }

            return myBigNumber;
        }

        void lotteClear()
        {
            Array.Clear(betArray, 0, 10);
            Array.Clear(lotteArray, 0, 20);
            lblBetNumber.Text = "";
            lblLottoNumbers.Text = "";
            lblWinning.Text = "";
        }
    }
}
