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

namespace Load
{
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
        }

        private async void load_Load(object sender, EventArgs e)
        {
            int tt;
            string t;
            for (int i =0;i < 100; i++)
            {
                tt = progressBar1.Value;
                t = Convert.ToString(tt) + "%";
                label1.Text = t;
                progressBar1.PerformStep();
                await Task.Delay(200);
            }
            Process.Start("cleanmgrm.exe");
            Environment.Exit(0);
        }
    }
}
