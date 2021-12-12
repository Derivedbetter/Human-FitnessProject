using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Human_FitnessProject
{
    public partial class intake : Form
    {
        //Initial variable declarations.
        int clientWeight1;
        int clientHeight1;
                
        public intake()
        {
            
            InitializeComponent();
            nameBox.Focus();

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            welcomePage welcomePage = new welcomePage();
            this.Hide();
            welcomePage.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void initinfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attribPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void intake_Load(object sender, EventArgs e)
        {

        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {            
            dateOfBirthPicker.Visible = true;
        }
        //Make subsequent textBoxes visible.
        private void weightBox_TextChanged(object sender, EventArgs e)
        {            
            heightBox.Visible = true;
        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {
            genderBox.Visible = true;
        }
        

        private void nextButton_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("Did you forget your name? Please type in your name!");
            }


            if (int.TryParse(weightBox.Text, out clientWeight1))
            { }
            else
            {
                MessageBox.Show("Please type in a valid weight in lbs!");
            }


            try
            {
                clientHeight1 = int.Parse(heightBox.Text);
            }
            catch
            {
                MessageBox.Show("Please type in a valid Height in inches!");
            }


            if (String.IsNullOrEmpty(genderBox.Text))
            {
                MessageBox.Show("Please type in your gender!");
            }

            //Variable declarations for StreamWriter.
            string fullName = nameBox.Text;
            string email = emailBox.Text;
            string phoneNumber = phoneNumberBox.Text;
            int age = DateTime.Today.Year - dateOfBirthPicker.Value.Year;
            string clientAge = age.ToString();
            string clientWeight = weightBox.Text;
            string clientHeight = heightBox.Text;
            string gender = genderBox.Text;

            //Write client entered data into text file.
            StreamWriter outputFile;
            outputFile = File.CreateText("clientinfo.txt");
            outputFile.WriteLine("Client Full Name:");
            outputFile.WriteLine(fullName);
            outputFile.WriteLine("Client Age:");
            outputFile.WriteLine(clientAge);
            string birthdate = dateOfBirthPicker.Value.ToString();
            outputFile.WriteLine("Client Date of Birth: " + birthdate);
            outputFile.WriteLine("Client Weight in lbs:");
            outputFile.WriteLine(clientWeight);
            outputFile.WriteLine("Client Height in inches:");
            outputFile.WriteLine(clientHeight);
            outputFile.WriteLine("Client email address:");
            outputFile.WriteLine(email);
            outputFile.WriteLine("Client telephone number:");
            outputFile.WriteLine(phoneNumber);
            outputFile.WriteLine("Client Gender: " + gender);
            outputFile.Flush();
            outputFile.Close();

            //Get data from form2.
            parqandwaiver parqandwaiver = new parqandwaiver();
            parqandwaiver.ShowDataFromForm2(fullName.ToUpper());
            this.Hide();
            parqandwaiver.Show();

            parqandwaiver.RefTointake = this;
            this.Visible = false;
            parqandwaiver.Show();
        }
        private static Regex email_validation()//Validates email address.
        {
            //email validation method
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        public static Regex validTelephoneNo()
        {
            string pattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        //Call to email vlidation.
        static Regex validate_emailaddress = email_validation();
        //Call to phone number validation.
        static Regex validate_phonenumber = validTelephoneNo();
        private void save1_Click(object sender, EventArgs e)
        {
            //Check validity of email input.
            if (validate_emailaddress.IsMatch(emailBox.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                emailBox.Focus();
                return;
            }

            //Check validity of phone number.            
            if (validate_phonenumber.IsMatch(phoneNumberBox.Text) != true)
            {
                MessageBox.Show("Invalid phone number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                phoneNumberBox.Focus();
                return;
            }


            //Check status of nameBox.
            
            if  (String.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("Did you forget your name? Please type in your name!");
            }

            //Check validity of birthdate.
            if (dateOfBirthPicker.Value.Year > 2007)
            {
                MessageBox.Show("Invalid Age! You are not old enough to train with us." +
                    " If this is a mistake please enter a valid age."
                    , "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateOfBirthPicker.Focus();
            }
            else weightBox.Visible = true;

            //Variable declarations for StreamWriter.
            string fullName = nameBox.Text;
            string email = emailBox.Text;
            string phoneNumber = phoneNumberBox.Text;
            int age = DateTime.Today.Year - dateOfBirthPicker.Value.Year;
            string clientAge = age.ToString();
            string clientWeight = weightBox.Text;
            string clientHeight = heightBox.Text;
            string gender = genderBox.Text;

            //Write client entered data into text file.
            StreamWriter outputFile;
            outputFile = File.CreateText("clientinfo.txt");
            outputFile.WriteLine("Client Full Name:");
            outputFile.WriteLine(fullName);
            outputFile.WriteLine("Client Age:");
            outputFile.WriteLine(age);
            string birthdate = dateOfBirthPicker.Value.ToString();
            outputFile.WriteLine("Client Date of Birth: " + birthdate);
            outputFile.WriteLine("Client Weight in lbs:");
            outputFile.WriteLine(clientWeight);
            outputFile.WriteLine("Client Height in inches:");
            outputFile.WriteLine(clientHeight);
            outputFile.WriteLine("Client email address:");
            outputFile.WriteLine(email);
            outputFile.WriteLine("Client telephone number:");
            outputFile.WriteLine(phoneNumber);
            outputFile.WriteLine("Client Gender: " + gender);
            outputFile.Flush();
            outputFile.Close();

            save2.Visible = true;

        }
        //Check status of boxes filled.
        private void save2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("Did you forget your name? Please type in your name!");
            }


            if (int.TryParse(weightBox.Text, out clientWeight1))
            { }
            else
            {
                MessageBox.Show("Please type in a valid weight in lbs!");
            }


            try
            {
                clientHeight1 = int.Parse(heightBox.Text);
            }
            catch
            {
                MessageBox.Show("Please type in a valid Height in inches!");
            }


            if (String.IsNullOrEmpty(genderBox.Text))
            {
                MessageBox.Show("Please type in your gender!");
            }


            //Variable declarations for StreamWriter.
            string fullName = nameBox.Text;
            string email = emailBox.Text;
            string phoneNumber = phoneNumberBox.Text;
            int age = DateTime.Today.Year - dateOfBirthPicker.Value.Year;
            string clientAge = age.ToString();
            string clientWeight = weightBox.Text;
            string clientHeight = heightBox.Text;
            string gender = genderBox.Text;

            //Write client entered data into text file.
            StreamWriter outputFile;
            outputFile = File.CreateText("clientinfo.txt");
            outputFile.WriteLine("Client Full Name:");
            outputFile.WriteLine(fullName);
            outputFile.WriteLine("Client Age:");
            outputFile.WriteLine(clientAge);
            string birthdate = dateOfBirthPicker.Value.ToString();
            outputFile.WriteLine("Client Date of Birth: " + birthdate);
            outputFile.WriteLine("Client Weight in lbs:");
            outputFile.WriteLine(clientWeight);
            outputFile.WriteLine("Client Height in inches:");
            outputFile.WriteLine(clientHeight);
            outputFile.WriteLine("Client email address:");
            outputFile.WriteLine(email);
            outputFile.WriteLine("Client telephone number:");
            outputFile.WriteLine(phoneNumber);
            outputFile.WriteLine("Client Gender: " + gender);
            outputFile.Flush();
            outputFile.Close();



        }
        //Make subsequent boxes visible.
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            emailBox.Visible = true;
            
        }

        private void dobBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void genderBox_TextChanged(object sender, EventArgs e)
        {
            save2.Visible = true;
            nextButton.Visible = true;
        }

        public void dateOfBirthPicker_ValueChanged(object sender, EventArgs e)
        { 
        
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void clientEmail_Click(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            phoneNumberBox.Visible = true;
        }

        private void phoneNumberBox_TextChanged(object sender, EventArgs e)
        {
            dateOfBirthPicker.Visible = true;
        }
    }

    
}

    
    



