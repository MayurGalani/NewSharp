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
    public partial class Help : Form
    {
        bool HelpsidebarExpand;
        public Help()
        {
            InitializeComponent();
        }

        private void helpmenuButton_Click(object sender, EventArgs e)
        {
            Helptimer.Start();
        }

        private void Helptimer_Tick(object sender, EventArgs e)
        {
            if (HelpsidebarExpand)
            {
                helpsidebar.Width -= 10;
                if (helpsidebar.Width <= helpsidebar.MinimumSize.Width)
                {
                    HelpsidebarExpand = false;
                    Helptimer.Stop();
                }
            }
            else
            {
                helpsidebar.Width += 10;
                if (helpsidebar.Width >= helpsidebar.MaximumSize.Width)
                {
                    HelpsidebarExpand = true;
                    Helptimer.Stop();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
