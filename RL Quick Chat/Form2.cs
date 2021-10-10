using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RL_Quick_Chat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(File.Exists("C:\\ahk\\ahk.ahk"))
            {
                File.Delete("C:\\ahk\\ahk.ahk");
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\ahk\\ahk.txt"))
            {
                

                file.WriteLine(@"#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
; #Warn  ; Enable warnings to assist with detecting common errors.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.

1::
    Send, t
    Sleep, 50
    Send, " + $@"{guna2TextBox1.Text}.");
file.WriteLine(@"    Send, {Enter}
    Sleep, 50
Return");
                file.WriteLine(@"
2::
    Send, t
    Sleep, 50
    Send, " + $@"{guna2TextBox2.Text}.");
                file.WriteLine(@"    Send, {Enter}
    Sleep, 50
Return");
                file.WriteLine(@"
3::
    Send, t
    Sleep, 50
    Send, " + $@"{guna2TextBox3.Text}.");
                file.WriteLine(@"    Send, {Enter}
    Sleep, 50
Return");
                file.WriteLine(@"
4::
    Send, t
    Sleep, 50
    Send, " + $@"{guna2TextBox4.Text}.");
                file.WriteLine(@"    Send, {Enter}
    Sleep, 50
Return");
                file.WriteLine(@"
5::
    Send, t
    Sleep, 50
    Send, " + $@"{guna2TextBox5.Text}.");
                file.WriteLine(@"    Send, {Enter}
    Sleep, 50
Return");
                file.WriteLine(@"
6::
    Send, t
    Sleep, 50
    Send, " + $@"{guna2TextBox6.Text}.");
                file.WriteLine(@"    Send, {Enter}
    Sleep, 50
Return");
                file.WriteLine(@"
7::
    Send, t
    Sleep, 50
    Send, " + $@"{guna2TextBox7.Text}.");
                file.WriteLine(@"    Send, {Enter}
    Sleep, 50
Return");
                file.WriteLine(@"
8::
    Send, t
    Sleep, 50
    Send, " + $@"{guna2TextBox8.Text}.");
                file.WriteLine(@"    Send, {Enter}
    Sleep, 50
Return");
                file.WriteLine(@"
9::
    Send, t
    Sleep, 50
    Send, " + $@"{guna2TextBox9.Text}.");
                file.WriteLine(@"    Send, {Enter}
    Sleep, 50
Return");
                file.WriteLine(@"
0::
    Send, t
    Sleep, 50
    Send, " + $@"{guna2TextBox10.Text}.");
                file.WriteLine(@"    Send, {Enter}
    Sleep, 50
Return");
                
            }
            File.Copy("C:\\ahk\\ahk.txt", "C:\\ahk\\ahk.ahk");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
            info.Arguments = "/c cd C:\\ahk&start ahk.ahk";
            Process.Start(info);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
            info.Arguments = "/c taskkill /f /im AutoHotkey.exe";
            Process.Start(info);
        }
    }
}
