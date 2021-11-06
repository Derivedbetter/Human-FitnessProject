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
    public partial class welcomePage : Form
    {
        public welcomePage()
        {
            InitializeComponent();
        }

        private void welcomePage_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            noButton.Checked = false;
            //nobutton.Checked = false;
        }
        private void yesButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (yesButton1.Checked)
            { intake intake = new intake();
                this.Hide();
                intake.Show();
            }
        }

        private void noButton_CheckedChanged(object sender, EventArgs e)
        {            
            if (noButton.Checked)
            {
                MessageBox.Show("We are very sorry to see you go... but it's not too late to transform your life. Exit this message and push the other button to start YOUR journey!");
                // do something
                noButton.Checked = false;
            }
        }
    }
}
