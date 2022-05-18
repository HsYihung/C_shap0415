using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    class MyLabelButton : Label
    {
        public Button myDbutton;
        public MyLabelButton()
        {
            myDbutton = new Button();
            myDbutton.BackColor = Color.LightYellow;
            myDbutton.ForeColor = Color.Purple;
            myDbutton.Font = new Font("微軟正黑體", 14);
            myDbutton.Name = "btnDbutton";
            myDbutton.Text = "Label內按鈕";
            //myDbutton.Size = new Size(120, 40);
            myDbutton.AutoSize = true;
            myDbutton.Location = new Point(150,15);           
            myDbutton.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(myDbutton);
        }
    }
}
