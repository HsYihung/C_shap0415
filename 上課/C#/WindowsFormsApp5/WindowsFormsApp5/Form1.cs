using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        //類別變數, 本類別可視
        string[] arrayStudentName ;//學生姓名陣列
        int[] arrayStudentScore;//學生成績陣列
        string[] arrayTempStudentName;//學生姓名暫存陣列
        int[] arrayTempStudentCcore;//學生成績暫存陣列

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //姓名-成績, key-value , 鍵值對應

            arrayStudentName = new string[5] { "王小明", "陳大貓", "林阿霈", "張大書", "黃忠孝" };
            arrayStudentScore = new int[5] { 76, 68, 54, 92, 86 };

            arrayTempStudentName = new string[5];
            arrayTempStudentCcore = new int[5];

            lbl成績總和.Text =""+ totalScore(arrayStudentScore);
            lbl成績平均.Text = string.Format($"{average(arrayStudentScore):F1}") ;

        }

        private void btn姓名排序_Click(object sender, EventArgs e)
        {
            System.Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
            
            姓名排序(arrayTempStudentName);
        }

        private void btn成績排序_Click(object sender, EventArgs e)
        {
            Array.Copy(arrayStudentName,arrayTempStudentName,arrayStudentName.Length);
            Array.Copy(arrayStudentScore, arrayTempStudentCcore, arrayStudentScore.Length);
            成績排序(arrayTempStudentName,arrayTempStudentCcore);
        }

        private void btn列出所有學生_Click(object sender, EventArgs e)
        {
            列出所有人員();
        }

        private void btn姓名搜尋_Click(object sender, EventArgs e)
        {
            if(txt輸入姓名.Text.Length>0)
            {
                int index, num = 0;
                string strMsg = "搜尋結果\n---------------\n";
                string strSearchName = txt輸入姓名.Text;

                Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
                Array.Copy(arrayStudentScore, arrayTempStudentCcore, arrayStudentScore.Length);

                成績排序(arrayTempStudentName, arrayTempStudentCcore);

                index = System.Array.IndexOf(arrayTempStudentName,strSearchName);
                if(index == -1)
                {
                    strMsg += "查無此人";
                }else
                {
                    num = arrayStudentName.Length - index;
                    strMsg += string.Format($"{arrayTempStudentName[index]}  {arrayTempStudentCcore[index]} 第{num}名");
                }
                lbl資料結果顯示.Text = strMsg;

            }
            else
            {
                MessageBox.Show("請輸入姓名");
            }
            



        }
        //myMethods
        void 列出所有人員()
        {
            string strMsg = "";
            for(int idx=0;idx < arrayStudentName.Length;idx+=1)
            {
                strMsg += string.Format($"索引值: {idx} 姓名:{arrayStudentName[idx]} 成績:{arrayStudentScore[idx]}\n" );
            }
            lbl資料結果顯示.Text = strMsg;
        }

        void 姓名排序(string[] myArrayName)
        {
            System.Array.Sort(myArrayName);

            string strMsg = "";
            for (int idx = 0; idx<myArrayName.Length;idx++)
            {
                strMsg += string.Format($"姓名 :{myArrayName[idx]}\n");
            }
            lbl資料結果顯示.Text = strMsg;
        }

        void 成績排序(string[] myArrayName,int [] myArrayScore)
        {
            string strMsg = "";
            Array.Sort(myArrayScore, myArrayName);
            for (int idx = myArrayScore.GetUpperBound(0); idx >= 0; idx--)
            {
                strMsg += string.Format($"第{myArrayName.Length-idx}名 " +
                    $"{myArrayName[idx]} " +
                    $"成績 :{myArrayScore[idx]}\n");
                lbl資料結果顯示.Text = strMsg;
            }

        }

        int totalScore(int[] myArrayScore)
        {
            int total = 0;
            foreach(int myScore in myArrayScore)
            {
                total += myScore;
            }
            return total;
        }

        double average(int[] myArrayScore)
        {
            double avg = 0.0;

            avg =Convert.ToDouble(totalScore(myArrayScore)) / myArrayScore.Length;

            return avg;
        }
        
    }
}
