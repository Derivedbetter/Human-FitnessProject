using iText.Forms.Fields;
using iText.Forms;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.IO;

namespace Human_FitnessProject
{
    public partial class parQ2form : Form
    {
        
        public parQ2form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            MyList();            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        
        }
        
        //Initial variable declarations for iText.
        public static String src = "parQFilled.pdf";
        public static String dest = "parQFilled2.pdf";
        public static String fields;

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
            inputFile.ReadLine();
            inputFile.ReadLine();
            string clientheighttext = inputFile.ReadLine();
            inputFile.ReadLine();
            string clientEmail = inputFile.ReadLine();
            clientInfo.Add($"{ fullName }");
            clientInfo.Add($"{ clientheighttext }");
            clientInfo.Add($"{ clientEmail.ToLower() }");
            this.nameBox.Text = clientInfo[0];
            this.emailBox.Text = clientInfo[2];
            this.dateBox2.Text = DateTime.Today.ToString("d");
        }
        
    private void button1_Click_1(object sender, EventArgs e)
        {
            //fill in second page of pdf
            PdfDocument pdf =
            new PdfDocument(new PdfReader(src), new PdfWriter(dest));
            PdfAcroForm acroForm = PdfAcroForm.GetAcroForm(pdf, true);
            IDictionary<String, PdfFormField> fields = acroForm.GetFormFields();
            PdfFormField toSet;

            


            fields.TryGetValue("name", out toSet);
            toSet.SetValue($" {nameBox.Text} ");

            fields.TryGetValue("Email", out toSet);
            toSet.SetValue($" {emailBox.Text} ");

            fields.TryGetValue("date", out toSet);
            toSet.SetValue($" {dateBox2.Text} ");




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
                FileName = "parQFilled2.pdf"
            };
            p.Start();

            //return to parq and waiver form
            parqandwaiver parqandwaiver = new parqandwaiver();
            this.Hide();
            parqandwaiver.Show();
        }

        private void parQ2form_Load(object sender, EventArgs e)
        {

        }

        private void backtopage1_Click(object sender, EventArgs e)
        {
            parQ1form parQ1form = new parQ1form();
            this.Hide();
            parQ1form.Show();
        }
        private static Regex email_validation()
        {
            //email validation method
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        //Call to email vlidation.
        static Regex validate_emailaddress = email_validation();

        private void saveInfo_Click(object sender, EventArgs e)
        {
            //Check validity of email input.
            if (validate_emailaddress.IsMatch(emailBox.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                emailBox.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(nameBox.Text))
            {
                    MessageBox.Show("Did you forget your name? Please type in your name!");
            }            
            else
            {
                MessageBox.Show("Email Address is valid and you have a name! Awesome job!");
                submitandforward.Visible = true;

            }
            
        }

        public void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
