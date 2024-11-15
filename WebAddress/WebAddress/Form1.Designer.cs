namespace WebAddress
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
            Btn1 = new Button();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Btn1
            // 
            Btn1.Location = new Point(68, 55);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(75, 23);
            Btn1.TabIndex = 0;
            Btn1.Text = "Click Here";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(160, 56);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(58, 85);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(217, 151);
            txtOutput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 27);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 3;
            label1.Text = "Please type in your business name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 278);
            Controls.Add(label1);
            Controls.Add(Btn1);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn1;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Label label1;
    }
}
