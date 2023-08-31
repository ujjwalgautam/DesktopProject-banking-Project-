using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newCustomer newacc = new newCustomer();
            newacc.MdiParent = this;
            newacc.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllCustomers newacc = new AllCustomers();
            newacc.MdiParent = this;
            newacc.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositCash newacc = new DepositCash();
            newacc.MdiParent = this;
            newacc.Show();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Withdraw newacc = new Withdraw();
            newacc.MdiParent = this;
            newacc.Show();

        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer newacc = new Transfer();
            newacc.MdiParent = this;
            newacc.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statement newacc = new Statement();
            newacc.MdiParent = this;
            newacc.Show();
        }

        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update newacc = new Update();
            newacc.MdiParent = this;
            newacc.Show();
        }
    }
}
