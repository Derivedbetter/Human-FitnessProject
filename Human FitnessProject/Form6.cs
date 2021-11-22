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

namespace Human_FitnessProject
{
    public partial class waiverForm : Form
    {
        public waiverForm()
        {
            InitializeComponent();
            MyList();
        }

        private void waiverForm_Load(object sender, EventArgs e)
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
            inputFile.ReadLine();
            string clientPhoneNumber = inputFile.ReadLine();

            clientInfo.Add($"{ fullName }");
            clientInfo.Add($"{ clientheighttext }");
            clientInfo.Add($"{ clientEmail.ToLower() }");
            clientInfo.Add($"{ clientPhoneNumber }");

            this.nameBox1.Text = clientInfo[0];
            this.emailBox2.Text = clientInfo[2];
            this.phoneBox1.Text = clientInfo[3];
        }

        private void submit_Click(object sender, EventArgs e)
        {
            parqandwaiver parqandwaiver = new parqandwaiver();
            this.Hide();
            parqandwaiver.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parqandwaiver parqandwaiver = new parqandwaiver();
            this.Hide();
            parqandwaiver.Show();
        }
    }
}
