using System.Drawing.Imaging;
using winFormApplicaton.Models;

namespace DesktopProject
{
    public partial class newCustomer : Form
    {
        MemoryStream ms;

        public newCustomer()
        {
            InitializeComponent();
        }

        private void newCustomer_Load(object sender, EventArgs e)
        {
            var acc = 0;
            using Context myContext = new Context();
            var account = myContext.AccountDetails.ToList();
            if (account.LastOrDefault() != null)
            {
                acc = account.LastOrDefault().AccountNo + 1;
            }
            else
                acc = 1000000 + 1;


            accNo.Text = Convert.ToString(acc);
            state.Items.Add("Province 1");
            state.Items.Add("Province 2");
            state.Items.Add("Province 3");
            state.Items.Add("Province 4");
            state.Items.Add("Province 5");

            // Optional: Set a default selected item
            state.SelectedIndex = 0;
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            MemoryStream ms;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                try
                {
                    Image img = Image.FromFile(imagePath);
                    pictureBox1.Image = img;
                    ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            using Context myContext = new Context();
            byte[] imagee;
            bool isMaleSelected = male.Checked;
            bool isFemaleSelected = female.Checked;
            bool isOtherSelected = others.Checked;
            String gender;
            using (MemoryStream ms = new MemoryStream())
            {

                pictureBox1.Image.Save(ms, ImageFormat.Jpeg); // Change the format if necessary
                imagee = ms.ToArray();

            }

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
            if (pictureBox1.Image is null || accNo.Text is null || customerName.Text is null || dateofbirth is null || PhNo is null || address is null || district is null || state is null ||married is null|| gender is null || pictureBox1 is null || mothersName is null || fethersName is null)
            {
                MessageBox.Show("Plese fill in all the fields");
            }
            else
            {
                




                
                //newCustomer n1 = new newCustomer();
                //var checkBalance =Int32.TryParse(n1.balance.Text, out int balancee);

                //if (checkBalance is false)
                //{
                //    MessageBox.Show("Invalid Balance Entry");
                //}



                myContext.Add(new AccountDetails()
                {

                    AccountNo = Convert.ToInt32(accNo.Text),
                    Name = Convert.ToString(customerName.Text),
                    DOB = dateofbirth.Value,

                    PhoneNumber = PhNo.Text,
                    Address = address.Text,
                    District = district.Text,
                    State = state.Text,

                    Picture = imagee,
                    Gender = gender,
                    MaritalStatus = marriedd,
                    MotherName = mothersName.Text,
                    FatherName = fethersName.Text,
                    Balance = Convert.ToInt32(balance.Text),
                    Date = DateTime.Now,
                });
                myContext.SaveChanges();
                MessageBox.Show("Data added sucessfully");
            }


        }

        private void mothersName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


//var myRollNo = Int32.TryParse(txtRoll.Text, out int aRollNo);

//if (myRollNo is false)
//{
//    MessageBox.Show("Invalid Roll No");
//}