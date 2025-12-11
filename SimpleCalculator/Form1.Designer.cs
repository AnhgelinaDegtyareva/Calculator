namespace SimpleCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код конструктора форм

        private void InitializeComponent()
        {
            textBoxDisplay = new TextBox();
            buttonClear = new Button();
            buttonBackspace = new Button();
            buttonPercent = new Button();
            buttonDivide = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonMultiply = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonMinus = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonPlus = new Button();
            button0 = new Button();
            buttonDecimal = new Button();
            buttonEquals = new Button();
            SuspendLayout();
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            textBoxDisplay.Location = new Point(15, 14);
            textBoxDisplay.Margin = new Padding(4, 3, 4, 3);
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.ReadOnly = true;
            textBoxDisplay.Size = new Size(303, 38);
            textBoxDisplay.TabIndex = 0;
            textBoxDisplay.Text = "r";
            textBoxDisplay.TextAlign = HorizontalAlignment.Right;
            textBoxDisplay.TextChanged += textBoxDisplay_TextChanged;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.LightCoral;
            buttonClear.Font = new Font("Microsoft Sans Serif", 14F);
            buttonClear.Location = new Point(14, 81);
            buttonClear.Margin = new Padding(4, 3, 4, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(70, 58);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonBackspace
            // 
            buttonBackspace.Font = new Font("Microsoft Sans Serif", 14F);
            buttonBackspace.Location = new Point(91, 81);
            buttonBackspace.Margin = new Padding(4, 3, 4, 3);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(70, 58);
            buttonBackspace.TabIndex = 2;
            buttonBackspace.Text = "←";
            buttonBackspace.UseVisualStyleBackColor = true;
            // 
            // buttonPercent
            // 
            buttonPercent.Font = new Font("Microsoft Sans Serif", 14F);
            buttonPercent.Location = new Point(168, 81);
            buttonPercent.Margin = new Padding(4, 3, 4, 3);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(70, 58);
            buttonPercent.TabIndex = 3;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = Color.Orange;
            buttonDivide.Font = new Font("Microsoft Sans Serif", 14F);
            buttonDivide.Location = new Point(247, 81);
            buttonDivide.Margin = new Padding(4, 3, 4, 3);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(70, 58);
            buttonDivide.TabIndex = 4;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 14F);
            button7.Location = new Point(14, 145);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(70, 58);
            button7.TabIndex = 5;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 14F);
            button8.Location = new Point(91, 145);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(70, 58);
            button8.TabIndex = 6;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 14F);
            button9.Location = new Point(168, 145);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(70, 58);
            button9.TabIndex = 7;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = Color.Orange;
            buttonMultiply.Font = new Font("Microsoft Sans Serif", 14F);
            buttonMultiply.Location = new Point(247, 145);
            buttonMultiply.Margin = new Padding(4, 3, 4, 3);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(70, 58);
            buttonMultiply.TabIndex = 8;
            buttonMultiply.Text = "×";
            buttonMultiply.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 14F);
            button4.Location = new Point(14, 210);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(70, 58);
            button4.TabIndex = 9;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 14F);
            button5.Location = new Point(91, 210);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(70, 58);
            button5.TabIndex = 10;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 14F);
            button6.Location = new Point(168, 210);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(70, 58);
            button6.TabIndex = 11;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.Orange;
            buttonMinus.Font = new Font("Microsoft Sans Serif", 14F);
            buttonMinus.Location = new Point(247, 210);
            buttonMinus.Margin = new Padding(4, 3, 4, 3);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(70, 58);
            buttonMinus.TabIndex = 12;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 14F);
            button1.Location = new Point(14, 275);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(70, 58);
            button1.TabIndex = 13;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 14F);
            button2.Location = new Point(91, 275);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(70, 58);
            button2.TabIndex = 14;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 14F);
            button3.Location = new Point(168, 275);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(70, 58);
            button3.TabIndex = 15;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.Orange;
            buttonPlus.Font = new Font("Microsoft Sans Serif", 14F);
            buttonPlus.Location = new Point(247, 275);
            buttonPlus.Margin = new Padding(4, 3, 4, 3);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(70, 58);
            buttonPlus.TabIndex = 16;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            // 
            // button0
            // 
            button0.Font = new Font("Microsoft Sans Serif", 14F);
            button0.Location = new Point(14, 339);
            button0.Margin = new Padding(4, 3, 4, 3);
            button0.Name = "button0";
            button0.Size = new Size(147, 58);
            button0.TabIndex = 17;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Font = new Font("Microsoft Sans Serif", 14F);
            buttonDecimal.Location = new Point(168, 339);
            buttonDecimal.Margin = new Padding(4, 3, 4, 3);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(70, 58);
            buttonDecimal.TabIndex = 18;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = Color.Orange;
            buttonEquals.Font = new Font("Microsoft Sans Serif", 14F);
            buttonEquals.Location = new Point(247, 339);
            buttonEquals.Margin = new Padding(4, 3, 4, 3);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(70, 58);
            buttonEquals.TabIndex = 19;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 417);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDecimal);
            Controls.Add(button0);
            Controls.Add(buttonPlus);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonMinus);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonMultiply);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(buttonDivide);
            Controls.Add(buttonPercent);
            Controls.Add(buttonBackspace);
            Controls.Add(buttonClear);
            Controls.Add(textBoxDisplay);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonEquals;
    }
}