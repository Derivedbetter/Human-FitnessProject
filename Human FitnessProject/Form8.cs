using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_FitnessProject
{
    public partial class recalcBMIform : Form
    {
        public recalcBMIform()
        {
            InitializeComponent();
        }
        public double Bmi(int weight, int height)
        {
            double result = (703 * weight) / (height * height);
            return result;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void bmiButton_Click(object sender, EventArgs e)
        {
            int clientWeight1;
            int clientheight1;
            {
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
                while ((clientWeight1 == 1)||(clientheight1 ==1)) 
                {
                    MessageBox.Show("If you want to recalculate please enter new weight and height!");
                    newheightBox.Text = "";
                    newweightBox.Text = "";
                    clientheight1 = 10;
                    clientWeight1 = 10; //end loop                   
                }
                if ((clientWeight1 == 10) || (clientheight1 == 10))
                {
                    double res = Bmi(clientWeight1, clientheight1);
                    bmiCalculated.Text = ("Your BMI is not quite right. Try again with new height and weight !");
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
    }
}
