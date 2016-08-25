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
    public partial class progressbarcustom : UserControl
    {
        public progressbarcustom()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Width++;
            if (pictureBox1.Width == panel1.Width)
            {
                timer1.Stop();
            }
        }
        public void progress(int value)
        {
            pictureBox1.Width = value;
        }
        public void start()
        {
            timer1.Start();
        }
        public void stop()
        {
            timer1.Stop();
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
