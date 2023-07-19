using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSharp
{
    public partial class Report : Form
    {
        bool rpsidebarExpand;
        public Report()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (rpsidebarExpand)
            {
                rpsidebar.Width -= 10;
                if (rpsidebar.Width <= rpsidebar.MinimumSize.Width)
                {
                    rpsidebarExpand = false;
                    rpsidebartimer.Stop();
                }
            }
            else
            {
                rpsidebar.Width += 10;
                if(rpsidebar.Width >= rpsidebar.MaximumSize.Width)
                {
                    rpsidebarExpand = true;
                    rpsidebartimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            rpsidebartimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pbBacktoHome_Click(object sender, EventArgs e)
        {

        }

        private void rpsidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}