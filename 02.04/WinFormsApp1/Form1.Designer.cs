namespace WinFormsApp1
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
            maskedTextBox1 = new MaskedTextBox();
            button10 = new Button();
            button11 = new Button();
            button13 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(155, 154);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(319, 23);
            maskedTextBox1.TabIndex = 12;
            // 
            // button10
            // 
            button10.Location = new Point(191, 258);
            button10.Name = "button10";
            button10.Size = new Size(120, 79);
            button10.TabIndex = 13;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(23, 258);
            button11.Name = "button11";
            button11.Size = new Size(120, 79);
            button11.TabIndex = 14;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(354, 258);
            button13.Name = "button13";
            button13.Size = new Size(120, 79);
            button13.TabIndex = 16;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(155, 198);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(319, 23);
            maskedTextBox2.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(513, 258);
            button1.Name = "button1";
            button1.Size = new Size(120, 79);
            button1.TabIndex = 18;
            button1.Text = "/";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 450);
            Controls.Add(button1);
            Controls.Add(maskedTextBox2);
            Controls.Add(button13);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(maskedTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox maskedTextBox1;
        private Button button10;
        private Button button11;
        private Button button13;
        private MaskedTextBox maskedTextBox2;
        private Button button1;
    }
}
