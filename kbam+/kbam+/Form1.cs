using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Configuration;
using kbam_;
using System.IO;
using Microsoft.CSharp.RuntimeBinder;


namespace kbam_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var wc = new System.Net.WebClient();
            string st1 = textBox2.Text;
            string st3 = md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(base64_encode(base64_encode(base64_encode(base64_encode(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(md5(st1)))))))))))))))))))))))))))))))))))))))))))
            passbox.Text = st3;
            Properties.Settings.Default.username = textBox1.Text;
            Properties.Settings.Default.username = textBox1.Text;
            Properties.Settings.Default.username = textBox1.Text;
            try
            {
                if (passbox.Text == wc.DownloadString("http://kesbook.cf/users/" + textBox1.Text + "/pass.txt"))
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                    Properties.Settings.Default.username = textBox1.Text;
                }
                else
                {
                    textBox2.BackColor = Color.Red;
                }
            }
            catch
            {
                textBox2.BackColor = Color.Red;

            }

        }
        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "abc123";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        private string md5(string sPassword)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(sPassword);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void formnomax1_Load(object sender, EventArgs e)
        {

        }

        private void formnomax1_Load_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.close = "app";
        }
        static public string base64_encode(string toEncode)
        {
            byte[] toEncodeAsBytes
                  = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
            string returnValue
                  = System.Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }
    }
      }
