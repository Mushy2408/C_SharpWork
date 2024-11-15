using System.Diagnostics.SymbolStore;

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

            //Symbols = "!","@","#","$","%","^","&","*","(",")","_","+","-","=","`","~","{","[","}","]","","|",";",":","'","",",","<",".","/", "?"
            //string Name = txtInput.Text;

            //txtOutput.Text = "www." + Name + ".com";
            // Get the business name from the input textbox
            string businessName = txtInput.Text;

            // Initialize the web address with "www."
            string webAddress = "www.";

            // Loop through each character in the business name
            foreach (char ch in businessName)
            {
                // Only add the character if it is not a space
                if (ch != ' ')
                {
                    webAddress += ch;
                }
            }

            // Add ".com" to the end of the web address
            webAddress += ".com";

            // Set the output textbox with the generated web address
            txtOutput.Text = webAddress;




        }
    }
}
