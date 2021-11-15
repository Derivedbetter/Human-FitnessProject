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
    public partial class goalsForm : Form
    {
        public goalsForm()
        {
            InitializeComponent();
        }
        public double Bmi(int weight, int height)
        {
            double result = (703 * weight) / (height * height);
            return result;
        }
        private void goalsLabel_Click(object sender, EventArgs e)
        {

        }

        private void backtoparqButton_Click(object sender, EventArgs e)
        {
            parqandwaiver parqandwaiver = new parqandwaiver();
            this.Hide();
            parqandwaiver.Show();
        }

        private void goalsForm_Load(object sender, EventArgs e)
        {

        }

        private void bmiButton_Click(object sender, EventArgs e)
        {
            string clientweighttext;
            string fullname;
            string clientagetext;
            string dateofbirth;
            string clientheighttext;
            int weight;
            int height;
            StreamReader inputFile;
            inputFile = File.OpenText("clientinfo.txt");
            fullname = inputFile.ReadLine();            
            inputFile.ReadLine();
            clientagetext = inputFile.ReadLine();                                  
            dateofbirth = inputFile.ReadLine();            
            inputFile.ReadLine();            
            clientweighttext = inputFile.ReadLine();            
            inputFile.ReadLine();
            clientheighttext = inputFile.ReadLine();            
            int.TryParse(clientweighttext, out weight);
            int.TryParse(clientheighttext, out height);
            double res = Bmi(weight, height);
            bmiCalculated.Text = ("Your BMI is " + res.ToString() + "!");
            inputFile.Close();

        }

        private void explainLabel_Click(object sender, EventArgs e)
        {
            
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            recalcBMIform recalcBMIform = new recalcBMIform();
            this.Hide();
            recalcBMIform.Show();
        }

        /*private void recalcbmiLabel_Click(object sender, EventArgs e)
        {
            string clientheighttext;
            int height;
            int weight;
            StreamReader inputFile;
            inputFile = File.OpenText("clientinfo.txt");
            inputFile.ReadLine();
            inputFile.ReadLine();
            inputFile.ReadLine();
            inputFile.ReadLine();
            inputFile.ReadLine();
            inputFile.ReadLine();
            inputFile.ReadLine();
            clientheighttext = inputFile.ReadLine();
            int.TryParse(clientheighttext, out height);
            newweightBox.Visible = true;
            MessageBox.Show("Please enter in a new weight in lbs!");
            inputFile.Close();

            StreamWriter outputFile;
            outputFile = File.CreateText("newweight.txt");
            string clientWeight = newweightBox.Text;
            outputFile.WriteLine(clientWeight);
            outputFile.Close();

            StreamReader newFile;
            newFile = File.OpenText("newweight.txt");
            string newweigthttext;
            newweigthttext = newFile.ReadLine();
            int.TryParse(newweigthttext, out weight);

            double res = Bmi(weight, height);
            bmiCalculated.Text = ("Your new BMI is " + res.ToString() + "!");
        */
    }
    }

