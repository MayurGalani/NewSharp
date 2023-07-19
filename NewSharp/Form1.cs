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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetTabColor(maintab.SelectedTab, Color.MintCream);
        }
        private void maintab_Selecting(object sender, TabControlCancelEventArgs e)
        {
            SetTabColor(maintab.SelectedTab, SystemColors.Control);

            SetTabColor(e.TabPage, Color.DarkBlue);
        }
        private void SetTabColor(TabPage tab, Color color)
        {
            tab.BackColor = color;
            tab.Refresh();
        }

        private void tdreport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report re = new Report();
            re.Show();
        }

        private void tbdentry_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataEntry re = new DataEntry();
            re.Show();
        }

        private void tbdash_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void tdMasters_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masters ms = new Masters();
            ms.Show();
        }

        private void tdhelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help h = new Help();
            h.Show();
        }

        private void tdsetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings ss = new Settings();
            ss.Show();
        }
    }
}
