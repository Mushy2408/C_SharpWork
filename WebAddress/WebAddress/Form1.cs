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

            // Remove spaces from the business name
            string sanitizedBusinessName = businessName.Replace(" ", "");

            // Create the web address
            string webAddress = "www." + sanitizedBusinessName + ".com";

            // Set the output in the output textbox
            txtOutput.Text = webAddress;
        }

        private bool IsInputValid(string input)
        {
            // Check if the input contains only letters and spaces
            return Regex.IsMatch(input, @"^[a-zA-Z\s]+$");
        }
        
          
                
    }
}
