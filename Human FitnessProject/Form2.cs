using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Human_FitnessProject
{
    public partial class intake : Form
    {
        //Initial variable declarations.
        public Blockchain HFPCoin = new Blockchain();
        

        public intake()
        {
            
            InitializeComponent();

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            welcomePage welcomePage = new welcomePage();
            this.Hide();
            welcomePage.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void initinfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attribPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void intake_Load(object sender, EventArgs e)
        {

        }      


        private void button1_Click(object sender, EventArgs e)
        {
            HFPCoin.AddBlock(new Block (DateTime.Now, null,
                "{This is an empty block for demonstration purposes}"));
            Console.Clear();
            Console.WriteLine(JsonConvert.SerializeObject(HFPCoin, Formatting.Indented));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            HFPCoin.AddBlock(new Block(DateTime.Now, null,
                "{sender:Tony,receiver:Korey,amount:1}"));
            HFPCoin.PrintLatest();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HFPCoin.PrintGenesis();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HFPCoin.PrintLatest();

        }

        private void button10_Click(object sender, EventArgs e)
        {            
            Console.Clear();
            Console.WriteLine("\n\nApplication closed!\n");            
            Environment.Exit(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine(JsonConvert.SerializeObject(HFPCoin, Formatting.Indented));
        }
    }

    
}

    
    



