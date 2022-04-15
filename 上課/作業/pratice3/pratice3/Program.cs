using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 便當選單 , 輸入便當名稱 , 告訴使用者有沒有販售 , 此便當多少錢
            // 建立二維string陣列 , 儲存便當名稱跟價格 , 做搜尋
            // 至少有十種便當 , string[20,2]

            string[,] bangAtring =
            {
                {"雞腿便當","80元" },
                {"排骨便當","70元" },
                {"滷雞腿便當","75元" },
                {"叉燒便當","90元" },
                {"炸排骨便當","85元" },
                {"虱目魚肚便當","100元" },
                {"宮保雞丁便當","75元" },
                {"三杯雞便當","75元" },
                {"香烤雞翅便當","80元" },
                {"糖醋排骨便當","95元" }
            };

            while (true)
            {
                bool boolInput = true;
                Console.Clear();
                Console.WriteLine("請輸入想搜尋的便當名稱或輸入x退出 輸入f列出全部便當");
                string strInput = Console.ReadLine();
                if (strInput != "")
                {
                    if (strInput == "x")
                    {
                        break;
                    }
                    if (strInput == "f")
                    {
                        for(int i = 0; i <=9;i++)
                        {
                            Console.WriteLine(bangAtring[i,0] );
                        }
                        Console.WriteLine("請輸入便當名稱");
                        strInput = Console.ReadLine();
                    }
                    for (int i = 0; i <= 9; i++)
                    {
                        if (bangAtring[i, 0] == strInput)
                        {
                            Console.WriteLine($"{bangAtring[i, 0]}  , {bangAtring[i, 1]}");
                            Console.WriteLine("按下任意鍵繼續");
                            Console.ReadKey();
                            boolInput = false;
                            break;
                        }
                    }
                    if (boolInput)
                    {
                        Console.WriteLine("查無此便當");
                        Console.WriteLine("按下任意鍵繼續");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("請重新輸入便當名稱");
                    Console.WriteLine("按下任意鍵繼續");
                    Console.ReadKey();
                }
            }

            

            Console.WriteLine("輸入任意鍵結束");
            Console.ReadKey();
        }
    }
}
