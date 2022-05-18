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

namespace drink_shop
{
    public partial class newUser : Form
    {
        public newUser()
        {
            InitializeComponent();
        }

        private void newUser_Load(object sender, EventArgs e)
        {

        }

        private void btn退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn確認_Click(object sender, EventArgs e)
        {
            if ()
            {
                SqlConnection con = new SqlConnection(linksql.myDBConnectionString);
            }

        }
    }
}
