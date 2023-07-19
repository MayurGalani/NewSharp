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
    public partial class DataEntry : Form
    {
        bool sidebarExpand;
        bool salesCollapse;
        bool PurchaseCollapse;
        bool BankCollapse;
        bool CashCollapse;
        bool AdditionalCollapse;

        public DataEntry()
        {
            InitializeComponent();
        }

        private void DataEntry_Load(object sender, EventArgs e)
        {

        }

        private void demenuButton_Click(object sender, EventArgs e)
        {
            desidebar.Start();
        }

        private void salestimer_Tick(object sender, EventArgs e)
        {
            if(salesCollapse)
            {
                SalesContainer.Height += 10;
                if(SalesContainer.Height == SalesContainer.MaximumSize.Height)
                {
                    salesCollapse = false;
                    salestimer.Stop();
                }
            }else
            {
                SalesContainer.Height -= 10;
                if (SalesContainer.Height == SalesContainer.MinimumSize.Height)
                {
                    salesCollapse = true;
                    salestimer.Stop();
                }   
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            salestimer.Start();
        }

        private void desidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    desidebar.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    desidebar.Stop();
                }
            }
        }

       
        private void Purchasetimer_Tick(object sender, EventArgs e)
        {
            if (PurchaseCollapse)
            {
                PurchaseContainer.Height += 10;
                if (PurchaseContainer.Height == PurchaseContainer.MaximumSize.Height)
                {
                    PurchaseCollapse = false;
                    Purchasetimer.Stop();
                }
            }
            else
            {
                PurchaseContainer.Height -= 10;
                if (PurchaseContainer.Height == PurchaseContainer.MinimumSize.Height)
                {
                    PurchaseCollapse = true;
                    Purchasetimer.Stop();
                }
            }
        }

        private void Banktimer_Tick(object sender, EventArgs e)
        {
            if (BankCollapse)
            {
                BankContainer.Height += 10;
                if (BankContainer.Height == BankContainer.MaximumSize.Height)
                {
                    BankCollapse = false;
                    Banktimer.Stop();
                }
            }
            else
            {
                BankContainer.Height -= 10;
                if (BankContainer.Height == BankContainer.MinimumSize.Height)
                {
                    BankCollapse = true;
                    Banktimer.Stop();
                }
            }
        }

        private void Cashtimer_Tick(object sender, EventArgs e)
        {
            if (CashCollapse)
            {
                CashContainer.Height += 10;
                if (CashContainer.Height == CashContainer.MaximumSize.Height)
                {
                    CashCollapse = false;
                    Cashtimer.Stop();
                }
            }
            else
            {
                CashContainer.Height -= 10;
                if (CashContainer.Height == CashContainer.MinimumSize.Height)
                {
                    CashCollapse = true;
                    Cashtimer.Stop();
                }
            }
        }

        private void Additionaltimer_Tick(object sender, EventArgs e)
        {
            if (AdditionalCollapse)
            {
                AdditionalContainer.Height += 10;
                if (AdditionalContainer.Height == AdditionalContainer.MaximumSize.Height)
                {
                    AdditionalCollapse = false;
                    Additionaltimer.Stop();
                }
            }
            else
            {
                AdditionalContainer.Height -= 10;
                if (AdditionalContainer.Height == AdditionalContainer.MinimumSize.Height)
                {
                    AdditionalCollapse = true;
                    Additionaltimer.Stop();
                }
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Purchasetimer.Start();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            Banktimer.Start();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            Cashtimer.Start();
        }

        private void btnAdditional_Click(object sender, EventArgs e)
        {
            Additionaltimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
