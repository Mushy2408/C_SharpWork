namespace Ch2FormatDecimals
{
    partial class Form1
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
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            lbl6 = new Label();
            txtFoodAmount = new TextBox();
            txtTaxAmount = new TextBox();
            txtTipPercent = new TextBox();
            txtTipAmount = new TextBox();
            txtTotalAmount = new TextBox();
            txtPerPerson = new TextBox();
            btnButton = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(97, 87);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(78, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "FoodAmount";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(97, 118);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(68, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "TaxAmount";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(97, 150);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(63, 15);
            lbl3.TabIndex = 2;
            lbl3.Text = "TipPercent";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(97, 189);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(67, 15);
            lbl4.TabIndex = 3;
            lbl4.Text = "TipAmount";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(97, 219);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(76, 15);
            lbl5.TabIndex = 4;
            lbl5.Text = "TotalAmount";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new Point(97, 257);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(60, 15);
            lbl6.TabIndex = 5;
            lbl6.Text = "PerPerson";
            // 
            // txtFoodAmount
            // 
            txtFoodAmount.Location = new Point(187, 87);
            txtFoodAmount.Name = "txtFoodAmount";
            txtFoodAmount.Size = new Size(100, 23);
            txtFoodAmount.TabIndex = 6;
            // 
            // txtTaxAmount
            // 
            txtTaxAmount.Location = new Point(187, 118);
            txtTaxAmount.Name = "txtTaxAmount";
            txtTaxAmount.Size = new Size(100, 23);
            txtTaxAmount.TabIndex = 7;
            // 
            // txtTipPercent
            // 
            txtTipPercent.Location = new Point(187, 150);
            txtTipPercent.Name = "txtTipPercent";
            txtTipPercent.Size = new Size(100, 23);
            txtTipPercent.TabIndex = 8;
            // 
            // txtTipAmount
            // 
            txtTipAmount.Location = new Point(187, 181);
            txtTipAmount.Name = "txtTipAmount";
            txtTipAmount.Size = new Size(100, 23);
            txtTipAmount.TabIndex = 9;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(187, 216);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(100, 23);
            txtTotalAmount.TabIndex = 10;
            // 
            // txtPerPerson
            // 
            txtPerPerson.Location = new Point(187, 254);
            txtPerPerson.Name = "txtPerPerson";
            txtPerPerson.Size = new Size(100, 23);
            txtPerPerson.TabIndex = 11;
            // 
            // btnButton
            // 
            btnButton.BackColor = SystemColors.ControlLight;
            btnButton.ForeColor = Color.Black;
            btnButton.Location = new Point(198, 293);
            btnButton.Name = "btnButton";
            btnButton.Size = new Size(75, 23);
            btnButton.TabIndex = 12;
            btnButton.Text = "button1";
            btnButton.UseVisualStyleBackColor = false;
            btnButton.Click += btnButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnButton);
            Controls.Add(txtPerPerson);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtTipAmount);
            Controls.Add(txtTipPercent);
            Controls.Add(txtTaxAmount);
            Controls.Add(txtFoodAmount);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl5;
        private Label lbl6;
        private TextBox txtFoodAmount;
        private TextBox txtTaxAmount;
        private TextBox txtTipPercent;
        private TextBox txtTipAmount;
        private TextBox txtTotalAmount;
        private TextBox txtPerPerson;
        private Button btnButton;
    }
}
