namespace GreenvilleMotto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            textBox1.Visible = true;
            Console.WriteLine("*****************************");
            Console.WriteLine("The stars shine in greenville");
            Console.WriteLine("*****************************");
        }
    }
}
