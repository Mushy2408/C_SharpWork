namespace validationExample2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            bool _isFormValueADouble = double.TryParse(txtDouble.Text, out double validDoubleValue);
            bool _isFormValueAnInt    = int.TryParse(txtInt.Text,out int validIntValue);
            //if output textbox is not visible, make it visible
            if (!txtOutput.Visible) txtOutput.Visible = true;

            //check if double text box is valid double type
            if(!_isFormValueADouble)
            {
                //double text box contains an error
                txtOutput.Text = "please enter a valid double (decimal) value in the first box";
                txtDouble.Focus();
                txtDouble.SelectAll();
            }

            //check if integer is valid integer type
            if (!_isFormValueAnInt)
            {
                //double text box contains an error
                txtOutput.Text = "please enter a valid double (decimal) value in the first box";
                txtInt.Focus();
                txtInt.SelectAll();
            }
            //if both textboxes are valid, output result as double * integer value
            if (_isFormValueADouble && _isFormValueAnInt)
            {
                txtOutput.Text = ((double)(validDoubleValue * validIntValue)).ToString("N1");
            }
        }
    }
}
