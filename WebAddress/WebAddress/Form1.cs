namespace WebAddress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Name = txtInput.Text;
            txtOutput.Text = "www." + Name + ".com";
            // git hub test


        }
    }
}
