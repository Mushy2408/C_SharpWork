namespace OutputExample
{
    public partial class Form1 : Form
    {
        /*purpose:to understand a variety f ways to output information
         * @input - user types in a greeting (string)
         * output _ string in ntxtout concatenating the greeting and name 
         */
        //location of your global veriables
        //these variables can be used ANYWHERE in the class/program
        string message = "";
        string caption = "";
        MessageBoxButtons buttons;
        DialogResult dlgResult;

        public Form1()
        {
            InitializeComponent();
            txtInput.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            //comments in C# use 2 forward slashes
            /*
             * block comments use a slash and as asterisk
             */

            String _name = "mr. roeth";

            String _output = "";

            _output = txtInput.Text + _name;
            txtOutput.Text = $"{_output}!!";
        }//variable declared are "local" - AKA only available inside this methon

        private void btnInteger_Click(object sender, EventArgs e)
        {
            //declaring variables in C#
            //type name=inital_value

            //take input and attempt to create an integer from the input
            //step 1 = create an integer variable
            //step 2 = parse that value into an integer

            /*//parse #1 - assume that the user enters correct input
            int result = Int32.Parse(textBox1.Text);
            //output in C# requires conversion of all output to a string format
            textBox3.Text = result.ToString();*/
            //parse #2 - we attempt to parse it in - we can we will, otherwise we will
            //output an error


        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            Boolean success = decimal.TryParse(textBox2.Text, out decimal result);
            if (success)
            {
                textBox3.Text = result.ToString("N2");
            }
            
            
            
        }
        private void btnInteger_Click_1(object sender, EventArgs e)
        {
            Boolean success = int.TryParse(textBox2.Text, out int result);
            if (success)
            {
            }   textBox3.Text = result.ToString();
            {//tryParse not successful, output an error message to the screen
                message = "please enter a number. Do you want to try again";
                caption = "input error detected";
                buttons = MessageBoxButtons.YesNo;
                //dlgresult will hold a value of the user clicked button - OK or Cancel

                dlgResult = MessageBox.Show(message, caption, buttons);
                if (dlgResult == System.Windows.Forms.DialogResult.OK)
                {
                    textBox2.Focus();
                    textBox2.SelectAll();
                }
                else
                {
                    //user entered nNo to trying again
                    //exit the program
                    Application.Exit(); 
                }
            }
        }
    }


}
