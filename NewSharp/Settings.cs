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
    public partial class Settings : Form
    {
        bool sesidebarExpand;
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void Settingtimer_Tick(object sender, EventArgs e)
        {
            if (sesidebarExpand)
            {
                sesidebar.Width -= 10;
                if (sesidebar.Width <= sesidebar.MinimumSize.Width)
                {
                    sesidebarExpand = false;
                    Settingtimer.Stop();
                }
            }
            else
            {
                sesidebar.Width += 10;
                if (sesidebar.Width >= sesidebar.MaximumSize.Width)
                {
                    sesidebarExpand = true;
                    Settingtimer.Stop();
                }
            }
        }

        private void semenuButton_Click(object sender, EventArgs e)
        {
            Settingtimer.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
