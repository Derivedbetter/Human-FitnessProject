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


namespace Human_FitnessProject
{
    public partial class intake : Form
    {
        int clientAge1;
        int clientWeight1;
        int clientHeight1;
                
        public intake()
        {
            InitializeComponent();
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
            if (int.TryParse(ageBox.Text, out clientAge1))
            { }
            else 
            {
                MessageBox.Show("Please type in a valid age!");
            }
            dobBox.Visible = true;
        }

        private void weightBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(weightBox.Text, out clientWeight1))
            { }
            else
            {
                MessageBox.Show("Please type in a valid weight in lbs!");
            }
            heightBox.Visible = true;
        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                clientHeight1 = int.Parse(heightBox.Text);
            }
            catch
            { 
                MessageBox.Show("Please type in a valid Height in inches!");
            }
            genderBox.Visible = true;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            {
                string fullName = nameBox.Text;
                string age = ageBox.Text;
                string birthdate = dobBox.Text;
                string clientWeight = weightBox.Text;
                string clientHeight = heightBox.Text;
                string gender = genderBox.Text;

                StreamWriter outputFile;
                outputFile = File.CreateText("clientinfo.txt");
                outputFile.WriteLine("Client Full Name:" + fullName);
                outputFile.WriteLine("Client Age:");
                outputFile.WriteLine(age);
                outputFile.WriteLine("Client Date of Birth: " + birthdate);
                outputFile.WriteLine("Client Weight in lbs:");
                outputFile.WriteLine(clientWeight);
                outputFile.WriteLine("Client Height in inches:");
                outputFile.WriteLine(clientHeight);
                outputFile.WriteLine("Client Gender: " + gender);
                outputFile.Flush();
                outputFile.Close();

                parqandwaiver parqandwaiver = new parqandwaiver();
                parqandwaiver.ShowDataFromForm2(fullName);
                this.Hide();
                parqandwaiver.Show();
                parqandwaiver.RefTointake = this;
                this.Visible = false;
                parqandwaiver.Show();
            }
        }

        private void save1_Click(object sender, EventArgs e)
        {
            string fullName = nameBox.Text;
            string age = ageBox.Text;
            string birthdate = dobBox.Text;
            string clientWeight = weightBox.Text;
            string clientHeight = heightBox.Text;
            string gender = genderBox.Text;

            StreamWriter outputFile;
            outputFile = File.CreateText("clientinfo.txt");
            outputFile.WriteLine("Client Full Name:" + fullName);
            outputFile.WriteLine("Client Age:");
            outputFile.WriteLine(age);
            outputFile.WriteLine("Client Date of Birth: " + birthdate);
            outputFile.WriteLine("Client Weight in lbs:");
            outputFile.WriteLine(clientWeight);
            outputFile.WriteLine("Client Height in inches:");
            outputFile.WriteLine(clientHeight);
            outputFile.WriteLine("Client Gender: " + gender);
            outputFile.Flush();
            outputFile.Close();


        }

        private void save2_Click(object sender, EventArgs e)
        {
            string fullName = nameBox.Text;
            string age = ageBox.Text;
            string birthdate = dobBox.Text;
            string clientWeight = weightBox.Text;
            string clientHeight = heightBox.Text;
            string gender = genderBox.Text;

            



            StreamWriter outputFile;
            outputFile = File.CreateText("clientinfo.txt");
            outputFile.WriteLine("Client Full Name:" + fullName);          
            outputFile.WriteLine("Client Age:");
            outputFile.WriteLine(age);
            outputFile.WriteLine("Client Date of Birth: " + birthdate);
            outputFile.WriteLine("Client Weight in lbs:");
            outputFile.WriteLine(clientWeight);
            outputFile.WriteLine("Client Height in inches:");
            outputFile.WriteLine(clientHeight);
            outputFile.WriteLine("Client Gender: " + gender);
            outputFile.Flush();
            outputFile.Close();
            

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            ageBox.Visible = true;
        }

        private void dobBox_TextChanged(object sender, EventArgs e)
        {
            weightBox.Visible = true;
        }

        private void genderBox_TextChanged(object sender, EventArgs e)
        {
            nextButton.Visible = true;
        }
    }
}
