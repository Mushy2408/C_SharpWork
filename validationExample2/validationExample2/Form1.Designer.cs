namespace validationExample2
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
            txtDouble = new TextBox();
            txtInt = new TextBox();
            txtOutput = new TextBox();
            lblDouble = new Label();
            lblInt = new Label();
            lblOutput = new Label();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // txtDouble
            // 
            txtDouble.Location = new Point(91, 35);
            txtDouble.Name = "txtDouble";
            txtDouble.Size = new Size(100, 23);
            txtDouble.TabIndex = 0;
            // 
            // txtInt
            // 
            txtInt.Location = new Point(91, 76);
            txtInt.Name = "txtInt";
            txtInt.Size = new Size(100, 23);
            txtInt.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(91, 126);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(286, 23);
            txtOutput.TabIndex = 2;
            txtOutput.Visible = false;
            // 
            // lblDouble
            // 
            lblDouble.AutoSize = true;
            lblDouble.Location = new Point(26, 43);
            lblDouble.Name = "lblDouble";
            lblDouble.Size = new Size(59, 15);
            lblDouble.TabIndex = 3;
            lblDouble.Text = "Doule -->";
            // 
            // lblInt
            // 
            lblInt.AutoSize = true;
            lblInt.Location = new Point(20, 79);
            lblInt.Name = "lblInt";
            lblInt.Size = new Size(65, 15);
            lblInt.TabIndex = 4;
            lblInt.Text = "Integer -->";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(19, 129);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(66, 15);
            lblOutput.TabIndex = 5;
            lblOutput.Text = "Output -->";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(90, 188);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 248);
            Controls.Add(btnConvert);
            Controls.Add(lblOutput);
            Controls.Add(lblInt);
            Controls.Add(lblDouble);
            Controls.Add(txtOutput);
            Controls.Add(txtInt);
            Controls.Add(txtDouble);
            Name = "frmMain";
            Text = "Validation Example, Part 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDouble;
        private TextBox txtInt;
        private TextBox txtOutput;
        private Label lblDouble;
        private Label lblInt;
        private Label lblOutput;
        private Button btnConvert;
    }
}
