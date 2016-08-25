using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp_.style
{
    public partial class line : UserControl
    {
        public line()
        {
            InitializeComponent();
        }

        private void line_Resize(object sender, EventArgs e)
        {
            Height = 2;
        }
    }
}
