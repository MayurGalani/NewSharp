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
    public partial class Masters : Form
    {
        bool mssidebarExpand;
        public Masters()
        {
            InitializeComponent();
        }

        private void rpsidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mastertimer_Tick(object sender, EventArgs e)
        {
            if (mssidebarExpand)
            {
                mssidebar.Width -= 10;
                if (mssidebar.Width <= mssidebar.MinimumSize.Width)
                {
                    mssidebarExpand = false;
                    Mastertimer.Stop();
                }
            }
            else
            {
                mssidebar.Width += 10;
                if (mssidebar.Width >= mssidebar.MaximumSize.Width)
                {
                    mssidebarExpand = true;
                    Mastertimer.Stop();
                }
            }
        }

        private void MSmenuButton_Click(object sender, EventArgs e)
        {
            Mastertimer.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
