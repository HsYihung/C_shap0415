﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Person> 員工基本資料集合 = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person.abuotInfo();
        }

        private void btn創建員工1_Click(object sender, EventArgs e)
        {            
            Person 員工1 = new Person();
            員工1.姓名 = "王大衛";
            員工1.身高 = 170.0f;
            員工1.體重 = 70.0;
            員工1.到職日 = Convert.ToDateTime("2022-04-28");
            員工1.薪資 = 21000;
            員工1.部門代號 = (int)MyEnums.Dep.行政處;
            
            員工基本資料集合.Add(員工1);

            員工1.顯示基本資料();
        }

        private void btn創建員工2_Click(object sender, EventArgs e)
        {
            Person 員工2 = new Person("李瑪莉");
            員工2.身高 = 160.0f;
            員工2.體重 = 70.0;
            員工2.到職日 = new DateTime(2018,7,2,0,0,0);
            員工2.薪資 = 32000.0;
            員工2.部門代號 = (int)MyEnums.Dep.資訊處;

            員工基本資料集合.Add(員工2);
            員工2.顯示基本資料();
        }

        private void btn列出所有員工_Click(object sender, EventArgs e)
        {
            string strInfo = "";

            for(int i = 0; i<員工基本資料集合.Count;i+=1)
            {
                Person myPerson = 員工基本資料集合[i];
                strInfo += string.Format("{0} {1:F}公分 {2:F}公斤 {3:C}元  {4:D} 年資:{5:F2}年 獎金:{6:C}元\n",myPerson.姓名,myPerson.身高,myPerson.體重,myPerson.薪資,myPerson.到職日,myPerson.計算年資(),myPerson.計算獎金(1000.0));
            }

            MessageBox.Show(strInfo);
        }

        private void btn創建管理者1_Click(object sender, EventArgs e)
        {
            Manager 管理者1 = new Manager("陳經理");
            //Manager 管理者1 = new Manager();
            //管理者1.姓名 = "陳經理";
            管理者1.身高 = 175.0f;
            管理者1.體重 = 65.0;
            管理者1.薪資 = 60000.0;
            管理者1.到職日 = new DateTime(2010,2,21,0,0,0);
            管理者1.部門代號 = (int)MyEnums.Dep.行政處;
            管理者1.職稱 = (int)MyEnums.Man.經理;


            管理者1.顯示基本資料();

        }
    }
}
