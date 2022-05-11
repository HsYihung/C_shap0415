﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mydbDataSet.persons' 資料表。您可以視需要進行移動或移除。
            this.personsTableAdapter.Fill(this.mydbDataSet.persons);

            
            顯示第幾筆共幾筆資料();
        }

        void 顯示第幾筆共幾筆資料()
        {
            int 目前第幾筆 = personsBindingSource.Position + 1;
            lbl第幾筆共幾筆.Text = "第" + 目前第幾筆 +"筆" + "/" + "共" + personsBindingSource.Count + "筆";
        }

        private void btn第一筆_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveFirst();
            顯示第幾筆共幾筆資料();
        }

        private void btn上一筆_Click(object sender, EventArgs e)
        {
            personsBindingSource.MovePrevious();
            顯示第幾筆共幾筆資料();
        }

        private void btn下一筆_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveNext();
            顯示第幾筆共幾筆資料();
        }

        private void btn最後一筆_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveLast();
            顯示第幾筆共幾筆資料();
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確認要儲存?", "儲存確認", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            { //yes 儲存
                //未來工作時, 要做欄位檢查
                Validate();
                personsBindingSource.EndEdit();
                personsTableAdapter.Update(mydbDataSet.persons);

                顯示第幾筆共幾筆資料();
                MessageBox.Show("資料儲存成功");
            }
            else
            { // no

            }
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確認要刪除此筆資料?", "刪除確認", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            { //YES
                personsBindingSource.EndEdit();
                int idxCurrent = personsBindingSource.Position;
                personsBindingSource.RemoveAt(idxCurrent);
                personsTableAdapter.Update(mydbDataSet.persons);
                personsBindingSource.Position = 0;

                顯示第幾筆共幾筆資料();
                MessageBox.Show("資料刪除成功");

            } else
            { //NO

            }
        }

        private void btn回復資料_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確認要回復資料?", "資料回復", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                //YES
                personsBindingSource.EndEdit();
                int idxCurrent = personsBindingSource.Position;
                personsTableAdapter.Fill(mydbDataSet.persons);
                personsBindingSource.Position = idxCurrent;
                顯示第幾筆共幾筆資料();
                MessageBox.Show("資料回復成功");

            } else
            {
                //NO
            }
        }

        private void btn新增資料_新增_Click(object sender, EventArgs e)
        {
            personsBindingSource.AddNew();
            dtp生日.Value = new DateTime(1900,1,1,0,0,0);
            chk婚姻狀態.Checked = false;
        }

        private void btn新增資料_儲存_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確認要儲存?", "儲存確認", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            { //yes 儲存
                //未來工作時, 要做欄位檢查
                Validate();
                personsBindingSource.EndEdit();
                personsTableAdapter.Update(mydbDataSet.persons);

                顯示第幾筆共幾筆資料();
                MessageBox.Show("資料儲存成功");

            } else
            { // no

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
