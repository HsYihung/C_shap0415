using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
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
    class Person
    {
        public float 身高 = 0.0f; //field 欄位
        public double 體重 = 0.0; //欄位
        public DateTime 到職日 = DateTime.Now;
        public int 部門代號 = 0;
        //------------------------------------
        public string 姓名 { get; set; }//屬性 property , get: 取值 set:存值
        protected double _薪資;
        public virtual double 薪資 
        {
            get//取值
            {
                return _薪資;
            }

            set//存值
            {
                if(value < 25250)
                {
                    value = 25250;
                }
                else
                {

                }
                _薪資 = value;
            }
        }
        
        public Person()
        {
            //預設建構式
            //建構式必須為public
            
        }

        public Person(string myName)
        {
            //建構方法多載
            this.姓名 = myName;//this物件本身 C#可省略
        }

        public virtual void 顯示基本資料()
        {
            string strInfo = string.Format($"姓名:{this.姓名} \n身高:{this.身高:F}\n體重:{this.體重:F}\n薪資:{this.薪資:C}\n到職日:{this.到職日:D}\n部門代號:{部門代號}\n部門名稱:{顯示部門名稱(部門代號)}");

            MessageBox.Show(strInfo);
        }

        public double 計算年資()
        {
            double 年資 = 0.0;

            TimeSpan ts = DateTime.Now - this.到職日;
            年資 = ts.TotalDays / 365;

            return 年資;
        }

        public double 計算獎金(double 一年資獎金)
        {
            double 獎金 = 0.0;

            獎金 = this.計算年資() * 一年資獎金;
            if (獎金<500)
            {
                獎金 = 500;
            }

            return 獎金;
        }

        public string 顯示部門名稱(int 部門代號)
        {
            string strDep = "";

            switch(部門代號)
            {
                case (int)MyEnums.Dep.行政處:
                    strDep = "行政執行處";
                    break;
                case (int)MyEnums.Dep.資訊處:
                    strDep = "資訊管理處";
                    break;
                case (int)MyEnums.Dep.業務部:
                    strDep = "業務推廣部";
                    break;
                case (int)MyEnums.Dep.研發部:
                    strDep = "創新研發部";
                    break;
                default:
                    strDep = "查無此部門";
                    break;
            }

            return strDep;
        }

        public static void abuotInfo()
        {
            MessageBox.Show("類別名稱:Person\n功能:儲存員工基本資料\n版本:v0.1");
        }
    }
}
