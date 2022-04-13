using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrray 陣列
            int[] arrayOne = new int[6];
            arrayOne[0] = 1;
            arrayOne[1] = 2;
            arrayOne[2] = 3;
            arrayOne[3] = 4;
            arrayOne[4] = 5;
            arrayOne[5] = 6;
           
            Console.WriteLine($"arrayOne取出索引值為3的元素內容為{arrayOne[3]}");

            arrayOne[4] = 88;
            Console.WriteLine($"arrayOne取出索引值為4的元素內容為{arrayOne[4]}");

            int[] arrayTwo = new int[] { 6, 5, 4, 3, 2, 1 };
            int[] arrayTree = { 7, 8, 9, 10, 11, 12 };

            Console.WriteLine($"arrayTree取出索引值為4的元素內容{arrayTree[4]}");

            Console.WriteLine("------------------------------");

            for(int i = 0; i<=5; i+=1)
            {
                Console.WriteLine($"arrayOne[{i}] = {arrayOne[i]} ");
            }

            Console.WriteLine("------------------------------");

            string[] array科目名稱 = { "國文", "數學", "英文", "自然", "社會" };

            Console.WriteLine("array科目名稱[{0}] = {1} ",1,array科目名稱[1]);

            for(int i = 0; i < array科目名稱.Length ; i++)
            {
                Console.WriteLine($"array科目名稱[{i}] = {array科目名稱[i]}");
            }
            Console.WriteLine("------------------------------");

            foreach (string subject in array科目名稱)//陣列專用迴圈 自動遍歷陣列 或集合所有索引值
            {
                Console.WriteLine(subject);
            }
            Console.WriteLine("------------------------------");
            //2維陣列 , Two Dimesion Array, Dim
            int[,] array2D_One = new int[4, 2];
            array2D_One[0, 0] = 8;
            array2D_One[0, 1] = 7;
            array2D_One[1, 0] = 6;
            array2D_One[1, 1] = 5;
            array2D_One[2, 0] = 4;
            array2D_One[2, 1] = 3;
            array2D_One[3, 0] = 2;
            array2D_One[3, 1] = 1;

            int[,] array2D_Two = { { 8, 7 }, { 6, 5 }, { 4, 3 }, { 2, 1 } };

            for(int i = 0; i <= array2D_One.GetUpperBound(0);i++)///GetUpperBound()取得某維度的索引值上限起始為0
            {
                
                for(int j=0; j<= array2D_One.GetUpperBound(1);j++)
                {
                    Console.WriteLine(array2D_One[i, j]);
                }
                
            }
            Console.WriteLine("------------------------------");
            //三維陣列
            int[,,] array3D = new int[2, 3, 4]
            {
                {
                    {1,2,3,4 },
                    {5,6,7,8 },
                    {9,10,11,12 },
                },
                {
                    {13,14,15,16 },
                    {17,18,19,20 },
                    {21,22,23,24 }
                }
            };

            for(int i = 0;i<=array3D.GetUpperBound(0);i++)
            {
                for(int j=0;j<=array3D.GetUpperBound(1);j++)
                {
                    for(int k=0;k<=array3D.GetUpperBound(2);k++)
                    {
                        Console.WriteLine($"array3D[{i},{j},{k}]={ array3D[i, j, k]}");
                    }
                }
            }

            Console.WriteLine("------------------------------");

            Console.WriteLine("請輸入搜尋科目功能(輸入完成按Enter):");
            string str搜尋科目 = Console.ReadLine();
            bool is有這科目 = false;
                
            str搜尋科目 = Console.ReadLine();
                
            for (int k = 0; k <= array科目名稱.GetUpperBound(0); k += 1)
                
            {
                    
                if (array科目名稱[k] == str搜尋科目)
                    {
                        Console.WriteLine("有此科目:" + array科目名稱[k] + ", index" + k);
                        is有這科目 = true;
                        break;
                    }
                
            }

                
            if (!is有這科目)
                
            {

                Console.WriteLine("找不到這科目");
               
            }


            Console.WriteLine("------------------------------");
            Console.WriteLine("按下任意鍵結束");
            Console.ReadKey();
        }
    }
}
