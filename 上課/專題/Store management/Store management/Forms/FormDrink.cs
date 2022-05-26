using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_management.Forms
{
    public partial class FormDrink : Form
    {
        model model;
        public FormDrink()
        {
            InitializeComponent();
        }

        private void FormDrink_Load(object sender, EventArgs e)
        {
            model = new model();
            cboxOptions.Items.Add("修改飲品");
            cboxOptions.Items.Add("修改配料");
            cboxOptions.Items.Add("新增飲品");
            cboxOptions.Items.Add("新增配料");
            model.actionFrom(cboxOptions, listView1);
            cboxOptions.SelectedIndex = 0;
            model.readDrink();
        }

        private void cboxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.readDrink();
            txtName.Clear();
            txtPrice.Clear();
            model.actionIndex = -1;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
           
                model.selectDrink(txtName, txtPrice);            
        }

        private void btnSeveModify_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtPrice.Text, out int i))
            {
                model.seveModify(txtName, txtPrice);
            }
        }

        private void btnReModify_Click(object sender, EventArgs e)
        {
            model.selectDrink(txtName, txtPrice);
        }
    }
}
