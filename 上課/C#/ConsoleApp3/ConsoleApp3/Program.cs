using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            int y = 4;
            int z;

            z = x + y;
            z = x - y;
            z = x * y;
            z = x / y;
            z = x % y;
            z = -y;
            z = x + y * y;
            z = (x - y) / y;

            int x2 = 5;
            double y2 = 1.2210;
            double z2;
            z2 = x2 * y2;
            z2 = x2 / y2;



            Console.WriteLine($"z值為 : {z}");
            Console.WriteLine($"z2值為 : {z2}");
            Console.WriteLine("--------------------------------------");
            //指定運算子
            int c = 250;
            int d = 100;
            //c += 3;
            //c = c + 3; //*c += 3 ; c = c+3; 指定c值為c+3
            //c -= 3;
            //c /= 3;
            //c *= 3;
            //c %= 3;
            c += d;


            Console.WriteLine($"c值為 : {c}");
            Console.WriteLine("--------------------------------------");
            //遞增遞減運算子
            int r = 8;
            r++;// r = r+1;
            r--;// r = r-1;
            Console.WriteLine($"r值為 : {r}");
            Console.WriteLine("--------------------------------------");

            //關係運算子
            double m = 85.23;
            double n = 45.64;
            bool compare;
            compare = m == n;
            compare = m != n;
            compare = m > n;
            compare = m >= n;
            compare = m < n;


            Console.WriteLine("compare : " + compare);
            Console.WriteLine("--------------------------------------");

            //條件運算子
            float p = 56.78f;
            float w = 92.31f;
            bool logic;

            logic = p < w && p >= 50.0f;//AND
            logic = p > 60.0f && p != w;
            logic = w <= 80.0f || p <= w;
            logic = w < 20.0f || p > w;
            logic = p > 40.0f && w < 120f && p == w;
            logic = p > 40.0f || w < 10.0f && p == w; //先比對後值
            logic = !(p > 20.0f || w < 50.0f) && p < w;
            logic = !(w < p);//not 結果為相反


            Console.WriteLine($"logic : {logic}");
            Console.WriteLine("--------------------------------------");






            Console.WriteLine("按下任意鍵結束");
            Console.ReadKey();
        }
    }
}
