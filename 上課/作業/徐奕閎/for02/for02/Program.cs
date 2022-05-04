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
            Console.WriteLine("請輸入聖誕樹高度,最低20");
            string strInput = Console.ReadLine();            
            try
            {
                int tHight = Convert.ToInt32(strInput);

                if (tHight >= 20)
                {
                    int tHight_1 = tHight / 4;
                    int tHight_3 = tHight / 4 + tHight % 4;
                    int tWidth_1 = tHight_1 / 3;//4:12                    
                    int tWidth_3 = (tHight_1 * 5) / 6;//5:12
                    if (tWidth_3%2==0)
                    {
                        tWidth_3 += 1;
                    }
                    tWidth_1 += (tWidth_3+tHight_1*2)/2-(tHight_1 + tWidth_1);

                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 1; i <= tHight_1; i += 1)//樹梢繪製
                    {
                        for (int j = tHight_1+tWidth_1*2; j > i; j -= 1)
                        {
                            Console.Write(" ");
                        }
                        int kMax = i * 2 - 1;
                        for (int k = 1; k <= kMax; k++)
                        {
                            //if(i==1)
                            //{
                            //    Console.ForegroundColor = ConsoleColor.Yellow;
                            //}
                            if (i % 2 == 1 && k == kMax / 2 + 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            if (k <= kMax/2)
                            {
                                if (i % 2 == 1 && k % 5 == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }
                                if (i % 2 == 1 && k % 5 == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                if (i % 2 == 1 && k % 5 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }
                            }
                            if (k > kMax / 2+1)
                            {
                                if (i % 2 == 1 && (kMax-k+1) % 5 == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }
                                if (i % 2 == 1 && (kMax - k+1) % 5 == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                if (i % 2 == 1 && (kMax - k+1) % 5 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }
                            }
                            Console.Write("*");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.WriteLine();
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 1; i <= tHight_1; i += 1)//樹葉繪製1
                    {
                        for (int j =tWidth_1*2+tHight_1-tWidth_3/2-1; j >= i; j -=1 )
                        {
                            Console.Write(" ");
                        }
                        int kMax = tWidth_3 + (i - 1) * 2;
                        for (int k = 1; k <= kMax; k++)
                        {
                            if (i % 2 == 1 && k == kMax / 2+1)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            if (k <= kMax / 2)
                            {
                                if (i % 2 == 1 && k % 5 == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }
                                if (i % 2 == 1 && k % 5 == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                if (i % 2 == 1 && k % 5 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }
                            }
                            if (k > kMax / 2 + 1)
                            {
                                if (i % 2 == 1 && (kMax - k + 1) % 5 == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }
                                if (i % 2 == 1 && (kMax - k + 1) % 5 == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                if (i % 2 == 1 && (kMax - k + 1) % 5 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }
                            }

                            Console.Write("*");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.WriteLine();
                    }
                for (int i = 1; i <= tHight_1; i += 1)//樹葉繪製2
                {
                    for (int j = tWidth_1 + tHight_1 - tWidth_3 / 2 - 1; j >= i; j -= 1)
                    {
                        Console.Write(" ");
                    }
                    int kMax = tWidth_3 + (i - 1) * 2 + tWidth_1 * 2;
                    for (int k = 1; k <= kMax; k++)
                    {
                            if (i % 2 == 1 && k == kMax / 2 + 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            if (k <= kMax / 2)
                            {
                                if (i % 2 == 1 && k % 5 == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }
                                if (i % 2 == 1 && k % 5 == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                if (i % 2 == 1 && k % 5 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }
                            }
                            if (k > kMax / 2 + 1)
                            {
                                if (i % 2 == 1 && (kMax - k + 1) % 5 == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }
                                if (i % 2 == 1 && (kMax - k + 1) % 5 == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                if (i % 2 == 1 && (kMax - k + 1) % 5 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }
                            }

                            Console.Write("*");
                            Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine();
                }

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    for (int i = 1; i <= tHight_3; i++)//樹幹繪製
                    {

                        for (int j = 1; j <= tWidth_1*2 + tHight_1 - tWidth_3 / 2 - 1; j++)
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
            }
            catch (Exception error)
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
