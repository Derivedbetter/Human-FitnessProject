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
    public partial class parQ1form : Form
    {
       
        public parQ1form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void continuepage2_Click(object sender, EventArgs e)
        {
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
    }
}
