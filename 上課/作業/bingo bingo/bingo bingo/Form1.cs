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
        //int lotteType = 0;
        int lotteTypeStar = 0;
        int lotteTypeEven = 0;
        int lotteTypeSize = 0;
        int[] betArray;
        int[] lotteArray;
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
            if (lotteTypeStar == 0)
            {
                MessageBox.Show("未選擇投注星數");
                return;
            }
            int x = 0;
            bool betError = false;
            if (betConfirm(x, txtBetNuber1.Text))
            {
                betError = true;
                txtBetNuber1.Text = null;
                
            }
            x++;
            if (betConfirm(x, txtBetNuber2.Text))
            {
                betError = true;
                txtBetNuber2.Text = null;
                
            }
            x++;
            if (betConfirm(x, txtBetNuber3.Text))
            {
                betError = true;
                txtBetNuber3.Text = null;
                
            }
            x++;
            if (betConfirm(x, txtBetNuber4.Text))
            {
                betError = true;
                txtBetNuber4.Text = null;
                
            }
            x++;
            if (betConfirm(x, txtBetNuber5.Text))
            {
                betError = true;
                txtBetNuber5.Text = null;
                
            }
            x++;
            if (betConfirm(x, txtBetNuber6.Text))
            {
                betError = true;
                txtBetNuber6.Text = null;
                
            }
            x++;
            if (betConfirm(x, txtBetNuber7.Text))
            {
                betError = true;
                txtBetNuber7.Text = null;
                
            }
            x++;
            if (betConfirm(x, txtBetNuber8.Text))
            {
                betError = true;
                txtBetNuber8.Text = null;
                
            }
            x++;
            if (lotteTypeStar >= 9)
            {
                if (betConfirm(x, txtBetNuber9.Text))
                {
                    betError = true;
                    txtBetNuber9.Text = null;
                    
                }
                x++;
                if (lotteTypeStar == 10)
                {
                    if (betConfirm(x, txtBetNuber10.Text))
                    {
                        betError = true;
                        txtBetNuber10.Text = null;
                        
                    }
                }
            }
            if(betError)
            {
                Array.Clear(betArray, 0, 10);
                x = 0;
                MessageBox.Show("重複輸入,請重新輸入");
                return;
            }
            foreach(int i in betArray)
            {
                if (i!=0) 
                {
                    lblBetNumber.Text += string.Format($"{i:D2} ");
                }
            }
            lotteTypeStar += 100;
            x = 0;
            btnBet.Enabled = false;
            btnLottery.Enabled = true;
        }

        private void btnBet10_Click(object sender, EventArgs e)
        {
            lotteTypeStar = 10;
            btnBet10.Enabled = false;
            btnBet9.Enabled = true;
            btnBet8.Enabled = true;
            txtBetNuber9.Enabled = true;
            txtBetNuber10.Enabled = true;
            btnBet.Enabled = true;
            lblBetNumber.Text = "";
        }

        private void btnBet9_Click(object sender, EventArgs e)
        {
            lotteTypeStar = 9;
            btnBet10.Enabled = true;
            btnBet9.Enabled = false;
            btnBet8.Enabled = true;
            txtBetNuber9.Enabled = true;
            txtBetNuber10.Enabled = false;
            btnBet.Enabled = true;
            lblBetNumber.Text = "";
        }

        private void btnBet8_Click(object sender, EventArgs e)
        {
            lotteTypeStar = 8;
            btnBet10.Enabled = true;
            btnBet9.Enabled = true;
            btnBet8.Enabled = false;
            txtBetNuber9.Enabled = false;
            txtBetNuber10.Enabled = false;
            btnBet.Enabled = true;
            lblBetNumber.Text = "";
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            lotteTypeEven = 1;
            btnSingle.Enabled = false;
            btnEven.Enabled = true;
            btnLottery.Enabled = true;
            lblBetNumber.Text = "";
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            lotteTypeEven = 2;
            btnSingle.Enabled = true;
            btnEven.Enabled = false;
            btnLottery.Enabled = true;
            lblBetNumber.Text = "";
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            lotteTypeSize = 1;
            btnBig.Enabled = false;
            btnSmall.Enabled = true;
            btnLottery.Enabled = true;
            lblBetNumber.Text = "";
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            lotteTypeSize = 2;
            btnBig.Enabled = true;
            btnSmall.Enabled = false;
            btnLottery.Enabled = true;
            lblBetNumber.Text = "";
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            string playType = "選擇玩法: ";
            string winNumber = "--------------------";
            string winBigSamll = "--------------------";
            string winEvenSingle = "--------------------";
            //testLotte();
            lotteRandom();
            if(lotteTypeStar>=8)
            {
                if(lotteTypeStar<11)
                {                    
                    Array.Clear(betArray, 0, 10);
                    lblLottoNumbers.Text = "";
                    btnLottery.Enabled = false;
                    MessageBox.Show("投注號碼數量不正確,請重新輸入");
                    return;
                }
                string[] winStrArray = winStar();
                int winSter = Convert.ToInt32(winStrArray[0]);                
                playType += $" {lotteTypeStar-100}星 ";
                winNumber = $"中了{winSter}個號碼\n{winStrArray[1]}";

                //MessageBox.Show("投注成功");
            }
            if(lotteTypeSize !=0)//大小
            {
                winBigSamll = $"1~40的數量有{20-winSize()}個 41~80的數量有{winSize()}個\n";
                if(lotteTypeSize ==1)//大
                {
                    playType += $"大 ";
                    if (winSize() >= 13)
                    {
                        winBigSamll += "中了";
                    }
                    else
                    {
                        winBigSamll += "沒中";
                    }
                }
                else//小
                {
                    playType += $"小 ";
                    if (winSize() <= 7)
                    {
                        winBigSamll += "中了";
                    }else
                    {
                        winBigSamll += "沒中";
                    }
                }
            }
            if(lotteTypeEven !=0)//單雙
            {
                winEvenSingle = $"單數數量有{20-winEven()}個 雙數數量有{winEven()}個\n";
                if (lotteTypeEven ==1) //單
                {
                    playType += $"單 ";                    
                    if(winEven() >= 7)
                    {
                        winEvenSingle += "中了";
                    }
                    else
                    {
                        winEvenSingle += "沒中";
                    }
                }
                else
                {
                    playType += $"雙 ";
                    if (winEven() <= 13)
                    {
                        winEvenSingle += "中了";
                    }
                    else
                    {
                        winEvenSingle += "沒中";
                    }
                }
            }
            lotteTypeStar = 0;
            lblWinning.Text = $"{playType}\n{winNumber}\n\n{winBigSamll}\n\n{winEvenSingle}";
            lotteClear();
            //if (lotteType <= 10)
            //{
            //    if (lotteType == 0)
            //    {
            //        MessageBox.Show("請選擇玩法");
            //    }
            //    else
            //    {
            //        MessageBox.Show("投注號碼數目不正確");
            //    }
            //}
            //else
            //{
            //    testLotte();
            //    switch (lotteType)
            //    {
            //        case 11:
            //            int singleNumber = 20 - winEven();
            //            if(singleNumber>=13)
            //            {
            //                lblWinning.Text= $"單號數量{singleNumber}個 中獎了";
            //            }
            //            break;
            //        case 12:
            //            int evenNumber = winEven();
            //            if (evenNumber >= 13)
            //            {
            //                lblWinning.Text = $"雙號數量{evenNumber}個 中獎了";
            //            }
            //            else
            //            {
            //                lblWinning.Text = $"雙號數量{evenNumber}個 沒有中獎";
            //            }
            //            break;
            //        case 13:

            //            break;
            //        case 14:

            //            break;
            //        case 108:
            //            int winNumber = winStar();
            //            if(winNumber>=4)
            //            {

            //            }
            //            else
            //            {
            //                lblWinning.Text += "\n沒有中獎";
            //            }

            //            break;
            //        case 109:

            //            break;
            //        case 110:

            //            break;
        //    lotteType = 0;
        //}
        }
        
            
        
       
        //myMethods
        bool betConfirm(int x,string myTxt)
        {
            bool betConfirm = false;
            try
            {
                int myNumber = Convert.ToInt32(myTxt);                
                if (myNumber<1||myNumber>80)
                {
                    Array.Clear(betArray, 0, 10);
                    MessageBox.Show("請輸入1~80數字");
                    betConfirm = true;
                    return betConfirm;
                }
                if(Array.IndexOf(betArray,myNumber)!=-1)
                {
                    betConfirm = true;
                    return betConfirm;
                }
                betArray[x] = myNumber;
            }
                catch
            {
                betConfirm = true;
                Array.Clear(betArray, 0, 10);
                MessageBox.Show("輸入錯誤,請重新輸入");
                return betConfirm;
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
        void lotteRandom()
        {
            Random numberRandom = new Random();
            for(int i = 0; i<=lotteArray.Length-1;i++)
            {
                int x = numberRandom.Next(1, 81);
                if (Array.IndexOf(lotteArray,x) ==-1) 
                {
                    lotteArray[i] = x;
                }
                else
                {
                    i -= 1;
                }
            }
            supLotteNumber = lotteArray[19];
            Array.Sort(lotteArray);
            foreach(int i in lotteArray)
            {
                lblLottoNumbers.Text += string.Format($"{i:D2} ");
            }
        }
        string[] winStar()
        {
            string[] myArray = new string[2];
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
            myArray[0] = Convert.ToString(myWinning);
            myArray[1] = winNumber;            
            return myArray;
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
            txtBetNuber1.Text = null;
            txtBetNuber2.Text = null;
            txtBetNuber3.Text = null;
            txtBetNuber4.Text = null;
            txtBetNuber5.Text = null;
            txtBetNuber6.Text = null;
            txtBetNuber7.Text = null;
            txtBetNuber8.Text = null;
            txtBetNuber9.Text = null;
            txtBetNuber10.Text = null;
            btnBet.Enabled = false;
            btnLottery.Enabled = false;
            btnBet10.Enabled = true;
            btnBet9.Enabled = true;
            btnBet8.Enabled = true;
            btnBig.Enabled = true;
            btnSmall.Enabled = true;
            btnEven.Enabled = true;
            btnSingle.Enabled = true;
            Array.Clear(lotteArray, 0, 20);
            Array.Clear(betArray, 0, 10);
        }
    }
}
