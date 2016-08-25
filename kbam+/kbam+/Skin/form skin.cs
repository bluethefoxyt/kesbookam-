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
    public partial class form_skin : UserControl
    {
       
        public form_skin()
        {
            InitializeComponent();
        }

        private void form_skin_Load(object sender, EventArgs e)
        {
            label2.Text = Properties.Settings.Default.program;
        }
        public void Blue()
        {
            panel1.BackColor = Color.AliceBlue;
            BackColor = Color.LightBlue;
            ForeColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
        }
        public void classic()
        {
            panel1.BackColor = Color.Gray;
            BackColor = Color.Black;
            ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label1.ForeColor = Color.White;

        }
        public void moonwhite()
        {
            panel1.BackColor = Color.GhostWhite;
            BackColor = Color.White;
            ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.close == "app")
            {
                Application.Exit();
            }
            if (Properties.Settings.Default.close == "hide")
            {
                FindForm().Hide();
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
               FindForm().Location = new Point(
                    (FindForm().Location.X - lastLocation.X) + e.X, (FindForm().Location.Y - lastLocation.Y) + e.Y);

                FindForm().Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
           
    }
        private bool mouseDown;
        private Point lastLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
