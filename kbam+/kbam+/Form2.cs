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
    public partial class Form2 : Form

    {
        bool panel = false;

        public Form2()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize(Environment.CurrentDirectory);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            iconButton4.IconType = FontAwesomeIcons.IconType.Users;
        
            panel3.Hide();
            var wc = new System.Net.WebClient();
            webBrowser2.Navigate("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/pf.txt");
            pictureBox1.ImageLocation = "http://kesbook.cf/users/" + Properties.Settings.Default.username + "/avitar.png";
            label1.Text = Properties.Settings.Default.username;
            label2.Text = Properties.Settings.Default.username;
            if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/ver.txt") == "true")
            {
                label3.Text = "Verified";
            }
            else if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/ver.txt") == "false")
            {
                label3.Text = "Not verified";
            }

            
            if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/stat.txt") == "<label class='label label-danger' id='s'> </label>")
            {
                pictureBox2.BackColor = Color.OrangeRed;
            }
            else if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/stat.txt") == "<label class='label label-default' id='s'> </label>")
            {
                pictureBox2.BackColor = Color.Gray;
            }
            else if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/stat.txt") == "<label class='label label-success' id='s'> </label>")
            {
                pictureBox2.BackColor = Color.Green;
            }
            else if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/stat.txt") == "<label class='label label-warning' id='s'> </label>")
            {
                pictureBox2.BackColor = Color.Yellow;
            }
            else if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/stat.txt") == "<label class='label label-info' id='s'> </label>")
            {
                pictureBox2.BackColor = Color.DeepSkyBlue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
            webBrowser1.Navigate("http://kesbook.cf/stat.php?s=online&cw=false&user=" + Properties.Settings.Default.username);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.OrangeRed;
            webBrowser1.Navigate("http://kesbook.cf/stat.php?s=offline&cw=false&user=" + Properties.Settings.Default.username);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Yellow;
            webBrowser1.Navigate("http://kesbook.cf/stat.php?s=away&cw=false&user=" + Properties.Settings.Default.username);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.DeepSkyBlue;
            webBrowser1.Navigate("http://kesbook.cf/stat.php?s=atwork&cw=false&user=" + Properties.Settings.Default.username);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Gray;
            webBrowser1.Navigate("http://kesbook.cf/stat.php?s=dnd&cw=false&user=" + Properties.Settings.Default.username);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            var wc = new System.Net.WebClient();
            if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/stat.txt") == "<label class='label label-danger' id='s'> </label>")
            {
                pictureBox2.BackColor = Color.Red;
            }
            else if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/stat.txt") == "<label class='label label-default' id='s'> </label>")
            {
                pictureBox2.BackColor = Color.Gray;
            }
            else if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/stat.txt") == "<label class='label label-success' id='s'> </label>")
            {
                pictureBox2.BackColor = Color.Green;
            }
            else if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/stat.txt") == "<label class='label label-warning' id='s'> </label>")
            {
                pictureBox2.BackColor = Color.Yellow;
            }
            else if (wc.DownloadString("http://kesbook.cf/users/" + Properties.Settings.Default.username + "/stat.txt") == "<label class='label label-info' id='s'> </label>")
            {
                pictureBox2.BackColor = Color.DeepSkyBlue;
            }
            else
            {

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel == false)
            {
                panel2.Hide();
                panel = true;

            }
            else
            {
                panel2.Show();
                panel = false;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://kesbook.cf/delete.php?uname="  + Properties.Settings.Default.username);
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
       
            Hide();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.FindForm().Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == Properties.Settings.Default.username)
            {
                chattimer.Start();
                webBrowser4.Navigate("http://kesbook.cf/chat.php?chat=" + textBox2.Text + "&text=" + Properties.Settings.Default.username + "(HOST OF THIS CHATROOM) has joined the chat network");
                webBrowser.Navigate("http://kesbook.cf/cg/" + textBox2.Text + "/index.html");
                webBrowser.Refresh();
                webBrowser.Refresh();
                webBrowser.Refresh();
                webBrowser.Refresh();
            }else
            {
                chattimer.Start();
                webBrowser4.Navigate("http://kesbook.cf/chat.php?user=" + textBox2.Text + "&text=" + Properties.Settings.Default.username + " has joined the chat network make him/her feel welcome :)");
                webBrowser.Navigate("http://kesbook.cf/cg/" + textBox2.Text + "/index.html");
                webBrowser.Refresh();
                webBrowser.Refresh();
                webBrowser.Refresh();
                webBrowser.Refresh();
            }
        }

        private void chattimer_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Increment(1);
                if (progressBar1.Value == 180)
                {
                    webBrowser.Navigate("http://kesbook.cf/users/" + textBox2.Text + "/chat.php#end");
                    progressBar1.Value = 0;
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("ERROR ! Error code:00X00X664");
            }

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "/")
            {
                webBrowser4.Navigate("http://kesbook.cf/chat.php?user=" + Properties.Settings.Default.username + " did / command");
                webBrowser4.Navigate("http://kesbook.cf/chat.php?user=" + Properties.Settings.Default.username + " command1 /play play music from a url");
                webBrowser4.Navigate("http://kesbook.cf/chat.php?user=" + Properties.Settings.Default.username + " command2 /help");
                webBrowser4.Navigate("http://kesbook.cf/chat.php?user=" + Properties.Settings.Default.username + " command3 /about about version");
                webBrowser4.Navigate("http://kesbook.cf/chat.php?user=" + Properties.Settings.Default.username + " command+ /network info about the network");
                webBrowser.Refresh();
            }
            if (textBox2.Text == Properties.Settings.Default.username)
            {
                webBrowser4.Navigate("http://kesbook.cf/chat.php?user=" + textBox2.Text + "&text=[<font color='red'>" + Properties.Settings.Default.username + "</font>]: " + richTextBox1.Text + "");
              
                webBrowser.Refresh();
            }else if(Properties.Settings.Default.username == "kessanro")
            {

                webBrowser4.Navigate("http://kesbook.cf/chat.php?user=" + textBox2.Text + "&text=[<font color='blue'>" + Properties.Settings.Default.username + "</font> founder and ceo]: " + richTextBox1.Text + "");
                webBrowser.Refresh();
            }
            else
            {
                webBrowser4.Navigate("http://kesbook.cf/chat.php?user=" + textBox2.Text + "&text=[" + Properties.Settings.Default.username + "]: " + richTextBox1.Text + "");
                webBrowser.Refresh();
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            chattimer.Stop();
            webBrowser4.Navigate("http://kesbook.cf/chat.php?user=" + textBox2.Text + "&text=" + Properties.Settings.Default.username + " has disconnected from this chat network");
            textBox2.Text = "";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
            webBrowser.Refresh();
            webBrowser.Refresh();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("kesbook.cf/cd.php?name=" + Properties.Settings.Default.username);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            webBrowser4.Navigate("http://kesbook.cf/chat.php?user=" + textBox2.Text + "&text=" + Properties.Settings.Default.username + " has liked this chat room be thankfull");
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {

            richTextBox1.Text += Environment.NewLine + "<img src='your image source'></img>";
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Environment.NewLine + "<h1>TextInlage</h1>";
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Environment.NewLine + "html5 code";
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Environment.NewLine + "<a href='http://github.com/'>GithubPage</a>";
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Environment.NewLine + "<iframe width='854' height='480' src='youtube video' frameborder='0' denyfullscreen></iframe>";


        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Environment.NewLine + "<a href='http://link.com'>texttexttext</a>";
        }
        
        private void iconButton21_Click(object sender, EventArgs e)
        {
            webBrowser7.Navigate("kesbook.cf/users/" + Properties.Settings.Default.username + "/pm.txt");
        }

        private void iconButton20_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == Properties.Settings.Default.username)
            {
                textBox3.BackColor = Color.Red;
            } else {
             webBrowser1.Navigate("kesbook.cf/pm.php?name=" + textBox3.Text + "&text=" + "(" + Properties.Settings.Default.username + ") ");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void webBrowser6_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void formnomax1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.close = "hide";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            form_skin1.classic();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            form_skin1.moonwhite();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            form_skin1.Blue();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void formnomax1_Load_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.close = "app";
        }

        private void form_skin1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.close = "hide";
        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void iconButton22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }

        private void iconButton19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No games. It's in wip");
        }

        private void iconButton19_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void iconButton22_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }

        private void iconButton20_Click_1(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by kessan robertson of Kesbook UK (C) 2016");
        }

        private void iconButton20_Click_2(object sender, EventArgs e)
        {

        }
    }
}
