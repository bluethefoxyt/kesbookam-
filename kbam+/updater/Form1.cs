using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                tabControl1.SelectedTab = tabPage4;
            }else if(progressBar1.Value == 3)
            {
                label1.Text = "updating... client";
                WebClient client = new WebClient();
                client.DownloadFileAsync(new Uri("http://kesbook.cf/client/download/client.exe"), Environment.CurrentDirectory + "/kbam+.exe");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            tabControl1.SelectedTab = tabPage3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            tabControl1.SelectedTab = tabPage1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
