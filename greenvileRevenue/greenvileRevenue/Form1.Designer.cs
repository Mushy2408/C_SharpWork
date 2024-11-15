namespace greenvileRevenue
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtThisYear = new TextBox();
            txtLastContestants = new TextBox();
            lbl1 = new Label();
            lbl2 = new Label();
            txtRevenueAmount = new TextBox();
            txtoutput = new TextBox();
            lbl3 = new Label();
            btn1 = new Button();
            SuspendLayout();
            // 
            // txtThisYear
            // 
            txtThisYear.Location = new Point(385, 64);
            txtThisYear.Name = "txtThisYear";
            txtThisYear.Size = new Size(100, 23);
            txtThisYear.TabIndex = 0;
            // 
            // txtLastContestants
            // 
            txtLastContestants.Location = new Point(385, 103);
            txtLastContestants.Name = "txtLastContestants";
            txtLastContestants.Size = new Size(100, 23);
            txtLastContestants.TabIndex = 1;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(227, 67);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(125, 15);
            lbl1.TabIndex = 2;
            lbl1.Text = "this year\"s contestants";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(227, 103);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(125, 15);
            lbl2.TabIndex = 3;
            lbl2.Text = "Last year's contestants";
            // 
            // txtRevenueAmount
            // 
            txtRevenueAmount.Location = new Point(385, 209);
            txtRevenueAmount.Name = "txtRevenueAmount";
            txtRevenueAmount.ReadOnly = true;
            txtRevenueAmount.Size = new Size(100, 23);
            txtRevenueAmount.TabIndex = 4;
            // 
            // txtoutput
            // 
            txtoutput.Location = new Point(272, 238);
            txtoutput.Name = "txtoutput";
            txtoutput.ReadOnly = true;
            txtoutput.Size = new Size(331, 23);
            txtoutput.TabIndex = 5;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(364, 177);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 15);
            lbl3.TabIndex = 7;
            lbl3.Text = "Amount made this year";
            // 
            // btn1
            // 
            btn1.Location = new Point(395, 132);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 8;
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn1);
            Controls.Add(lbl3);
            Controls.Add(txtoutput);
            Controls.Add(txtRevenueAmount);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txtLastContestants);
            Controls.Add(txtThisYear);
            Name = "frmMain";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtThisYear;
        private TextBox txtLastContestants;
        private Label lbl1;
        private Label lbl2;
        private TextBox txtRevenueAmount;
        private TextBox txtoutput;
        private Label lbl3;
        private Button btn1;
    }
}
