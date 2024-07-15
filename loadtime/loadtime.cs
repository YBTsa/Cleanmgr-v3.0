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

namespace loadtime
{
    public partial class loadtime : Form
    {
        public loadtime()
        {
            InitializeComponent();
        }

        private async void loadtime_Load(object sender,EventArgs e)
        {
            int intvalue;
            string strvalue;
            for(int i =0;i < 100; i++)
            {
                await Task.Delay(300);
                progressBar1.PerformStep();
                intvalue = progressBar1.Value;
                strvalue = Convert.ToString(intvalue) + "%";
                label1.Text = strvalue;
            }
            Process.Start("cleanmgrm.exe");
            Environment.Exit(0);
        } 
    }
}
