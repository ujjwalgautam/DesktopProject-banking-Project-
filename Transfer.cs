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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            Context myContext = new Context();
            var acountNum=0;
            try
            {
                acountNum = Convert.ToInt32(SAccNo.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Senders Account Number");
            }
            
            var AccountName = SName.Text;
            if (AccountName == null)
            {
                MessageBox.Show("Please fill Senders Name");
            }
            var accounts = myContext.AccountDetails.Where(c => c.AccountNo == acountNum && c.Name == AccountName).FirstOrDefault();
            if (accounts != null)
            {
                CBalance.Text = accounts.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Senders Accounts not found with given Account Number and Name");
            }

            var acountNumR = 0;
            try
            {
                acountNumR = Convert.ToInt32(SAccNo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Receivers Account Number");
            }

            var AccountNameR = SName.Text;
            if (AccountName == null)
            {
                MessageBox.Show("Please fill Receivers Name");
            }
            var accountsR = myContext.AccountDetails.Where(c => c.AccountNo == acountNumR && c.Name == AccountNameR).FirstOrDefault();
            if (accounts == null)
            {
                MessageBox.Show("Senders Accounts not found with given Account Number and Name");
            }
            
        }

        private void TransferA_Click(object sender, EventArgs e)
        {
            Context myContext = new Context();
             myContext.Transfer.Add(new Transferr()
            {

                Date = DateTime.Now,
                AccountNo = Convert.ToInt32(SAccNo.Text),
                Name = SName.Text,
                TAmountt = Convert.ToInt32(TAmount.Text),
                ToTransfer = Convert.ToInt32(RAccNo.Text),
                ToName=RName.Text,
            });
            if (Convert.ToInt32(CBalance.Text) >= Convert.ToInt32(TAmount.Text))
            {
                var accNumm = Convert.ToInt32(SAccNo.Text);
                var account = myContext.AccountDetails.Where(c => c.AccountNo == accNumm).FirstOrDefault();
                if (account != null)
                {
                    account.Balance -= Convert.ToInt32(TAmount.Text);
                }
                var accNummT = Convert.ToInt32(RAccNo.Text);
                var accountT = myContext.AccountDetails.Where(c => c.AccountNo == accNummT).FirstOrDefault();
                if (accountT != null)
                {
                    accountT.Balance += Convert.ToInt32(TAmount.Text);
                }
                myContext.SaveChanges();
                MessageBox.Show("Transfer Sucessful");
            }
            else
            {
                MessageBox.Show("Insufficient Amount");
            }

            

        }
    }
}
