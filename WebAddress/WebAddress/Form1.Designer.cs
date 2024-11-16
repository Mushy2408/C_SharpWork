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
            Btn1.Location = new Point(97, 92);
            Btn1.Margin = new Padding(4, 5, 4, 5);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(107, 38);
            Btn1.TabIndex = 6;
            Btn1.Text = "Click Here";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            Btn1.Enter += Btn1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(229, 93);
            txtInput.Margin = new Padding(4, 5, 4, 5);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(141, 31);
            txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(83, 142);
            txtOutput.Margin = new Padding(4, 5, 4, 5);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(308, 249);
            txtOutput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 25);
            label1.TabIndex = 3;
            label1.Text = "Please type in your business name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 463);
            Controls.Add(label1);
            Controls.Add(Btn1);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Margin = new Padding(4, 5, 4, 5);
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
