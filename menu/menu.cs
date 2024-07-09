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
            string temp = Path.GetTempPath();
            if (textBox1.Text == "1")
            {
                Process.Start("cleanmgr.exe");
                textBox1.Text = "";
            }
            else
            {
                if (textBox1.Text == "2")
                {
                    File.Create(temp + "//info.txt");
                    Process p = new Process();
                              
                    p.StartInfo.FileName = "cmd.exe";
    
                    p.StartInfo.RedirectStandardInput = true;
         
                    p.StartInfo.RedirectStandardOutput = true;
             
                    p.StartInfo.RedirectStandardError = true;
                  
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.UseShellExecute = false;
                   
                    p.Start();
                  
                     p.StandardInput.WriteLine("systeminfo>>%temp%//info.txt&exit");

                    p.StandardInput.AutoFlush = true;
            
               
                    p.WaitForExit();
                    p.Close();
                    MessageBox.Show("Info file is in %temp%//info.txt", "Info", 0, MessageBoxIcon.Information);
                    textBox1.Text = "";
                }
                else
                {
                    if (textBox1.Text == "3")
                    {
                        Process a = new Process();

                        a.StartInfo.FileName = "cmd.exe";

                        a.StartInfo.RedirectStandardInput = true;

                        a.StartInfo.RedirectStandardOutput = true;

                        a.StartInfo.RedirectStandardError = true;

                        a.StartInfo.CreateNoWindow = true;

                        a.Start();

                        a.StandardInput.WriteLine("shutdown -r -f -t 30 &exit");

                        a.StandardInput.AutoFlush = true;


                        a.WaitForExit();
                        a.Close();
                        textBox1.Text = "";
                    }
                    else
                    {
                        if (textBox1.Text == "4")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            MessageBox.Show("Error!", "Error", 0, MessageBoxIcon.Error);
                            textBox1.Text = "";
                        }
                    }
                }
            }
        }
    }
}
