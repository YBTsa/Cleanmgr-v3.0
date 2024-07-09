using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logon
{
    public partial class logon : Form
    {
        public logon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                textBox1.Text = "";
                MessageBox.Show("Password is right.","Logon",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Process.Start("load.exe");
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Password isn't right!", "Logon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                
                
            }
        }
      

    }
}
