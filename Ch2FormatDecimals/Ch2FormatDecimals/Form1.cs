namespace Ch2FormatDecimals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            double FoodAmount = 23;
            double TaxAmount = 2.5;
            double TipPercent = .05; //Notice that the percent has to be in decimal form

            double TipAmount = 2;
            double TotalBill = 27.5;
            double CostPerPerson = 5.5;

            txtFoodAmount.Text = FoodAmount.ToString("C");  //C is for currency. $0.00
            txtTaxAmount.Text = TaxAmount.ToString("c");
            txtTipPercent.Text = TipPercent.ToString("P0"); //P0 will eliminate the extra zeros
            txtTipAmount.Text = TipAmount.ToString("C");
            txtTotalAmount.Text = TotalBill.ToString("C");  

            txtPerPerson.Text = CostPerPerson.ToString("N2"); //N2 means that 2 decimal places will be forced
            

        }
    }
}
