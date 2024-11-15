namespace LoopExample
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
            txtOutput = new TextBox();
            txtInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(244, 164);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(307, 210);
            txtOutput.TabIndex = 0;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(125, 75);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 30);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 2;
            label1.Text = "How TO/What To Do:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 45);
            label2.Name = "label2";
            label2.Size = new Size(295, 30);
            label2.TabIndex = 3;
            label2.Text = "1)Enter a numeric value in the top text box\r\n      a)This is the number of times to repeat the greeting\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 83);
            label3.Name = "label3";
            label3.Size = new Size(226, 15);
            label3.TabIndex = 4;
            label3.Text = "2) Click on the button that says Click here";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-5, 78);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 5;
            label4.Text = "please enter a number";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(215, 119);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Click Here";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(508, 119);
            label5.Name = "label5";
            label5.Size = new Size(259, 30);
            label5.TabIndex = 7;
            label5.Text = "3)the number of greeting reqested should apear\r\n at the bottem texbox";
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Controls.Add(txtOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutput;
        private TextBox txtInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}
