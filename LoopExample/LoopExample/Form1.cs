namespace LoopExample
{
    public partial class Form1 : Form
    {
        /* Object : given a number (int)that the user enters,
         * outout that many lines of greeting to the read-only text box
         * 
         * Input:txtInput.Text -> count (int) MUST be numeric
         * Output: txt Output.Text -> output "Hellp PS Students!" "count" number of times
         */

        // global variables for the entire program
        String output = "hello PS Students";
        int count;
        #region 
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //parse user input as an integer
            //if it cannot be parsed, output an error message
            bool validinput = int.TryParse(txtInput.Text, out count);
          
            if (validinput)
            {
                //clear txtOutput - THESES TWO LINES DO THE EXACT SAME THING!!!!@@@@@@@@
                txtOutput.Text = "";
                txtOutput.Clear();

                //use count to output our greeting to txtOutput
                //11/11 - while loop (uncounted/indefinite)
                //while(lcv___terminating Value)
                /*while(count > 0) //while(var < count) var=0
                {
                    txtOutput.Text += output + Environment.NewLine;
                    count--; //count++;
                }
                */

                //for(lcv = intial; lcv __ value; change lcv){}

                /* for (int i = 0; i < count; i++) //(; count>0; count--)
                 {
                     txtOutput.Text += output + Environment.NewLine;
                 }*/
                do
                {
                    txtOutput.Text += output + Environment.NewLine;
                    count--;
                } while (count > 0);

            }
            else
            {
                //output error message for invalid input
                txtOutput.Text = "invalid input. Please enter a valid number!";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
