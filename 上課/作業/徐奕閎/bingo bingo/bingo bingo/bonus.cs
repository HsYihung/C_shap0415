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
    class bonus
    {
        int playType_1;
        int playType_2;
        int playType_3;
        public bool even;
        public bool size;
        public int winNum;
        public bool supNum;
        public string winNum1;
        int mult;

        public bonus(int a, int b , int c)
        {
            playType_1 = a - 100;
            playType_2 = b;
            playType_3 = c;
            even = false;
            size = false;
            supNum = false;
            mult = 1;
        }

        void multiple()
        {
            if(playType_1!=0)
            {
                switch (playType_1)
                {
                    case 10:
                        switch (winNum)
                        {
                            case 10:
                                if(supNum)
                                {
                                    mult*= 500000;
                                }
                                else
                                {
                                    mult *= 200000;
                                }
                                break;
                            case 9:
                                if (supNum)
                                {
                                    mult *= 25000;
                                }
                                else
                                {
                                    mult *= 10000;
                                }
                                break;
                            case 8:
                                if (supNum)
                                {
                                    mult *= 2500;
                                }
                                else
                                {
                                    mult *= 1000;
                                }
                                break;
                            case 7:
                                if (supNum)
                                {
                                    mult *= 250;
                                }
                                else
                                {
                                    mult *= 100;
                                }
                                break;
                            case 6:
                                if (supNum)
                                {
                                    mult *= 30;
                                }
                                else
                                {
                                    mult *= 10;
                                }
                                break;
                            case 5:
                                if (supNum)
                                {
                                    mult *= 3;
                                }
                                else
                                {
                                    mult *= 1;
                                }
                                break;
                            default:
                                if (supNum)
                                {
                                    mult *= 1;
                                }
                                else
                                {
                                    mult *= 0;
                                }
                                break;
                        }
                        break;
                    case 9:
                        switch (winNum)
                        {
                            case 9:
                                if (supNum)
                                {
                                    mult *= 100000;
                                }
                                else
                                {
                                    mult *= 40000;
                                }
                                break;
                            case 8:
                                if (supNum)
                                {
                                    mult *= 10000;
                                }
                                else
                                {
                                    mult *= 4000;
                                }
                                break;
                            case 7:
                                if (supNum)
                                {
                                    mult *= 300;
                                }
                                else
                                {
                                    mult *= 120;
                                }
                                break;
                            case 6:
                                if (supNum)
                                {
                                    mult *= 50;
                                }
                                else
                                {
                                    mult *= 20;
                                }
                                break;
                            case 5:
                                if (supNum)
                                {
                                    mult *= 10;
                                }
                                else
                                {
                                    mult *= 4;
                                }
                                break;
                            case 4:
                                if (supNum)
                                {
                                    mult *= 3;
                                }
                                else
                                {
                                    mult *= 1;
                                }
                                break;
                            default:
                                if (supNum)
                                {
                                    mult *= 1;
                                }
                                else
                                {
                                    mult *= 0;
                                }
                                break;
                        }
                        break;
                    case 8:
                        switch (winNum)
                        {
                            case 8:
                                if (supNum)
                                {
                                    mult *= 50000;
                                }
                                else
                                {
                                    mult *= 20000;
                                }
                                break;
                            case 7:
                                if (supNum)
                                {
                                    mult *= 2000;
                                }
                                else
                                {
                                    mult *= 800;
                                }
                                break;
                            case 6:
                                if (supNum)
                                {
                                    mult *= 100;
                                }
                                else
                                {
                                    mult *= 40;
                                }
                                break;
                            case 5:
                                if (supNum)
                                {
                                    mult *= 20;
                                }
                                else
                                {
                                    mult *= 8;
                                }
                                break;
                            case 4:
                                if (supNum)
                                {
                                    mult *= 3;
                                }
                                else
                                {
                                    mult *= 1;
                                }
                                break;
                            default:
                                if (supNum)
                                {
                                    mult *= 1;
                                }
                                else
                                {
                                    mult *= 0;
                                }
                                break;
                        }
                        break;
                }
                    
            }
            if (playType_2 != 0)
            {
                if(size)
                {
                    mult *= 6;
                }
                else
                {
                    mult *= 0;
                }

            }
            if (playType_3 != 0)
            {
                if (even)
                {
                    mult *= 6;
                }
                else
                {
                    mult *= 0;
                }
            }
            
        }
        
        public void 顯示獎金()
        {
            multiple();
            string x = string.Format("{0:C}", 25 * mult);
            MessageBox.Show($"中獎金額:{x}元");
        }
    }
}
