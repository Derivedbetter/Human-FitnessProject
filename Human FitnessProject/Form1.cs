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
{   /*
    Name: Ronald (Tony) Hickman  Date: 11/21/2021   
    Program Description: Assignment: Final Project - Incremental Deliverables Due 22Nov21
    Estimated Completion Time: 20 Hours
    Monday 11/15/2021: 2.5 Hours - Add datetimepicker, clean up welcomeForm code
    Tuesday 11/16/2021: 1 Hour    - Install iText and research to understand and implement
    Thursday 11/18/2021: 8 Hours - Continue to configure pdfs, implement itext
                                    through research, trial and error, and heavy reading
                                    until the ahhah moment.
    Friday 11/19/2021: 8 Hours   - Fully implement iText. Write code to gather user input,
                                    fill out pdfs, and add process to print/save pdf to clients
                                    computer. Work on transferring data from one form to the next.
    Saturday 11/20/2021 4 Hours   - Clean up all aspects of code. Remove code comments
                                    from unseccessful coding attempts. Document methods
                                    where applicable.
    Sunday 11/21/2021   4 Hours   - Add string functions. Verify code is ready to submit.
                                    Push to repository.
        The total time for this program was 27.5 hours. this is closer to my initial
    estimate than any previous attempt. I am starting to intuitively grasp the structure
    of C#, variable declaration, and methods. This is having an exponential effect upon
    my research and the implementation of solutions that I am able to find. I'm beginning
    to understand what the code means instead of just using snippets as a means to an end.
    I have also been able to test and save more often with less time spent on rewrites and
    back tracking. This took a little longer than expected because I've also spent a great
    deal of time cleaning up my code, changing various methods to more elegant (in my mind)
    and more effective alternatives. */


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

        private void noButton_CheckedChanged(object sender, EventArgs e)
        {            
            if (noButton.Checked)
            {
                MessageBox.Show("We are very sorry to see you go... but it's not too late to transform your life. Exit this message and push the other button to start YOUR journey!");
                // reengage client
                noButton.Checked = false;
            }
        }
    }
}
