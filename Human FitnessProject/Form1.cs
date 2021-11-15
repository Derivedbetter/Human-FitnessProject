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
    Name: Ronald (Tony) Hickman  Date: 11/06/2021   
    Program Description: Intake form for new personal training clients
    Estimated Completion Time: 4 Hours
    Monday 11/01/2021: 2.15 Hours - Initial setup etc
    Tuesday 11/02/2021: 1 Hour    - Add in radio buttons and formatting
    Wednesday 11/03/2021: 2 Hours - Accidentally saved files that caused program to fail
                                    had to figure out how to clone previous version from
                                    Github.
    Friday 11/05/2021: 2 Hours    - Continue to work on fromatting, images, and flow
    Saturday 11/06/2021 5 Hours   - Worked on user inputs, form 2, error handling and
                                    syncing to Github.
        The total time for this program was 12.5 hours. this is over three times my intitial
    estimate. This project took longer than expected for several reasons.
    I grossly underestimated the time required to finish the project. This stems from
    the fact that I have never coded before and I ran into several issues along the way.
    I also implemented more features than originally intended, which pushed development time.
    The first issue that I ran into was getting my images to display properly within
    a picturebox. After much troubleshooting, I solved that problem by changing SizeMode
    to zoom. The second problem I ran into was simple human error. I accidentally changed
    some of my code and saved the change before testing the project. This resulted in
    lost time as I attempted to figure out how to revert back to before the changes.
    Ultimately, I ended up cloning from the depository (which had an earlier version).
    This helped, but still required some rework and resulted in lost time.
    I will have a more realistic timeframe for the next project and I will test more often,
    saving only after a satisfactory test. This will result in much less rework. I also
    have learned many functions and techniques from my mistakes, so hopefully will save
    time by not having to relearn them.
    */
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
                // reengage client
                noButton.Checked = false;
            }
        }
    }
}
