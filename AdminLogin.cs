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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            Context  context = new Context();
            
            if(textAdminUserName.Text!=string.Empty && textAdminPassword.Text != string.Empty)
            {
                var admin = context.AdminLogin.Where(c => c.UserName == textAdminUserName.Text && c.Password == textAdminPassword.Text).FirstOrDefault();
                if(admin != null)
                {
                    Menu m1=new Menu();
                    m1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Usename or password");
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password");
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            textAdminUserName.Clear();
        }
    }
}
