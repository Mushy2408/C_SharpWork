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
            txtDouble.Location = new Point(130, 58);
            txtDouble.Margin = new Padding(4, 5, 4, 5);
            txtDouble.Name = "txtDouble";
            txtDouble.Size = new Size(141, 31);
            txtDouble.TabIndex = 0;
            // 
            // txtInt
            // 
            txtInt.Location = new Point(130, 127);
            txtInt.Margin = new Padding(4, 5, 4, 5);
            txtInt.Name = "txtInt";
            txtInt.Size = new Size(141, 31);
            txtInt.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(130, 210);
            txtOutput.Margin = new Padding(4, 5, 4, 5);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(407, 31);
            txtOutput.TabIndex = 2;
            txtOutput.Visible = false;
            // 
            // lblDouble
            // 
            lblDouble.AutoSize = true;
            lblDouble.Location = new Point(13, 58);
            lblDouble.Margin = new Padding(4, 0, 4, 0);
            lblDouble.Name = "lblDouble";
            lblDouble.Size = new Size(101, 25);
            lblDouble.TabIndex = 3;
            lblDouble.Text = "Double -->";
            // 
            // lblInt
            // 
            lblInt.AutoSize = true;
            lblInt.Location = new Point(29, 132);
            lblInt.Margin = new Padding(4, 0, 4, 0);
            lblInt.Name = "lblInt";
            lblInt.Size = new Size(99, 25);
            lblInt.TabIndex = 4;
            lblInt.Text = "Integer -->";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(27, 215);
            lblOutput.Margin = new Padding(4, 0, 4, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(100, 25);
            lblOutput.TabIndex = 5;
            lblOutput.Text = "Output -->";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(129, 313);
            btnConvert.Margin = new Padding(4, 5, 4, 5);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(107, 38);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 413);
            Controls.Add(btnConvert);
            Controls.Add(lblOutput);
            Controls.Add(lblInt);
            Controls.Add(lblDouble);
            Controls.Add(txtOutput);
            Controls.Add(txtInt);
            Controls.Add(txtDouble);
            Margin = new Padding(4, 5, 4, 5);
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
