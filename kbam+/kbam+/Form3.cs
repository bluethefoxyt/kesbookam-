using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kbam_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void reg(string username, string password, string email, string motd, string car, string phone, string age)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if(webBrowser1.Url.ToString() == "http://kesbook.cf/index.php")
            {
                this.Close();
            }
            else if (webBrowser1.Url.ToString() == "http://kesbook.cf/login.php")
            {
                this.Close();
            }
        }
    }
}
