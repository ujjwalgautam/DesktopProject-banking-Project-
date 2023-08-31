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
    public partial class AllCustomers : Form
    {
        public AllCustomers()
        {
            InitializeComponent();
        }

        private void AllCustomers_Load(object sender, EventArgs e)
        {
            using Context myContext = new Context();
            var data = myContext.AccountDetails.ToList();
            dataAllCustomers.DataSource = data;
            dataAllCustomers.Columns["Id"].Visible = false;
            dataAllCustomers.Columns["Picture"].Visible = false;
            dataAllCustomers.Columns["Address"].Visible = false;
            dataAllCustomers.Columns["State"].Visible = false;
            dataAllCustomers.Columns["Date"].Visible = false;
            dataAllCustomers.Columns["MaritalStatus"].Visible = false;
            dataAllCustomers.Columns["Gender"].Visible = false;

        }
    }
}
