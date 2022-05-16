using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        List<int> searchIDs = new List<int>(); //進階搜尋結果
        string sql婚姻狀態查詢語法 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
            lblID.Text = "0";
            cbox欄位名稱.Items.Add("姓名");
            cbox欄位名稱.Items.Add("電話");
            cbox欄位名稱.Items.Add("地址");
            cbox欄位名稱.Items.Add("email");
            cbox欄位名稱.SelectedIndex = 0;
            產生會員資料列表();
        }

        private void btn資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select top(100)*from persons;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int i = 0;

            while (reader.Read())
            {
                //strMsg += (int)reader["Id"] + (string)reader["姓名"] + (string)reader["電話"] + "\n";
                strMsg += string.Format("{0} {1} {2} {3} {4} {5} {6} {7}\n", reader["Id"], reader["姓名"], reader["電話"], reader["地址"], reader["email"], reader["生日"], reader["婚姻狀態"], reader["會員點數"]);
                i++;
            }

            strMsg += "資料筆數:" + i.ToString();

            reader.Close();
            con.Close();
            //先開後關

            MessageBox.Show(strMsg);
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if(txt姓名.Text!="")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = $"select * from persons where 姓名 like @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", $"%{txt姓名.Text}%");//參數式 @SearchName 參數替換,後方字串 可檢查惡意程式
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblID.Text = reader["Id"].ToString();
                    txt姓名.Text = (string)reader["姓名"];
                    txt電話.Text = (string)reader["電話"];
                    txt地址.Text = (string)reader["地址"];
                    txtEmail.Text = (string)reader["email"];
                    dtp生日.Value = (DateTime)reader["生日"];
                    chk婚姻狀態.Checked = (Boolean)reader["婚姻狀態"];
                    txt點數.Text = string.Format($"{(int)reader["會員點數"]}");
                }
                else
                {
                    MessageBox.Show("查無此人");
                    lblID.Text = "0";
                    txtEmail.Clear();
                    txt電話.Clear();
                    txt姓名.Clear();
                    txt地址.Clear();
                    txtEmail.Clear();
                    txt點數.Clear();
                    dtp生日.Value = DateTime.Now;
                    chk婚姻狀態.Checked = false;

                }
                reader.Close();
                con.Close();

            }
            else
            {
                MessageBox.Show("請輸入姓名關鍵字搜尋");
            }
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if(txt姓名.Text !=""&&txt電話.Text!="")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into persons values (@insertName,@insertPhone,@insertAddress,@insertEmail,@insertBirthday,@insertMarriage,@insertPoints)";
                
                SqlCommand cmd = new SqlCommand(strSQL, con);
                int Points = 0;
                Int32.TryParse(txt點數.Text, out Points);
                //string strSQL = "insert into persons values (@insertValue)";
                //cmd.Parameters.AddWithValue("@insertValue",$"{txt姓名.Text},{txt電話.Text},{txt地址.Text},{txtEmail.Text},{dtp生日.Value},{chk婚姻狀態.Checked},{Points}");(錯誤) AddWihtValue 會自動加上單引號
                cmd.Parameters.AddWithValue("@insertName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@insertPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@insertAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@insertEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@insertBirthday", txt點數.Text);
                cmd.Parameters.AddWithValue("@insertMarriage", chk婚姻狀態.Checked);                
                cmd.Parameters.AddWithValue("@insertPoints", Points);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows}筆資料新增成功");
                con.Close();
            }
            else
            {
                MessageBox.Show("");
            }
            
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);
            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete persons where Id = @deleteId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@deleteId", intID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                
                lblID.Text = "0";
                txtEmail.Clear();
                txt電話.Clear();
                txt姓名.Clear();
                txt地址.Clear();
                txtEmail.Clear();
                txt點數.Clear();
                dtp生日.Value = DateTime.Now;
                chk婚姻狀態.Checked = false;

                MessageBox.Show($"{rows}筆資料刪除成功");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {

            lblID.Text = "0";
            txtEmail.Clear();
            txt電話.Clear();
            txt姓名.Clear();
            txt地址.Clear();
            txtEmail.Clear();
            txt點數.Clear();
            dtp生日.Value = DateTime.Now;
            chk婚姻狀態.Checked = false;
        }

        private void btn修改資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            int.TryParse(lblID.Text, out intID);
            if(intID>0)
            {
                if (txt姓名.Text!=""&&txt電話.Text!="")
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "update persons set 姓名 = @updateName,電話 = @updatePhone ,地址 = @updateAddress, email = @updateEmail , 生日 = @updateBirthday, 婚姻狀態 = @updateMarriage , 會員點數 = @updatePoints Where Id = @Id";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Id", intID);
                    cmd.Parameters.AddWithValue("@updateName", txt姓名.Text);
                    cmd.Parameters.AddWithValue("@updatePhone", txt電話.Text);
                    cmd.Parameters.AddWithValue("@updateAddress",txt地址.Text);
                    cmd.Parameters.AddWithValue("@updateEmail",txtEmail.Text);
                    cmd.Parameters.AddWithValue("@updateBirthday", dtp生日.Value);
                    cmd.Parameters.AddWithValue("@updateMarriage", chk婚姻狀態.Checked);
                    int intPoints = 0;
                    Int32.TryParse(txt點數.Text,out intPoints);
                    cmd.Parameters.AddWithValue("@updatePoints", intPoints);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"{rows}筆資料修改完成");
                }
                else
                {
                    MessageBox.Show("請輸入姓名電話");
                }
            }
            else
            {

            }
        }
        
        private void btn搜尋_Click(object sender, EventArgs e)
        {            
            lbox搜尋結果.Items.Clear();
            searchIDs.Clear();
            string str欄位名稱 = cbox欄位名稱.SelectedItem.ToString();
            //string sql婚姻狀態查詢語法 = "";
            //switch(int搜尋婚姻狀態)
            //{
            //    case 0:
            //        break;
            //    case 1:
            //        sql婚姻狀態查詢語法 = " and (婚姻狀態 = 1)";
            //        break;
            //    case 2:

            //        break;
            //    default:
            //        break;
            //}            
            if(txt欄位關鍵字.Text != "")
            {
                string strSQL = $"select * from persons where ({str欄位名稱} like @SeacrhName) and (生日 >= '{dtp開始生日.Value:d}' and  生日 <= '{dtp結束生日.Value:d}'){sql婚姻狀態查詢語法}";//使用日期value 需轉格式
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();                
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SeacrhName","%"+txt欄位關鍵字.Text+"%");
                //cmd.Parameters.AddWithValue("@StarDate", dtp開始生日.Value);
                //cmd.Parameters.AddWithValue("@EndDate", dtp結束生日.Value);
                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while(reader.Read())
                {
                    lbox搜尋結果.Items.Add((string)reader["姓名"]);
                    searchIDs.Add((int)reader["Id"]);
                    i++;
                }
                if(i==0)
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入搜尋關鍵字");
            }
        }

        private void lbox搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if(lbox搜尋結果.SelectedIndex >= 0)
            {
                int intID = searchIDs[lbox搜尋結果.SelectedIndex];
                string strSQL = "select * from persons where Id = @SearchID";
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("SearchID",intID);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    lblID.Text = reader["Id"].ToString();
                    txt姓名.Text = (string)reader["姓名"];
                    txt電話.Text = (string)reader["電話"];
                    txt地址.Text = (string)reader["地址"];
                    txtEmail.Text = (string)reader["email"];
                    dtp生日.Value = (DateTime)reader["生日"];
                    chk婚姻狀態.Checked = (Boolean)reader["婚姻狀態"];
                    txt點數.Text = string.Format($"{(int)reader["會員點數"]}");
                }
                reader.Close();
                con.Close();
            }
            
        }

        private void radio婚姻全部_CheckedChanged(object sender, EventArgs e)
        {
            sql婚姻狀態查詢語法 = "";
        }

        private void radio婚姻已婚_CheckedChanged(object sender, EventArgs e)
        {
            sql婚姻狀態查詢語法 = " and (婚姻狀態 = 1)";
        }

        private void radio婚姻未婚_CheckedChanged(object sender, EventArgs e)
        {
            sql婚姻狀態查詢語法 = " and (婚姻狀態 = 0)";
        }

        void 產生會員資料列表()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string StrSQL = "select Id as 會員編號, 姓名 , 電話 , email, 會員點數 ,婚姻狀態 from persons";
            SqlCommand cmd = new SqlCommand(StrSQL,con);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelID = 0;                
                bool isId = Int32.TryParse(strSelID, out intSelID);
                if(isId)
                {
                    string strSQL = "select * from persons where Id = @SearchID";
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("SearchID", intSelID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblID.Text = reader["Id"].ToString();
                        txt姓名.Text = (string)reader["姓名"];
                        txt電話.Text = (string)reader["電話"];
                        txt地址.Text = (string)reader["地址"];
                        txtEmail.Text = (string)reader["email"];
                        dtp生日.Value = (DateTime)reader["生日"];
                        chk婚姻狀態.Checked = (Boolean)reader["婚姻狀態"];
                        txt點數.Text = string.Format($"{(int)reader["會員點數"]}");
                    }
                    reader.Close();
                    con.Close();
                }                
            }
        }
    }
}
