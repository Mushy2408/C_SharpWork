using System.Diagnostics.SymbolStore;
using System.Text.RegularExpressions;

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


            string businessName = txtInput.Text;

            // Check for special characters (non-letter characters)
            if (!IsInputValid(businessName))
            {
                txtOutput.Text = "Please type in letters.";
                return;
            }

            string sanitizedBusinessName = businessName.Replace(" ", "");

            string webAddress = "www." + sanitizedBusinessName + ".com";

            txtOutput.Text = webAddress;
        }

        private bool IsInputValid(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z\s]+$");
        }
        
          
                
    }
}
