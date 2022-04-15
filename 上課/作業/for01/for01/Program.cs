using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for01
{
    class Program
    {
        static void Main(string[] args)
        {
            //聖誕樹迴圈練習

            string strInput = Console.ReadLine();
            int hight_t = Convert.ToInt32(strInput);

            if(hight_t <= 71 && hight_t>=23)
            {
                hight_t = hight_t-11;
                int hight_t1 = hight_t/6  ;
                int hight_t2 = hight_t % 4;

                Console.ForegroundColor = ConsoleColor.Green;
                for (int i =1;i<=11;i+=2)//樹梢繪製
                {
                    for(int j = 13; j>=i; j-=2)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 1;k<=i;k++)
                    {
                        if(i==1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("*");
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        }
                        if(i==5 && k==1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (i == 5 && k == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (i == 9 && (k==1|| k == 9))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (i == 9 && k == 5 )
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine();
                }
                for(int i = 1; i<=hight_t1;i++ )//樹葉繪製次數
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    for(int j = 5; j <=15;j+=2)//樹葉繪製
                    {
                        for(int k = 13; k>=j;k-=2)
                        {
                            Console.Write(" ");
                        }

                        for(int m = 1; m<=j; m++)
                        {
                            if(j==5)
                            {
                                Console.Write("*****");
                                break;
                            }


                            if(j==7&&(m==1||m==j))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }

                            if(j==7&&m==j/2+1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            if(j == 11 && (m == 1 || m == j))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            if(j==11 &&m==j / 2 - 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            if (j == 11 && m == j / 2 + 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            if (j == 15 && m == j / 2 - 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (j == 15 && m == j / 2 +1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }

                            if (j == 15 && m == j / 2 + 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            if (j == 15 && (m == 1 || m == j))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }

                            Console.Write("*");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.WriteLine();
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                for(int i =1; i<=5+hight_t2; i++ )//樹幹繪製
                {
                    for(int j = 1; j<=5;j++)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 1; k<=5;k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("高度值輸入錯誤");
            }

            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }
    }
}
