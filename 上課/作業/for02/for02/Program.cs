using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入聖誕樹高度,最低25");
            string strInput = Console.ReadLine();
            int tHight = Convert.ToInt32(strInput);

            if (tHight>=25)
            {
                int tHight_1 = tHight / 4;
                int tHight_2 = tHight / 4;
                int tHight_3 = tHight / 4 + tHight % 4;
                int tWidth_1 = tHight_1 / 3;//4:12
                int tWidth_2 = tHight_1 / 2;//6:12
                int tWidth_3 = (tHight_1 * 5) / 6;//5:12
                int hightlog = 0;
                int tHight_11 = 1;
                int tHight_22 = 1;
                if (tWidth_3 % 2 == 0)
                {
                    tWidth_3 -= 1;
                }
                if (tHight_1 % 3 != 0)
                {
                    hightlog += 1;
                }
                if (tHight_1 % 2 != 0)
                {
                    hightlog += 1;
                }
                if (tHight_1 * 5 % 6 != 0)
                {
                    hightlog += 1;
                }
                if (hightlog == 0)
                {
                    tHight_11 = 0;
                }
                else if (hightlog == 1)
                {
                    tWidth_2 += 1;
                }
                else if (hightlog == 3)
                {
                    tWidth_1 += 1;
                    tWidth_2 += 1;
                    tHight_11 = 0;
                    tHight_22 = 0;
                }


                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 1; i <= tHight_1 * 2; i += 2)//樹梢繪製
                {
                    for (int j = tHight_1 * 2 + tWidth_1 * 2 - 2; j >= i; j -= 2)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        if (i == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("*");
                            break;
                        }

                        if (i / 2 % 3 == 1 && k % 5 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        if (i / 2 % 3 == 1 && k % 5 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        if (i / 2 % 3 == 1 && k % 5 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = tWidth_3; i <= tHight_2 * 2 + tWidth_1 * 2; i += 2)//樹葉繪製1
                {
                    for (int j = (tHight_1 * 2) + (tWidth_2 * 2); j > i + tWidth_1 + tHight_22; j -= 2)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        if (i == tWidth_3)
                        {
                            for (int m = 1; m <= i; m++)
                            {
                                Console.Write("*");
                            }
                            break;
                        }
                        if ((i - tWidth_3) / 2 % 3 == 1 && k % 5 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        if ((i - tWidth_3) / 2 % 3 == 1 && k % 5 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        if ((i - tWidth_3) / 2 % 3 == 1 && k % 5 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = tWidth_3; i <= tHight_2 * 2 + tWidth_1 * 2; i += 2)//樹葉繪製2
                {
                    for (int j = (tHight_1 * 2) + (tWidth_2 * 2); j > i + tWidth_1 + tHight_22; j -= 2)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        if (i == tWidth_3)
                        {
                            for (int m = 1; m <= i; m++)
                            {
                                Console.Write("*");
                            }
                            break;
                        }
                        if ((i - tWidth_3) / 2 % 3 == 1 && k % 5 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        if ((i - tWidth_3) / 2 % 3 == 1 && k % 5 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        if ((i - tWidth_3) / 2 % 3 == 1 && k % 5 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int i = 1; i <= tHight_3; i++)//樹幹繪製
                {

                    for (int j = 1; j <= tWidth_1 + tWidth_2 + tHight_11; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= tWidth_3; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("輸入錯誤");
            }

            Console.ResetColor();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("按任意鍵結束");
            Console.ReadKey();
        }
    }
}
