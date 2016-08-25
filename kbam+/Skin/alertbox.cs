using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kbam_.Skin
{
    public partial class alertbox : UserControl
    {
        public alertbox()
        {
            InitializeComponent();
        }

        private void alertbox_Load(object sender, EventArgs e)
        {

        }
        public void text(string text)
        {
            label2.Text = text;
        }
        public void style(string style)
        {
            if (style == "success")
            {
                this.BackColor = Color.ForestGreen;
            }
            else if (style == "danger")
            {
                this.BackColor = Color.Red;
            }
            else if (style == "info")
            {
                this.BackColor = Color.BlueViolet;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
