using System.Reflection.Metadata;

namespace greenvileRevenue
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int EntranceFee = 25;
            int NumberOfcontestants;
            double RevenueAmount;
            int NumberOfLastContestants;

            bool RevenueSuccess = int.TryParse(txtThisYear.Text, out NumberOfcontestants);
            bool NumberOfLastYear = int.TryParse(txtLastContestants.Text, out NumberOfLastContestants);
            RevenueAmount = EntranceFee * NumberOfcontestants;
            txtRevenueAmount.Text = RevenueAmount.ToString("C");
if (!RevenueSuccess)
            {
                MessageBox.Show("Please enter a number", "error", MessageBoxButtons.OK);
                txtThisYear.Focus();
                txtThisYear.SelectAll();
            }
            else if (!NumberOfLastYear)
            {
                MessageBox.Show("Please enter a number", "error", MessageBoxButtons.OK);
                txtThisYear.Focus();
                txtThisYear.SelectAll();
            }
            else if (NumberOfLastContestants > NumberOfcontestants)
            {
                txtoutput.Text = "there were more contantants last year";
            }
            else if (NumberOfLastContestants < NumberOfcontestants)
            {
                txtoutput.Text = "there are more contantants this year";
            }
            else if (NumberOfLastContestants == NumberOfcontestants)
            {
                txtoutput.Text = "there are the same amount of contantants as last year";
            }


            
        }
    }
}
