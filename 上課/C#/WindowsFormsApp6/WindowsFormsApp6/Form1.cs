using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        //類別變數
        List<ArrayList> 員工資料集合 = new List<ArrayList>();
        List<Hashtable> 員工資料集合2 = new List<Hashtable>();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnList_Click(object sender, EventArgs e)
        {
            //List Demo
            List<int> myIntList = new List<int> {1,2,3,4,5,6 };
            List<string> myList = new List<string>();
            myList.Add("red");
            myList.Add("yellow");
            myList.Add("green");
            myList.Add("purple");
            myList.Add("green");

            Console.WriteLine("List Demo");
            Console.WriteLine("==========1==========");
            foreach(string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }
            Console.WriteLine("==========2==========");//修改list
            myList[0] = "darkred";
            myList[2] = "deepblue";
            for(int i = 0;i<myList.Count;i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine("==========3==========");//加入另一個集合List,Array)必須為相同的資料型態
            string[] arrayStringOther = new string[] {"pink","gray","brown"};
            myList.AddRange(arrayStringOther);
            foreach(string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }

            Console.WriteLine("==========4==========");//Insert插入值(插入索引值,插入值) 
            myList.Insert(2,"skyblue");
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }
            Console.WriteLine("==========5==========");//InsertRange 插入集合(插入索引值,插入集合)
            myList.InsertRange(3, arrayStringOther);
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }

            Console.WriteLine("==========6==========");//Remove
            myList.Remove("gray");//Remove移除指定元素  只會移除指定的第一個元素
            
            myList.RemoveAt(3);//RemoveAt 移除指定索引值的元素
            myList.RemoveRange(4, 2);//移除索引值4開始的元素 2個
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }
           

            Console.WriteLine("==========7==========");//sort排序
            myList.Sort();
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }
            Console.WriteLine("==========8==========");//reverse反向排列
            myList.Reverse();            
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }            
            Console.WriteLine("==========9==========");//元素搜尋 IndexOf
            int idx = myList.IndexOf("darkred");
            Console.WriteLine("darkred index "+idx);
            Console.WriteLine("=========10==========");
            string[] myTempArray = myList.ToArray(); //List複製轉換成Array 
            List<string> myListNew = new List<string>(myTempArray);
            myList.Add("111");//Array複製轉換成List 
            myTempArray[1] = "111";
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }
            Console.WriteLine("=====================");
            foreach (string myColorString in myListNew)
            {
                Console.WriteLine(myColorString);
            }
            Console.WriteLine("=====================");
            foreach (string myColorString in myTempArray)
            {
                Console.WriteLine(myColorString);
            }
            Console.WriteLine("=====================");//Clear
            
            myList.RemoveAll(EndsWithSaurus);
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }
            myList.Clear();
            foreach (string myColorString in myList)
            {
                Console.WriteLine(myColorString);
            }
            Console.WriteLine("=====================");

        }
        private static bool EndsWithSaurus(String s)
        {
            return s.ToLower().StartsWith("g");
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=====================");
            ArrayList myPersonInfo = new ArrayList();
            myPersonInfo.Add("王小明");
            myPersonInfo.Add(32000.0);
            myPersonInfo.Add(DateTime.Now);
            myPersonInfo.Add("0912-345-678");
            myPersonInfo.Add("高雄市前金區中正路");
            myPersonInfo.Add(26);//idex:5

            ArrayList myPersonInfo2 = new ArrayList();
            myPersonInfo2.Add("張大書");
            myPersonInfo2.Add(45000.0);
            myPersonInfo2.Add(DateTime.Now);
            myPersonInfo2.Add("0911-333-666");
            myPersonInfo2.Add("台南市東區中華路");
            myPersonInfo2.Add(40);

            員工資料集合.Add(myPersonInfo);
            員工資料集合.Add(myPersonInfo2);
            foreach(ArrayList perInfo in 員工資料集合)
            {
                string 姓名 = Convert.ToString(perInfo[0]);
                double 薪水 = Convert.ToDouble(perInfo[1]);
                DateTime 到職日 = Convert.ToDateTime(perInfo[2]);
                string 電話 = Convert.ToString(perInfo[3]);
                string 地址 = Convert.ToString(perInfo[4]);
                int 年齡 = Convert.ToInt32(perInfo[5]);
                if (姓名 == "王小明")
                { string strMsg = string.Format($"{姓名} {薪水} {到職日:d} {電話} {薪水} {地址} {年齡}");
                    Console.WriteLine(strMsg);
                    break;
                }
                else
                {
                    Console.WriteLine("找不到資料");
                }
            }
            Console.WriteLine("=====================");
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=====================");
            Dictionary<string, int> dictScore = new Dictionary<string, int>();
            dictScore.Add("王小明",84);
            dictScore.Add("陳大貓", 72);
            dictScore.Add("李瑪莉", 69);
            dictScore["陳大貓"]=76;
            dictScore["張大書"] = 78;

            Console.WriteLine($"李瑪莉分數 : {dictScore["李瑪莉"]}");

            dictScore.Remove("王小明");

            foreach(KeyValuePair<string,int> myDict in dictScore)
            {
                Console.WriteLine($"key: {myDict.Key}, value :{myDict.Value}");
            }

            if(dictScore.ContainsKey("陳大貓"))
            {
                Console.WriteLine($"陳大貓 :{dictScore["陳大貓"]}");
            }
            else
            {
                Console.WriteLine("查無此人");
            }
            Console.WriteLine("=====================");
            Dictionary<string, string> stockCode = new Dictionary<string, string>()
            {
                {"AAPL","蘋果公司" },
                {"AMZN","亞馬遜公司" },
                {"TSLA","特斯拉公司" }
            };

            for (int i = 0; i < stockCode.Count; i+=1)
            {
                Console.WriteLine($"key :{stockCode.ElementAt(i).Key} , value :{stockCode.ElementAt(i).Value}");
            }

            Console.WriteLine("=====================");
            dictScore.Clear();
            Console.WriteLine("dictSore count:" + dictScore.Count);
            Console.WriteLine("=====================");
        }

        private void btnHashtable_Click(object sender, EventArgs e)
        {
            Hashtable membcrInfo = new Hashtable()//***排序由演算法產生
            {
                {"姓名","王大衛" },
                {"年齡",30 },
                {"身高",170.5 },
                { "電話","0912-555-888" },                
            };
            membcrInfo.Add("Email","testWang@test.com");
            membcrInfo["電話"] = "0988-999-111";
            membcrInfo["地址"] = "高雄市新興區";
            membcrInfo.Remove("身高");

            foreach(DictionaryEntry element in membcrInfo)
            {
                Console.WriteLine($"key :{element.Key}, value :{element.Value}");
            }
            if(membcrInfo.ContainsKey("電話"))
            {
                Console.WriteLine($"電話 :{membcrInfo["電話"]}");
            }    
            else
            {
                Console.WriteLine("無此欄位");
            }
            Console.WriteLine("=====================");
            string name = Convert.ToString(membcrInfo["姓名"]);
            int age = Convert.ToInt32(membcrInfo["年齡"]);
            string email = Convert.ToString(membcrInfo["Email"]);

            Console.WriteLine($"姓名 :{name} 年齡:{age} email:{email}");

            員工資料集合2.Add(membcrInfo);
            foreach(Hashtable myMembcrInfo in 員工資料集合2)
            {
                string myName = Convert.ToString(myMembcrInfo["姓名"]);
                int myAge = Convert.ToInt32(myMembcrInfo["年齡"]);
                string myEmail = Convert.ToString(myMembcrInfo["Email"]);

                Console.WriteLine($"姓名 :{myName} 年齡:{myAge} email:{myEmail}");
            }
            Console.WriteLine("=====================");
            Hashtable stockCode2 = new Hashtable()
            {
                {"AAPL","蘋果公司" },
                {"AMZN","亞馬遜公司" },
                {"TSLA","特斯拉公司" }
            };
            foreach(DictionaryEntry myStockCode in stockCode2)
            {
                Console.WriteLine($"{myStockCode.Key} , {myStockCode.Value}");
            }
            stockCode2.Clear();
            Console.WriteLine("count :" + stockCode2.Count);
        }

        private void btnSting進階_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=====================");

            string strA = "string on \n string one";
            string strB = @"c:\windows\notes\test.txt";//前面加上@ 忽略特殊符號字元

            Console.WriteLine(strA);
            Console.WriteLine(strB);

            string strOne = "Hello World !! C# String World.";
            Console.WriteLine("字串長度 :"+ strOne.Length);
            
            int index = strOne.IndexOf("World");//搜尋此字串起始位置的索引值
            Console.WriteLine("World 第一個起始字元的index :" + index);

            string strTwo = strOne.Insert(6, "Hi ");//回傳更改後的值 ,strOne不更改
            Console.WriteLine(strOne);
            Console.WriteLine(strTwo);
            string strThree = strOne.Remove(6);//刪除索引值6以後的所有字元
            Console.WriteLine(strThree);
            string strFour = strOne.Remove(6, 3);//刪除索引值3以後的三個字元
            Console.WriteLine(strFour);
            string strFive = strOne.Replace("World","Earth");//取代所有World字串
            Console.WriteLine(strFive);
            string strSix = strOne.Substring(15, 2);//擷取索引值15後兩個字元
            Console.WriteLine(strSix);
            string strSeven = strOne.ToLower();//轉小寫, ToUpper()轉大寫
            Console.WriteLine(strSeven);
            bool isContain = strSeven.Contains("c#");
            Console.WriteLine("是否有C#字串 :"+isContain);
            Console.WriteLine("第三個字元 :{0}", strOne[2]);
            string strCollection = "珍珠|波霸|QQ|椰果|芋圓";
            string[] arrayWords = strCollection.Split('|');//使用|字元做切割 成果回傳
            Console.WriteLine(strCollection);

            foreach(string myWord in arrayWords)
            {
                Console.WriteLine(myWord);
            }

            Console.WriteLine("=====================");
        }

    }
}
