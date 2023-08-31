using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winFormApplicaton.Models;

namespace DesktopProject
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            state.Items.Add("Province 1");
            state.Items.Add("Province 2");
            state.Items.Add("Province 3");
            state.Items.Add("Province 4");
            state.Items.Add("Province 5");
            Context myContext = new Context();
            var CName = customerName.Text;
            var checkANo = Int32.TryParse(accNo.Text, out int CANo);
            if (CName is null || accNo.Text is null)

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
                    dateofbirth.Value = cus.Date;
                    PhNo.Text = cus.PhoneNumber.ToString();
                    address.Text = cus.Address.ToString();
                    district.Text = cus.District.ToString();
                    var s=cus.State.ToString();
                    state.SelectedItem = cus.State;
                    //state.DisplayMember = s;
                    if (cus.Picture != null && cus.Picture.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(cus.Picture))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    
                    //using (MemoryStream ms = new MemoryStream())
                    //{
                    //    pictureBox1.Image= Image.FromStream(ms);
                    //}
                    var gender=cus.Gender;
                    if (gender == "Male")
                    {
                        male.Checked = true;
                    }
                    else if (gender == "Female")
                    {
                        female.Checked = true;
                    }
                    else 
                    {
                        others.Checked = true;
                    }
                    var marries = cus.MaritalStatus;
                    if (marries == "Married")
                    {
                        married.Checked = true;
                    }
                    else 
                    {
                        unmarried.Checked = true;
                    }
                    mothersName.Text = cus.MotherName;
                    fethersName.Text = cus.FatherName;
                    balance.Text = cus.Balance.ToString();

                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Context myContext=new Context();
            var cus = myContext.AccountDetails.Where(c => c.AccountNo == Convert.ToInt32(accNo.Text)).FirstOrDefault();
            bool isMaleSelected = male.Checked;
            bool isFemaleSelected = female.Checked;
            bool isOtherSelected = others.Checked;
            String gender;

            if (isMaleSelected)
            {
                gender = "Male";
            }
            else if (isFemaleSelected)
            {
                gender = "Female";
            }
            else
            {
                gender = "Others";
            }

            bool isSingle = married.Checked;
            bool isMarried = unmarried.Checked;
            String marriedd;

            if (isSingle)
            {
                marriedd = "Married";
            }
            else
            {
                marriedd = "Unmarried";
            }
            //newCustomer n1 = new newCustomer();
            //var checkBalance =Int32.TryParse(n1.balance.Text, out int balancee);

            //if (checkBalance is false)
            //{
            //    MessageBox.Show("Invalid Balance Entry");
            //}


            cus.AccountNo = Convert.ToInt32(accNo.Text);
            cus.Name = Convert.ToString(customerName.Text);
            cus.DOB = dateofbirth.Value;

            cus.PhoneNumber = PhNo.Text;
            cus.Address = address.Text;
            cus.District = district.Text;
            cus.State = state.Text;

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Choose the appropriate image format
                cus.Picture = ms.ToArray();
            }
            cus.Gender = gender;
            cus.MaritalStatus = marriedd;
            cus.MotherName = mothersName.Text;
            cus.FatherName = fethersName.Text;
            cus.Balance = Convert.ToInt32(balance.Text);
            cus.Date = DateTime.Now;
         
            myContext.SaveChanges();
            MessageBox.Show("Data updated sucessfully");






        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
    }
}






//Context myContext = new Context();
//var CName = customerName.Text;
//var checkANo = Int32.TryParse(accNo.Text, out int CANo);
//if (CName is null || accNo.Text is null)

//{
//    MessageBox.Show("Please enter Name and Account Number");
//}
//else
//{
//    if (checkANo is false)
//    {
//        MessageBox.Show("Invalid Account No");
//    }
//    var cus = myContext.AccountDetails.Where(c => c.AccountNo == CANo && c.Name == CName).FirstOrDefault();
//    if (cus is null)
//    {
//        MessageBox.Show("No Account found with input Name And Account Name");
//    }
//    else
//    {
//        dateofbirth.Text = cus.Date.ToString();
//        PhNo.Text = cus.PhoneNumber.ToString();
//        address.Text = cus.Address.ToString();
//        district.Text = cus.District.ToString();
//        var s = cus.State.ToString();
//        state.DisplayMember = cus.State.ToString();
//        byte[] image = cus.Picture;
//        //using (MemoryStream ms = new MemoryStream())
//        //{
//        //    pictureBox1.Image= Image.FromStream(ms);
//        //}
//        var gender = cus.Gender;
//        if (gender == "Male")
//        {
//            male.Checked = true;
//        }
//        else if (gender == "Female")
//        {
//            female.Checked = true;
//        }
//        else
//        {
//            others.Checked = true;
//        }
//        var marries = cus.MaritalStatus;
//        if (marries == "Married")
//        {
//            married.Checked = true;
//        }
//        else
//        {
//            unmarried.Checked = true;
//        }
//        mothersName.Text = cus.MotherName;
//        fethersName.Text = cus.FatherName;
//        balance.Text = cus.Balance.ToString();

//    }
//}
