using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 變數 Variable 的宣告
            short a;
            // 宣告變數a為short #short為16位元整數
            a = 2000;
            // 指定變數a值為2000
            int amount = 2000000;//int 32位元整數
            long count = 2000000000000;//long 64位元整數

            ushort ua = 40000;//ushort 無正負short整數
            uint uamount = 400000000;//uint 無正負int整數
            ulong ucount = 4000000000000000;//ulong 無正負long整數


            Console.WriteLine("整數的宣告");
            Console.WriteLine(a);
            Console.WriteLine(amount);
            Console.WriteLine(count);
            Console.WriteLine(ua);
            Console.WriteLine(uamount);
            Console.WriteLine(ucount);

            //浮點數
            float aveage = 888.23f;
            //宣告變數avege為float #float浮點數數字後須加上f

            double pi = 3.141592;
            //宣告變數pi為double #double 精確度小數點16位

            Console.WriteLine("平均 : "+aveage);
            Console.WriteLine("圓周率 : " + pi);

            //布林 Boolean

            bool isSuccess = true;
            //宣告 isSuccess 為bool變數 數值為 true
            bool isFinish = false;

            Console.WriteLine("是否成功" + isSuccess);
            //WriteLine() + 為字串結合運算子 , + 非字串變數轉為字串
            Console.WriteLine("是否完成" + isFinish);

            //字串 string
            //字串為字元集合

            string name = "王大衛";
            string 電話 = "0912-345-678";
            string email = "test@mmm.com";
            Console.Write("姓名:");
            Console.Write(name);
            Console.Write(", 電話:" + 電話);
            Console.Write(", email:" + email+"\n");

            //字元 char
            char myCharOne = 'x';
            char myChartwo = '微';
            Console.WriteLine("字元輸出 : "+myCharOne+myChartwo);

            //字串插入, 字串插值
            Console.WriteLine("姓名:{0} ,電話:{1} ,Email:{2} ,年齡:{3}",name,電話,email,20);
            // {0} 0為插入字串編號,輸入索引值編號以 , 分割,將非字串數值或變數轉為字串輸出

            //變數插入
            Console.WriteLine($"姓名:{name} ,電話:{電話} ,Email:{email} ,年齡{20}");
            //$" {} " 輸入雙引號前加入$ {}內可輸入數值或變數 結果轉為字串輸出

            Console.WriteLine("\n按任意鍵結束");
            Console.ReadKey();

        }
    }
}
