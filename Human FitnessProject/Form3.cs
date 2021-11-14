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
    public partial class parqandwaiver : Form
    {
        Image[] motivation = new Image [10];
        Random random = new Random();
        

        public Form RefTointake { get; set; }
        
        public parqandwaiver()
        {
            InitializeComponent();
            mot1Timer.Start();
            mot2Timer.Start();
        }
            

        private void awesomeLabel_Click(object sender, EventArgs e)
        {

        }

        
        private void parqandwaiver_Load(object sender, EventArgs e)
        {
            int initialImg1 = random.Next(10);
            int initialImg2 = random.Next(10);
            motivation[0] = Image.FromFile("screen1.jpg");
            motivation[1] = Image.FromFile("screen2.jpg");
            motivation[2] = Image.FromFile("screen3.jpg");
            motivation[3] = Image.FromFile("screen4.jpg");
            motivation[4] = Image.FromFile("screen5.jpg");
            motivation[5] = Image.FromFile("screen6.jpg");
            motivation[6] = Image.FromFile("screen7.jpg");
            motivation[7] = Image.FromFile("screen8.jpg");
            motivation[8] = Image.FromFile("screen9.jpg");
            motivation[9] = Image.FromFile("surprised.jpg");
            motivation1.Image = motivation[initialImg1];
            motivation2.Image = motivation[initialImg2];

        }
        
        private void parQBox_Click(object sender, EventArgs e)
        {
         
            {
                parQ1form parQ1form = new parQ1form();
                this.Hide();
                parQ1form.Show();
            }
        }

        private void waiverBox_Click(object sender, EventArgs e)
        {
            {
                waiverForm waiverForm = new waiverForm();
                this.Hide();
                waiverForm.Show();
            }
        }

        
        private void continue2_Click(object sender, EventArgs e)
        {

        }

        private void backtoIntake_Click(object sender, EventArgs e)
        {
            if (RefTointake == null)
            {
                intake intake = new intake();
                this.Close();
                intake.Show();
            }
            else
            {
                this.Close();
                this.RefTointake.Show();
            }
            
        }

        private void motivation1_Click(object sender, EventArgs e)
        {

        }
        
        

        private void mot1Timer_Tick(object sender, EventArgs e)
        {
            int randomImg1 = random.Next(10);
            motivation1.Image = motivation[randomImg1];
            randomImg1++;
        }

        private void mot2Timer_Tick(object sender, EventArgs e)
        {
            int randomImg2 = random.Next(10);
            motivation2.Image = motivation[randomImg2];
            randomImg2++;
        }
    }
}
