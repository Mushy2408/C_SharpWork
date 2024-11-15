namespace GreenvilleMotto2
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
            textBox1 = new TextBox();
            lbl1 = new Label();
            lbl2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "The stars shine in Greenville.";
            textBox1.Visible = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(281, 178);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(157, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "******************************";
            lbl1.Visible = false;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(281, 222);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(157, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "******************************";
            lbl2.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(490, 198);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lbl1;
        private Label lbl2;
        private Button button1;
    }
}
