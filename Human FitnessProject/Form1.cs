using System;
using System.Windows.Forms;

namespace Human_FitnessProject
{


    public partial class welcomePage : Form
    {
        public welcomePage()
        {
            InitializeComponent();
        }

        private void welcomePage_Load(object sender, EventArgs e)
        {

        }
        
        private void yesButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (yesButton1.Checked)
            { 
                intake intake = new intake();
                this.Hide();
                intake.Show();
            }
        }

        
        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void startLabel_Click(object sender, EventArgs e)
        {

        }

        private void sameShirt_Click(object sender, EventArgs e)
        {

        }

        private void difMan_Click(object sender, EventArgs e)
        {

        }
    }
}
