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

namespace Human_FitnessProject
{
        
    public partial class parQ1form : Form
    {
       
        public parQ1form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        //declare variables for iText
        public static String src = "parQ.pdf";
        public static String dest = "parQFilled.pdf";
        public static String fields;
         
        private void continuepage2_Click(object sender, EventArgs e)
        {
            //Read fields from pdf.
            PdfDocument pdf =
                new PdfDocument(new PdfReader(src), new PdfWriter(dest));
            PdfAcroForm acroForm = PdfAcroForm.GetAcroForm(pdf, true);            
            IDictionary<String, PdfFormField> fields = acroForm.GetFormFields();
            PdfFormField toSet;

            //check status of radioButtons
            if (yesButton1.Checked == true)
            {
                fields.TryGetValue("Check6", out toSet);
                toSet.SetValue("Yes");
            }
            
            if (noButton1.Checked == true)
            {
                fields.TryGetValue("Check7", out toSet);
                toSet.SetValue("Yes");
            }

            if (yesButton2.Checked == true)
            {
                fields.TryGetValue("Check8", out toSet);
                toSet.SetValue("Yes");
            }

            if (noButton2.Checked == true)
            {
                fields.TryGetValue("Check9", out toSet);
                toSet.SetValue("Yes");
            }

            if (yesButton3.Checked == true)
            {
                fields.TryGetValue("Check11", out toSet);
                toSet.SetValue("Yes");
            }

            if (noButton3.Checked == true)
            {
                fields.TryGetValue("Check12", out toSet);
                toSet.SetValue("Yes");
            }

            if (yesButton4.Checked == true)
            {
                fields.TryGetValue("Check13", out toSet);
                toSet.SetValue("Yes");
            }

            if (noButton4.Checked == true)
            {
                fields.TryGetValue("Check14", out toSet);
                toSet.SetValue("Yes");
            }

            if (yesButton5.Checked == true)
            {
                fields.TryGetValue("Check15", out toSet);
                toSet.SetValue("Yes");
            }

            if (noButton5.Checked == true)
            {
                fields.TryGetValue("Check16", out toSet);
                toSet.SetValue("Yes");
            }

            if (yesButton6.Checked == true)
            {
                fields.TryGetValue("Check17", out toSet);
                toSet.SetValue("Yes");
            }

            if (noButton6.Checked == true)
            {
                fields.TryGetValue("Check18", out toSet);
                toSet.SetValue("Yes");
            }

            if (yesButton7.Checked == true)
            {
                fields.TryGetValue("Check19", out toSet);
                toSet.SetValue("Yes");
            }

            if (noButton7.Checked == true)
            {
                fields.TryGetValue("Check20", out toSet);
                toSet.SetValue("Yes");
            }


            pdf.Close();

            //Go to second page of document
            parQ2form parQ2form = new parQ2form();            
            this.Hide();
        
        parQ2form.Show();
        }

        private void parQ1form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void back3_Click(object sender, EventArgs e)
        {
            parqandwaiver parqandwaiver = new parqandwaiver();
            this.Hide();
            parqandwaiver.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //check status of groupboxes
            if (groupBox1.Controls.OfType<RadioButton>().Any(x => x.Checked)
                && groupBox2.Controls.OfType<RadioButton>().Any(x => x.Checked)
                && groupBox3.Controls.OfType<RadioButton>().Any(x => x.Checked)
                && groupBox4.Controls.OfType<RadioButton>().Any(x => x.Checked)
                && groupBox5.Controls.OfType<RadioButton>().Any(x => x.Checked)
                && groupBox6.Controls.OfType<RadioButton>().Any(x => x.Checked)
                && groupBox7.Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                // at least one radiobutton in all groupBoxes are checked
                continuepage2.Visible = true; 
            }
            else
            {
                //Call for client to take a look at the check boxes.
                MessageBox.Show("It looks like you forgot to check a box or two. " +
                    "Please review the questions and answer appropriately!");
            }

        }

        private void yesButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
