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
    public partial class parQ2form : Form
    {
        public parQ2form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
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
    }
}
