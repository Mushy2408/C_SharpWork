using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace EnterUppercaseLetters
{
    public partial class FrnMain : Form
    {
        public FrnMain()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num;
            bool validinput = int.TryParse(txtInput.Text, out num);
            if(txtInput.Text == "!")
            {
                Application.Exit();
            }

            if (!validinput)
            {
                if (txtInput.Text == txtInput.Text.ToUpper())
                {
                   MessageBox.Show("OK", "correct input", MessageBoxButtons.OK); 
                }
                else
                {
                   MessageBox.Show(" not Uppercase","not valid input", MessageBoxButtons.OK);
                }

            }
            else 
            {
                MessageBox.Show("please enter an Uppercase" , "not valid input" , MessageBoxButtons.OK);
            }
            

            
        }

    }
}