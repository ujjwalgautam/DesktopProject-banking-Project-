using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winFormApplicaton.Models;

namespace DesktopProject
{
    public partial class DepositCash : Form
    {
        public DepositCash()
        {
            InitializeComponent();
        }

        private void ckeck_Click(object sender, EventArgs e)
        {
            Context myContext = new Context();
            var acountNum = Convert.ToInt32(accNum.Text);
            var AccountName=accName.Text;
            var accounts=myContext.AccountDetails.Where(c=>c.AccountNo==acountNum && c.Name==AccountName).FirstOrDefault();
            if (accounts != null)
            {
                OldBlc.Text = accounts.Balance.ToString();
            }
            else
            {
                MessageBox.Show("No Accounts found with given Account Number and Name");
            }
        }

        private void DepositCash_Load(object sender, EventArgs e)
        {
            mode.Items.Add("Cash");
            mode.Items.Add("Cheque");
            
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            Context myContext=new Context();
            myContext.Deposit.Add(new Depositt()
            {
                Date= DateTime.Now,
                AccountNo=Convert.ToInt32(accNum.Text),
                Name=accName.Text,
                OldBalance=Convert.ToInt32(OldBlc.Text),
                Mode=mode.Text,
                DipAmount=Convert.ToInt32(depositAmount.Text),
            });
            var accNumm = Convert.ToInt32(accNum.Text);
            var account=myContext.AccountDetails.Where(c=>c.AccountNo==accNumm).FirstOrDefault();
            if(account != null)
            {
                account.Balance += Convert.ToInt32(depositAmount.Text);
            }
            myContext.SaveChanges();
            MessageBox.Show("Deposit Sucessful");
        }
    }
}
