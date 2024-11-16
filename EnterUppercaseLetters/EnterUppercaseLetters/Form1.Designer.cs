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
            txtInput.Location = new Point(240, 155);
            txtInput.Margin = new Padding(4, 5, 4, 5);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(141, 31);
            txtInput.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(124, 153);
            btn1.Margin = new Padding(4, 5, 4, 5);
            btn1.Name = "btn1";
            btn1.Size = new Size(107, 38);
            btn1.TabIndex = 1;
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(99, 103);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(332, 25);
            lbl1.TabIndex = 2;
            lbl1.Text = "Can you please type in a lowercase letter\r\n";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(43, 228);
            txtOutput.Margin = new Padding(4, 5, 4, 5);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(413, 262);
            txtOutput.TabIndex = 3;
            // 
            // FrnMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 550);
            Controls.Add(txtOutput);
            Controls.Add(lbl1);
            Controls.Add(btn1);
            Controls.Add(txtInput);
            Margin = new Padding(4, 5, 4, 5);
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
