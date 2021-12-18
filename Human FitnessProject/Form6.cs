using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Forms.Fields;
using iText.Forms;
using iText.Kernel.Pdf;
using System.Diagnostics;

namespace Human_FitnessProject
{
    public partial class waiverForm : Form
    {
        public waiverForm()
        {
            InitializeComponent();
            MyList();
            addressBox1.Focus();
        }

        private void waiverForm_Load(object sender, EventArgs e)
        {

        }
        //Initial variable declarations for iText.
        public static String src = "CoachingWaiver.pdf";
        public static String dest = "CoachingWaiver2.pdf";
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
            inputFile.ReadLine();
            string clientPhoneNumber = inputFile.ReadLine();

            clientInfo.Add($"{ fullName }");
            clientInfo.Add($"{ clientheighttext }");
            clientInfo.Add($"{ clientEmail.ToLower() }");
            clientInfo.Add($"{ clientPhoneNumber }");

            this.nameBox1.Text = clientInfo[0];
            this.emailBox2.Text = clientInfo[2];
            this.phoneBox1.Text = clientInfo[3];
            this.dateBox.Text = DateTime.Today.ToString("d");
        }

        private void submit_Click(object sender, EventArgs e)
        {

            goalsForm goalsForm = new goalsForm();
            this.Hide();
            goalsForm.Show();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parqandwaiver parqandwaiver = new parqandwaiver();
            this.Hide();
            parqandwaiver.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(addressBox1.Text))
            {
                MessageBox.Show("Please enter a valid address!");
                addressBox1.Focus();
            }
            else
            {


                //fill in second page of pdf
                PdfDocument pdf =
                new PdfDocument(new PdfReader(src), new PdfWriter(dest));
                PdfAcroForm acroForm = PdfAcroForm.GetAcroForm(pdf, true);
                IDictionary<String, PdfFormField> fields = acroForm.GetFormFields();
                PdfFormField toSet;




                fields.TryGetValue("name", out toSet);
                toSet.SetValue($" {nameBox1.Text} ");

                fields.TryGetValue("emailText", out toSet);
                toSet.SetValue($" {emailBox2.Text} ");

                fields.TryGetValue("phoneText", out toSet);
                toSet.SetValue($" {phoneBox1.Text} ");

                fields.TryGetValue("dateText", out toSet);
                toSet.SetValue($" {dateBox.Text} ");

                fields.TryGetValue("addressText", out toSet);
                toSet.SetValue($" {addressBox1.Text} ");




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
                    FileName = "CoachingWaiver2.pdf"
                };
                p.Start();


                submit.Visible = true;
            }
        }

        private void addressBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
