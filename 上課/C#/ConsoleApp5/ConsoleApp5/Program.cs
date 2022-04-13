using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop 迴圈示範
            for(int i =1; i<=20; i+=1)
            {
                Console.WriteLine($"i:{i}");
            }

            Console.WriteLine("----------------------");

            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine($"i:{i}");
            }

            Console.WriteLine("----------------------");
            //輸出 10...1

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine($"i:{i}");
            }
            Console.WriteLine("----------------------");
            for (int i = 1; i <= 20; i += 1)
            {
                if(i>9)
                {
                    break;//中斷迴圈
                }
                Console.WriteLine($"i:{i}");
            }
            Console.WriteLine("----------------------");
            for (int i = 1; i <= 20; i += 1)
            {
                if (i >8&&i<13)
                {
                    continue;
                }
                Console.WriteLine($"i:{i}");
            }
            Console.WriteLine("----------------------");

            for (int i = 1; i <= 10; i+=1)
            {
                for(int j = 1 ; j<= 10; j+=1)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("----------------------");
            for (int i = 1; i <= 21; i += 2)
            {
                for (int k = 19; k >= i; k -= 2)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j += 1)
                {
                    if (i == 1)
                    {
                        Console.Write("*");
                        break;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");
            for (int i = 1; i<=21; i +=2)
            {
                for (int k = 19; k >= i; k -=2)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j += 1)
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
            for (int i = 1 ; i <= 19; i += 2) 
            {
                for (int k = 1; k <= i; k += 2)
                {
                    Console.Write(" ");
                }
                for( int j = 19; j>=i;j-- )
                {
                    if(i==19)
                    {
                        Console.Write("*");
                        break;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");

            int i_max = 21;

            for (int i = 1; i <= i_max; i += 2)
            {
                for (int k = 19; k >= i; k -= 2)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j += 1)
                {
                    if (i == 1)
                    {
                        Console.Write("*");
                        break;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            } 



            Console.WriteLine("----------------------");
            for (int i = 1; i <= 9; i++) 
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i} x {j} = {i*j}  ");
                    if(j*i<10)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            // 練習: 輸出 等腰三角形 , 菱形
            // 課程作業加分題: 請輸出聖誕樹 彩色 有裝飾(可任意輸入聖誕樹高度)

            Console.WriteLine("----------------------");
            Console.WriteLine("按下任意鍵結束");
            Console.ReadKey();
        }
    }
}
