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
            //BMI function.
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
            //Variable declarations for client info and to calculate BMI.
            string clientweighttext;
            string fullname;
            string clientagetext;
            string dateofbirth;
            string clientheighttext;
            int weight;
            int height;

            //Gather previous input from text file.
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

            //Call BMI function.
            double res = Bmi(weight, height);            
            bmiCalculated.Text = ("Your BMI is " + res.ToString() + "!");

            //Close Text File.
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

        
    }
    }

