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
using System.IO;

namespace WindowsFormsApp5
{
    public partial class FormDetail : Form
    {
        public int pID = 0;
        string myDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        bool is已修改圖檔 = false;
        public FormDetail()
        {
            InitializeComponent();
        }
        private void FormDetail_Load(object sender, EventArgs e)
        {
            lbl序號.Text = pID.ToString();
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            if(pID <= 0)
            {
                //新增模式
                groupBox修改商品.Visible = false;
                groupBox新增商品.Visible = true;

            }
            else
            {
                //修改模式
                groupBox修改商品.Visible = true;
                groupBox新增商品.Visible = false;
                顯示商品細項資訊();
            }
        }
        void 顯示商品細項資訊()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = $"select * from products where ID = {pID}";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while(reader.Read())
            {
                lbl序號.Text = reader["id"].ToString();
                txt商品名稱.Text = (string)reader["pname"];
                txt商品價格.Text = reader["price"].ToString();
                txt商品描述.Text = reader["pdesc"].ToString();
                image_name = reader["pimage"].ToString();
                pictureBox1.Image = Image.FromFile(image_dir + image_name);
                i ++;
            }
            reader.Close();
            con.Close();
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt商品描述.Text != "") && (pictureBox1.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = $"update products set pname = @newPname , price = @newPrice , pdesc = @newPdesc , pimage = '{image_name}' where id ={pID}";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@newPname", txt商品名稱.Text);
                int intPrice = 0;
                if (int.TryParse(txt商品價格.Text, out intPrice))
                {
                    cmd.Parameters.AddWithValue("@newPrice", intPrice);
                }
                else
                {
                    MessageBox.Show("商品價格輸入錯誤");
                }
                cmd.Parameters.AddWithValue("@newPdesc", txt商品描述.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料修改成功,影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
        }

            private void btn新增商品_Click(object sender, EventArgs e)
        {
            lbl序號.Text = "";
            txt商品價格.Text = "";
            txt商品名稱.Text = "";
            txt商品描述.Text = "";
            pictureBox1.Image = null;//指定為亂數產生記憶體位置

        }

        private void btn儲存商品_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt商品描述.Text != "") && (pictureBox1.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = $"insert into products (pname,price,pdesc,pimage) values(@newPname ,  @newPrice ,  @newPdesc , '{image_name}')";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@newPname", txt商品名稱.Text);
                int intPrice = 0;
                if (int.TryParse(txt商品價格.Text, out intPrice))
                {
                    cmd.Parameters.AddWithValue("@newPrice", intPrice);
                }
                else
                {
                    MessageBox.Show("商品價格輸入錯誤");
                }
                cmd.Parameters.AddWithValue("@newPdesc", txt商品描述.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料新增成功,影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
        }

        private void btn選取商品照片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            DialogResult r = f.ShowDialog();
            if(r == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyMMddHHmmss")+ myRand.Next(100,1000)+fileExt;
                is已修改圖檔 = true;
                Console.WriteLine(image_name);
            }
        }


    }
}
