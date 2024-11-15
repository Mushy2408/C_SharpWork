namespace BooleanDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool resultAND = checkBox1.Checked && checkBox2.Checked;
            bool resultOR = checkBox1.Checked || checkBox2.Checked;
            bool resultNOT1 = checkBox1.Checked;//align with checkbox1
            bool resultNOT2 = checkBox2.Checked;//align with checkbox2

            //bool var = !var --> replaces if (var ==true) var - false; else var = true

            if (comboBox1.SelectedIndex == 0)//user selected And from the list
            {
                //selected AND - result is = are both checkboxes checked
                textBox1.Text = "And Selected. The result is: " + resultAND;
            }
            else if (comboBox1.SelectedIndex == 1)//user selected OR from the list
            {
                //selected OR - result is = are both checkboxes checked
                textBox1.Text = "And Selected. The result is: " + resultOR;
            }
            else if (comboBox1.SelectedIndex == 2)//user selected Not from the list
            {
                //user selected NOT - result is the opposite of both checkboxes
                textBox1.Text = "NOT Selected. Result cbox1: " + resultNOT1 + "and cbox2: " + resultNOT2;
            }       
        }
    }
}
