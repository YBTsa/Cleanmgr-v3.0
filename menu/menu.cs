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

namespace menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                textBox1.Text = "";
                Process.Start("cleanmgr.exe");
            }
            else
            {
                if (textBox1.Text == "2")
                {
                    textBox1.Text = "";
                    string temp;
                    temp = Path.GetTempPath();
                    File.Create(temp + "//info.txt");
                    File.Create(temp + "//info.txt").Dispose();
                    Process.Start("cmd.exe", "/c systeminfo>>%temp%//info.txt & exit");
                    MessageBox.Show("Info is in " + temp + "//info.txt","Cleanmgr",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    if(textBox1.Text == "3")
                    {
                        textBox1.Text = "";
                        Process.Start("cmd.exe", "/c shutdown -r -f -t 30 & exit");
                    }
                    else
                    {
                        if(textBox1.Text == "4")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            MessageBox.Show("Error!", "Cleanmgr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = "";
                        }
                    }
                }
            }
        }
    }
}
