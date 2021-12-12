using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Human_FitnessProject
{
    public partial class recalcBMIform : Form
    {
        public recalcBMIform()
        {
            InitializeComponent();
            MyList();
        }
        public void MyList()
        {
            //Gather previous input from text file.
            List<string> clientInfo = new List<string>();
            StreamReader inputFile;
            inputFile = File.OpenText("clientinfo.txt");
            inputFile.ReadLine();
            string fullName = inputFile.ReadLine();
            inputFile.ReadLine();
            inputFile.ReadLine();
            inputFile.ReadLine();
            inputFile.ReadLine();
            string clientWeight = inputFile.ReadLine();
            inputFile.ReadLine();
            string clientheighttext = inputFile.ReadLine();
            inputFile.ReadLine();
            string clientEmail = inputFile.ReadLine();
            inputFile.ReadLine();
            string clientPhoneNumber = inputFile.ReadLine();

            clientInfo.Add($"{ fullName }");
            clientInfo.Add($"{ clientheighttext }");
            clientInfo.Add($"{ clientEmail.ToLower() }");
            clientInfo.Add($"{ clientPhoneNumber }");
            clientInfo.Add($"{ clientWeight }");

            this.newheightBox.Text = clientInfo[1];
            this.newweightBox.Text = clientInfo[4];
            
        }
        
        public double Bmi(int weight, int height)
        {
            //Call BMI function.
            double result = (703 * weight) / (height * height);
            return result;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void bmiButton_Click(object sender, EventArgs e)
        {
            //Variable declarations for recalculation.                        
            int clientWeight1;
            int clientheight1;
            {
                //Check status and validity of textboxes.
                if (int.TryParse(newweightBox.Text, out clientWeight1))
                { }
                else
                {
                    MessageBox.Show("Please type in a valid weight in lbs!");
                    clientWeight1 = 1;

                }
                if (int.TryParse(newheightBox.Text, out clientheight1))
                { }
                else
                {
                    MessageBox.Show("Please type in a valid height in inches!");
                    clientheight1 = 1;
                }
                while ((clientWeight1 == 1) || (clientheight1 == 1))
                {
                    MessageBox.Show("If you want to recalculate please enter new weight and re-enter height!");
                    //Clear out info in textBoxes.
                    newheightBox.Text = "";
                    newweightBox.Text = "";
                    //Set value of height and weight to 10 (unrealistic number)
                    //in order to continue loop.
                    clientheight1 = 10;
                    clientWeight1 = 10; //end loop                   
                }
                if ((clientWeight1 == 10) || (clientheight1 == 10))
                {
                    double res = Bmi(clientWeight1, clientheight1);
                    bmiCalculated.Text = ("Your BMI is not quite right. Try again with height and new weight !");
                }
                else
                {
                    double res = Bmi(clientWeight1, clientheight1);
                    bmiCalculated.Text = ("Your BMI is " + res.ToString() + "!");
                }
            }
        }
        
        private void explainLabel_Click(object sender, EventArgs e)
        {

        }

        private void gobackButton_Click(object sender, EventArgs e)
        {
            goalsForm goalsForm = new goalsForm();
            this.Hide();
            goalsForm.Show();
        }

        private void bmiPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newweightBox_TextChanged(object sender, EventArgs e)
        {
            StreamReader inputFile;
            inputFile = File.OpenText("clientinfo.txt");
            inputFile.ReadLine();
            string fullName = inputFile.ReadLine();
            inputFile.ReadLine();
            inputFile.ReadLine();
            inputFile.ReadLine();
            inputFile.ReadLine();
            string clientWeight = inputFile.ReadLine();
            if (clientWeight.Equals(newweightBox.Text))
                MessageBox.Show("This is your current weight! To recalculate BMI " +
                "enter a new weight", "Invalid", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            clientWeight = "";
            newweightBox.Focus();
        }

        private void goalsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
