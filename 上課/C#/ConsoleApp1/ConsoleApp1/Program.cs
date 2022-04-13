using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 單行註解
            /*
              多行註解
             */
            System.Console.WriteLine("Hello World !!");
            System.Console.WriteLine("Hi, 這是第一個Console程式");
            Console.WriteLine("C# 語言第一個示範");
            //WriteLine 輸出字串後換行
            //Write 輸出字串不換行
            Console.WriteLine("C# Demo");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //ForgeroundColor 主控台程式字體顏色 *Console的屬性 
            Console.BackgroundColor = ConsoleColor.Blue;
            //BackgroundColor 主控台背景顏色
            Console.WriteLine("1. 主控台應用程式");
            Console.WriteLine("2. Windows Form 應用程式");
            Console.WriteLine("3. Web 應用程式");
            Console.WriteLine();

            Console.ResetColor();
            //ResetColor 恢復預設顏色
            Console.WriteLine("特殊字元符號");
            Console.WriteLine("\"雙引號\"");
            // \ 後可輸出特殊字符
            Console.WriteLine("\\反斜線\\");
            Console.WriteLine("\'單引號\'");
            Console.WriteLine("\t縮排");
            // \t 輸出縮排(四個字元)
            Console.WriteLine("\n換行\n");
            // \n 換行

            Console.WriteLine("按Enter結束程式");


            System.Console.ReadLine();
        }
    }
}
