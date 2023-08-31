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
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            Context myContext = new Context();
            var CName = name.Text;
            var checkANo=Int32.TryParse(ANo.Text,out int CANo);
            if (CName is null || ANo.Text is null)
            
            {
                MessageBox.Show("Please enter Name and Account Number");
            }
            else
            {
                if (checkANo is false)
                {
                    MessageBox.Show("Invalid Account No");
                }
                var cus = myContext.AccountDetails.Where(c => c.AccountNo == CANo && c.Name == CName).FirstOrDefault();
                if (cus is null)
                {
                    MessageBox.Show("No Account found with input Name And Account Name");
                }
                else
                {
                    balance.Text = cus.Balance.ToString();
                    var s1 = myContext.Deposit.Where(c => c.AccountNo == CANo).Select(c => new { c.Date, c.Mode, c.DipAmount }).ToList();

                    var s2 = myContext.Debit.Where(c => c.AccountNo == CANo).Select(c => new{c.Date, c.Mode, c.DebAmount}).ToList();
                    var s3 = myContext.Transfer.Where(c => c.AccountNo == CANo).Select(c => new {c.Date,TO = c.ToTransfer ,Amount=c.TAmountt}).ToList();
                    var s4 = myContext.Transfer.Where(c => c.ToTransfer == CANo).Select(c => new {c.Date,From = c.AccountNo ,Amount=c.TAmountt}).ToList();
                    Deposit.DataSource = s1;
                    withdraw.DataSource = s2;
                    sent.DataSource = s3;
                    received.DataSource = s4;
                }
            }
            
        }

        private void Statement_Load(object sender, EventArgs e)
        {

        }

        private void received_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void withdraw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


//var myRollNo = Int32.TryParse(txtRoll.Text, out int aRollNo);

//if (myRollNo is false)
//{
//    MessageBox.Show("Invalid Roll No");
//}