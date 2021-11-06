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

        }

        private void weightBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(weightBox.Text, out clientWeight1))
            { }
            else
            {
                MessageBox.Show("Please type in a valid weight in lbs!");
            }
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
        }
    }
}
