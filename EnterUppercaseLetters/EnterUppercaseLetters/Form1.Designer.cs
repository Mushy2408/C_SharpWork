namespace EnterUppercaseLetters
{
    partial class FrnMain
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
            btn1 = new Button();
            lbl1 = new Label();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(168, 93);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(87, 92);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 1;
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(69, 62);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(220, 15);
            lbl1.TabIndex = 2;
            lbl1.Text = "Can you please type in a lowercase letter\r\n";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(30, 137);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(290, 159);
            txtOutput.TabIndex = 3;
            // 
            // FrnMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 452);
            Controls.Add(txtOutput);
            Controls.Add(lbl1);
            Controls.Add(btn1);
            Controls.Add(txtInput);
            Name = "FrnMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btn1;
        private Label lbl1;
        private TextBox txtOutput;
    }
}
