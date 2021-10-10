using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RL_Quick_Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            guna2TileButton1.BackColor = Color.IndianRed;
            Application.Exit();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            if (Properties.Settings.Default.downloaded == false)
            {
                if (File.Exists("C:\\ahk\\autohotkey.exe"))
                {
                    File.Delete("C:\\ahk\\autohotkey.exe");
                }
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://www.autohotkey.com/download/ahk-install.exe", $"C:\\ahk\\autohotkey.exe");
                }

                Properties.Settings.Default.downloaded = true;
                Properties.Settings.Default.Save();
                ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
                info.Arguments = "/c cd C:\\ahk&start autohotkey.exe";
                Process.Start(info);
            }
                this.Hide();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
        }
    }
}
