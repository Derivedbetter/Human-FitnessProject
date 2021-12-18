using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO;
using iText.Kernel.Pdf;
using iText.Signatures;
using iText.Forms;
using iText.Commons;
using iText.Layout;
using iText.Svg;
using iText.Forms.Fields;
using iText.StyledXmlParser;
using System.Diagnostics;

namespace Human_FitnessProject
{
    public partial class GoalsPDFform : Form
    {
        public GoalsPDFform()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //declare variables for iText
        public static String src = "ClientGoals.pdf";
        public static String dest = "ClientGoalsFilled.pdf";
        public static String fields;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            goalsForm goalsForm = new goalsForm();
            this.Hide();
            goalsForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(goalPriority1Box.Text))
            {
                MessageBox.Show("Please enter your first priority fitness goal!");
                goalPriority1Box.Focus();
            }
            else if (String.IsNullOrEmpty(goalPriority2Box.Text))
            {
                MessageBox.Show("Please enter your second priority fitness goal!");
                goalPriority2Box.Focus();
            }
            else if (String.IsNullOrEmpty(goalPriority3Box.Text))
            {
                MessageBox.Show("Please enter your third priority fitness goal!");
                goalPriority3Box.Focus();
            }
            else if (String.IsNullOrEmpty(howWillYouFeelBox.Text))
            {
                MessageBox.Show("Please tell us how you will feel" +
                    " once you complete your fitness goals!");
                howWillYouFeelBox.Focus();
            }
            else if (String.IsNullOrEmpty(mostImportantBox.Text))
            {
                MessageBox.Show("Please tell us the most important thing we can" +
                    " do to help you complete your fitness goals!");
                mostImportantBox.Focus();
            }
            else if (String.IsNullOrEmpty(outlineBox.Text))
            {
                MessageBox.Show("Please provide an outline of obstacles that you feel " +
                    " wiil be in your path to complete your fitness goals!");
                outlineBox.Focus();
            }
            else if (String.IsNullOrEmpty(methodABox.Text))
            {
                MessageBox.Show("Please provide your first method to overcome these " +
                    "obstacles!");
                methodABox.Focus();
            }
            else if (String.IsNullOrEmpty(methodBBox.Text))
            {
                MessageBox.Show("Please provide your second method to overcome these " +
                    "obstacles!");
                methodBBox.Focus();
            }
            else if (String.IsNullOrEmpty(methodCBox.Text))
            {
                MessageBox.Show("Please provide your third method to overcome these " +
                    "obstacles!");
                methodCBox.Focus();
            }
            //check status of groupboxes
            else if (groupBox1.Controls.OfType<RadioButton>().Any(x => x.Checked)
                && groupBox2.Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                // at least one radiobutton in all groupBoxes are checked
                printButton.Visible = true;
            }
            else
            {
                //Call for client to take a look at the check boxes.
                MessageBox.Show("It looks like you forgot to check a box or two. " +
                    "Please review the questions and answer appropriately!");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            {
                //fill in pdf
                PdfDocument pdf =
                new PdfDocument(new PdfReader(src), new PdfWriter(dest));
                PdfAcroForm acroForm = PdfAcroForm.GetAcroForm(pdf, true);
                IDictionary<String, PdfFormField> fields = acroForm.GetFormFields();
                PdfFormField toSet;

                //check status of radioButtons and check boxes
                if (LoseBodyFat.Checked == true)
                {
                    fields.TryGetValue("losebf", out toSet);
                    toSet.SetValue("Yes");
                }

                if (DevelopMuscleTone.Checked == true)
                {
                    fields.TryGetValue("devmuscle", out toSet);
                    toSet.SetValue("Yes");
                }

                if (RehabInjury.Checked == true)
                {
                    fields.TryGetValue("rehab", out toSet);
                    toSet.SetValue("Yes");
                }

                if (NutritionEducation.Checked == true)
                {
                    fields.TryGetValue("nutrition", out toSet);
                    toSet.SetValue("Yes");
                }

                if (StartExProgram.Checked == true)
                {
                    fields.TryGetValue("start", out toSet);
                    toSet.SetValue("Yes");
                }

                if (DesignAdvanced.Checked == true)
                {
                    fields.TryGetValue("design", out toSet);
                    toSet.SetValue("Yes");
                }

                if (Safety.Checked == true)
                {
                    fields.TryGetValue("safety", out toSet);
                    toSet.SetValue("Yes");
                }

                if (SportsTraining.Checked == true)
                {
                    fields.TryGetValue("sport", out toSet);
                    toSet.SetValue("Yes");
                }

                if (Hypertrophy.Checked == true)
                {
                    fields.TryGetValue("hypertrophy", out toSet);
                    toSet.SetValue("Yes");
                }

                if (Fun.Checked == true)
                {
                    fields.TryGetValue("fun", out toSet);
                    toSet.SetValue("Yes");
                }

                if (Motivation.Checked == true)
                {
                    fields.TryGetValue("motivation", out toSet);
                    toSet.SetValue("Yes");
                }

                if (lowPriorityButton.Checked == true)
                {
                    fields.TryGetValue("lp", out toSet);
                    toSet.SetValue("Yes");
                }

                if (mediumPriorityButton.Checked == true)
                {
                    fields.TryGetValue("mp", out toSet);
                    toSet.SetValue("Yes");
                }

                if (highPriorityButton.Checked == true)
                {
                    fields.TryGetValue("hp", out toSet);
                    toSet.SetValue("Yes");
                }
                if (veryButton.Checked == true)
                {
                    fields.TryGetValue("very", out toSet);
                    toSet.SetValue("Yes");
                }

                if (semiButton.Checked == true)
                {
                    fields.TryGetValue("semi", out toSet);
                    toSet.SetValue("Yes");
                }

                if (notVeryButton.Checked == true)
                {
                    fields.TryGetValue("notvery", out toSet);
                    toSet.SetValue("Yes");
                }


                fields.TryGetValue("othergoals", out toSet);
                toSet.SetValue($" {otherGoalsBox.Text} ");

                fields.TryGetValue("priority1", out toSet);
                toSet.SetValue($" {goalPriority1Box.Text} ");

                fields.TryGetValue("priority2", out toSet);
                toSet.SetValue($" {goalPriority2Box.Text} ");

                fields.TryGetValue("priority4", out toSet);
                toSet.SetValue($" {goalPriority3Box.Text} ");

                fields.TryGetValue("feel1", out toSet);
                toSet.SetValue($" {howWillYouFeelBox.Text} ");

                fields.TryGetValue("mostimportant", out toSet);
                toSet.SetValue($" {mostImportantBox.Text} ");

                fields.TryGetValue("obstacles", out toSet);
                toSet.SetValue($" {outlineBox.Text} ");

                fields.TryGetValue("method1", out toSet);
                toSet.SetValue($" {methodABox.Text} ");

                fields.TryGetValue("method2", out toSet);
                toSet.SetValue($" {methodBBox.Text} ");

                fields.TryGetValue("method3", out toSet);
                toSet.SetValue($" {methodCBox.Text} ");



                pdf.Close();

                //message box to client, readying them for the document being saved.
                MessageBox.Show("You will now be prompted to save this pdf. Please save" +
                    " and print this form. Sign and return to your trainer at or before your" +
                    " first appointment.");

                //Save file to print
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo()
                {
                    CreateNoWindow = true,
                    Verb = "print",
                    FileName = "ClientGoalsFilled.pdf"
                };
                p.Start();

                //return to parq and waiver form
                goalsForm goalsForm = new goalsForm();
                this.Hide();
                goalsForm.Show();
            }
        }

        private void GoalsPDFform_Load(object sender, EventArgs e)
        {

        }
    }
}
