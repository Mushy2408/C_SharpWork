namespace OutputExample
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
            txtInput = new TextBox();
            btnOutput = new Button();
            txtOutput = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbloutput2 = new Label();
            btnInteger = new Button();
            btndecimal = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(332, 115);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(136, 23);
            txtInput.TabIndex = 0;
            txtInput.Text = "Enter your greeting here...";
            // 
            // btnOutput
            // 
            btnOutput.Location = new Point(362, 156);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(75, 23);
            btnOutput.TabIndex = 1;
            btnOutput.Text = "click here";
            btnOutput.UseVisualStyleBackColor = true;
            btnOutput.Click += btnOutput_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(334, 194);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(136, 23);
            txtOutput.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(796, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(798, 170);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(719, 111);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 6;
            label1.Text = "textBox1 -->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(904, 173);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "(output)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(719, 173);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 7;
            label3.Text = "textBox2 -->";
            // 
            // lbloutput2
            // 
            lbloutput2.AutoSize = true;
            lbloutput2.Location = new Point(912, 111);
            lbloutput2.Name = "lbloutput2";
            lbloutput2.Size = new Size(43, 15);
            lbloutput2.TabIndex = 8;
            lbloutput2.Text = "(input)";
            // 
            // btnInteger
            // 
            btnInteger.Location = new Point(810, 215);
            btnInteger.Name = "btnInteger";
            btnInteger.Size = new Size(75, 23);
            btnInteger.TabIndex = 9;
            btnInteger.Text = "To Integer";
            btnInteger.UseVisualStyleBackColor = true;
            btnInteger.Click += btnInteger_Click_1;
            // 
            // btndecimal
            // 
            btndecimal.Location = new Point(810, 259);
            btndecimal.Name = "btndecimal";
            btndecimal.Size = new Size(75, 23);
            btndecimal.TabIndex = 10;
            btndecimal.Text = "To Decimal";
            btndecimal.UseVisualStyleBackColor = true;
            btndecimal.Click += btndecimal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 415);
            Controls.Add(btndecimal);
            Controls.Add(btnInteger);
            Controls.Add(lbloutput2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtOutput);
            Controls.Add(btnOutput);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Output Example";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnOutput;
        private TextBox txtOutput;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbloutput2;
        private Button btnInteger;
        private Button btndecimal;
    }
}
