using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //if() ... else 條件判斷式
            int x = 40;
            int y = 20;

            //z = y >= 20 && x == 40 || y > 10;
            //Console.WriteLine(z);

            if(x>y) //輸入關係運算式
                { //true執行結果
                Console.WriteLine("x>y");
                }
            else
                { //false執行結果
                Console.WriteLine("x<=y");
                }
            

            if (x>y)
            {
                Console.WriteLine("x>y");
            }
            else
            {
                if (x==y)
                {
                    Console.WriteLine("x=y");
                }
                else
                {
                    Console.WriteLine("x<y");
                }
            }
            Console.WriteLine("---------------------");

            //if()... else if()
            if(x==y)
            {
                Console.WriteLine("x=y");
            }
            else if(x>y)
            {
                Console.WriteLine("x>y");
            }
            else if (x<y)
            {
                Console.WriteLine("x<y");
            }
            else
            {
                Console.WriteLine("不存在");
            }
            //else if 下的條件不能重疊
            Console.WriteLine("---------------------");
            //if...else 簡式
            int w = -3;
            int s = 6;
            string SS;
            if(w<0)
            {
                s = -1;
            }
            else
            {
                s = w * 2;
            }
            Console.WriteLine("s:" + s);

            s = (w < 0) ? -1 : (w * 2);
            //  if條件式  執行  else執行
            SS = (w < 0) ? "w<0" : "w>=0";
            Console.WriteLine("簡式 s:" + s);
            Console.WriteLine(SS);
            Console.WriteLine("---------------------");
            Console.WriteLine("甜點選擇:(代號a: 布丁,b: 冰淇淋, c:奶酪, d紅豆湯");
            Console.WriteLine("輸入完成請按Enter");
            string ss = Console.ReadLine();

            switch(ss)
            {
                case "a":
                    Console.WriteLine("您選了布丁 60元");
                    break;
                case "b":
                    Console.WriteLine("您選了冰淇淋 80元");
                    break;
                case "c":
                    Console.WriteLine("您選了奶酪 100元");
                    break;
                case "d":
                    Console.WriteLine("您選了紅豆湯 70元");
                    break;
                default:
                    Console.WriteLine("無此產品");
                    break;
            }


            Console.WriteLine("---------------------");
            Console.WriteLine("按下任意鍵結束");
            Console.ReadKey();
        }
    }
}
