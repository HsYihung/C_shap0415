using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        List<Button> myDbuttonList = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myUserControlOne1.txt輸入文字.Text = "輸入文字";
            //動態產生按鈕(9,9);
            //Random myRnd = new Random();
            //for (int i = 0; i < 6; i++)
            //{
            //    int intRand = myRnd.Next(1,82);
            //    myDbuttonList[intRand].BackColor = Color.Red;
            //}
            自訂MyLabelButton();
        }
        void 自訂MyLabelButton()
        {
            MyLabelButton lblBtnOne = new MyLabelButton();
            lblBtnOne.BackColor = Color.LightSkyBlue;
            lblBtnOne.ForeColor = Color.Blue;
            lblBtnOne.Font = new Font("微軟正黑體", 16);
            lblBtnOne.Name = "lblBtnOne";
            lblBtnOne.Text = "自訂標籤文字";
            lblBtnOne.TextAlign = ContentAlignment.MiddleLeft;
            lblBtnOne.Location = new Point(20, 20);
            lblBtnOne.AutoSize = false;
            lblBtnOne.Size = new Size(300, 60);
            lblBtnOne.myDbutton.Click += new EventHandler(lblButton_Click);

            Controls.Add(lblBtnOne);
            
        }

        void 動態產生按鈕(int intRow,int intColumn)
        {
            for (int i = 0; i< intRow; i ++)
            {
                for (int j = 0; j < intColumn; j++)
                {
                    Button dButton = new Button();
                    dButton.BackColor = Color.Pink;
                    //if ((i+j) % 2 == 1)
                    //{
                    //    dButton.BackColor = Color.Red;
                    //}
                    dButton.ForeColor = Color.FromArgb(104, 37, 144);
                    dButton.Font = new Font("微軟正黑體", 10);
                    dButton.Name = "btnDbutton"+(i*intRow+1+j);
                    dButton.Text = "";
                    dButton.Size = new Size(40, 40);
                    //dButton.AutoSize = true;
                    dButton.Location = new Point(20 + 45*i, 20 + 45 * j);
                    dButton.Click += new EventHandler(btnDbutton_Click); //+= 事件指定關聯運算子 -=事件解除關聯運算子
                    dButton.TextAlign = ContentAlignment.MiddleCenter;
                    Controls.Add(dButton);
                    myDbuttonList.Add(dButton);
                }
            }
        }
        private void btnDbutton_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            //MessageBox.Show("111");
            MessageBox.Show(""+myButton.Name);
            if(myButton.BackColor == Color.Pink)
            {
                myButton.BackColor = Color.Red;
                
            }
            else
            {
                myButton.BackColor = Color.Pink;

            }

        }
        private void lblButton_Click(object sender, EventArgs e)
        {
            Button myBtn = (Button)sender;
            MessageBox.Show("按下" + myBtn.Name);
        }

    }
}
