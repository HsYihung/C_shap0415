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

            int hight_t = Console.Read();



            if(hight_t <= 70 && hight_t>=20)
            {
                int hight_t1 = (hight_t-6-5)/4 ;
                int hight_t2 = (hight_t-6-5)%4 ;

                for(int i =1;i<=11;i+=2)//樹梢繪製
                {
                    for(int j = 11; j>=i; j-=2)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 1;k<=i;k++)
                    {
                        if(i==1)
                        {
                            Console.Write("*");
                            break;
                        }
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                //for(int i = 1; i<=hight_t1;i++ )//樹葉繪製次數
                {
                    for(int j = 4; j <=12;j+=2)//樹葉繪製
                    {
                        for(int k = 12; k>=j;k-=2)
                        {
                            Console.Write(" ");
                        }

                        for(int m = 1; m<=j; m++)
                        {
                            if(j==4)
                            {
                                Console.Write("****");
                                break;
                            }
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                /*for(int i =1; i<=5+hight_t2; i++ )//樹幹繪製
                {
                    for(int j = 1; j<=3;j++)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 1; k<=3;k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }*/
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
