using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms000
{
    public partial class Form1 : Form
    {
        string[,,] arrayA;
        int x;
        int y;
        
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arrayA = new string[2, 5, 2] {
                {
                    {"雞腿","50" },
                    {"排骨","60"},
                    {"魚肚","70" },
                    {"燒肉","80" },
                    {"叉燒","90" }
                },
                {
                    {"排骨","90" },
                    {"魚肚","80" },
                    {"雞腿","70" },
                    {"叉燒","60" },
                    {"燒肉","50" }
                }
                
            };
        }

        private void btnAA_Click(object sender, EventArgs e)
        {
            x = 0;
            btn1.Text = arrayA[x, 0, 0];
            lblPrice1.Text = $"{arrayA[x, 0, 1]}元";
            btn2.Text = arrayA[x, 1, 0];
            lblPrice2.Text = $"{arrayA[x, 1, 1]}元";
            btn3.Text = arrayA[x, 2, 0];
            lblPrice3.Text = $"{arrayA[x, 2, 1]}元";
            btn4.Text = arrayA[x, 3, 0];
            lblPrice4.Text = $"{arrayA[x, 3, 1]}元";
            btn5.Text = arrayA[x, 4, 0];
            lblPrice5.Text = $"{arrayA[x, 4, 1]}元";

        }

        private void btnBB_Click(object sender, EventArgs e)
        {
            x = 1;
            btn1.Text = arrayA[x, 0, 0];
            lblPrice1.Text = $"{arrayA[x, 0, 1]}元";
            btn2.Text = arrayA[x, 1, 0];
            lblPrice2.Text = $"{arrayA[x, 1, 1]}元";
            btn3.Text = arrayA[x, 2, 0];
            lblPrice3.Text = $"{arrayA[x, 2, 1]}元";
            btn4.Text = arrayA[x, 3, 0];
            lblPrice4.Text = $"{arrayA[x, 3, 1]}元";
            btn5.Text = arrayA[x, 4, 0];
            lblPrice5.Text = $"{arrayA[x, 4, 1]}元";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            AA(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AA(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AA(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AA(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AA(btn5.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblList.Text = "";
            lblList1.Text = "";
            lbltotal.Text = "";
            y = 0;
        }


        void AA (string msg)
        {
            
            for(int i = 0; i<=arrayA.GetUpperBound(1);i++)
            {
                if(x==0 && msg == arrayA[x,i,0])
                {

                    lblList.Text += $"{btnAA.Text} {arrayA[x,i,0]}   {arrayA[x, i, 1]}元\n";
                    int a;
                    int.TryParse(arrayA[x, i, 1],out a);
                    y += a;
                }
                else if(x == 1 && msg == arrayA[x, i, 0])
                {
                    lblList1.Text += $"{btnBB.Text} {arrayA[x, i, 0]}   {arrayA[x, i, 1]}元\n";
                    int a;
                    int.TryParse(arrayA[x, i, 1], out a);
                    y += a;
                }
            }
            lbltotal.Text = string.Format(""+y+"元");
            
        }

        

    }
}
