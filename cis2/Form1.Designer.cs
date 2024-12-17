namespace cis2
{
    partial class form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            num1 = new MaskedTextBox();
            num2 = new MaskedTextBox();
            result1 = new Button();
            result = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 56);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "num1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 99);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "num2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 141);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "result";
            // 
            // num1
            // 
            num1.Location = new Point(202, 56);
            num1.Name = "num1";
            num1.Size = new Size(125, 27);
            num1.TabIndex = 3;
            // 
            // num2
            // 
            num2.Location = new Point(202, 99);
            num2.Name = "num2";
            num2.Size = new Size(125, 27);
            num2.TabIndex = 4;
            // 
            // result1
            // 
            result1.Location = new Point(371, 54);
            result1.Name = "result1";
            result1.Size = new Size(94, 29);
            result1.TabIndex = 6;
            result1.Text = "+";
            result1.UseVisualStyleBackColor = true;
            result1.Click += result1_Click;
            // 
            // result
            // 
            result.Location = new Point(202, 141);
            result.Name = "result";
            result.Size = new Size(125, 27);
            result.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(371, 99);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "*";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(371, 141);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(487, 56);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(487, 99);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(result1);
            Controls.Add(result);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox num1;
        private MaskedTextBox num2;
        private Button result1;
        private MaskedTextBox result;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
