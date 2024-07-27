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
            button1 = new Button();
            textBox1 = new TextBox();
            tbxNumberInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxTimeout = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(312, 32);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 23);
            textBox1.TabIndex = 1;
            // 
            // tbxNumberInput
            // 
            tbxNumberInput.Location = new Point(53, 32);
            tbxNumberInput.Name = "tbxNumberInput";
            tbxNumberInput.Size = new Size(100, 23);
            tbxNumberInput.TabIndex = 2;
            tbxNumberInput.Text = "1000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 14);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 85);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Result";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 14);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Timeout";
            // 
            // tbxTimeout
            // 
            tbxTimeout.Location = new Point(185, 32);
            tbxTimeout.Name = "tbxTimeout";
            tbxTimeout.Size = new Size(100, 23);
            tbxTimeout.TabIndex = 4;
            tbxTimeout.Text = "100";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 228);
            Controls.Add(label3);
            Controls.Add(tbxTimeout);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxNumberInput);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox tbxNumberInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxTimeout;
    }
}
