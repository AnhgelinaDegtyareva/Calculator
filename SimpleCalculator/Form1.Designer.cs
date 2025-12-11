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
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.labelHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBoxDisplay
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.textBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.Size = new System.Drawing.Size(350, 38);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // buttonClear
            this.buttonClear.BackColor = System.Drawing.Color.LightCoral;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonClear.Location = new System.Drawing.Point(12, 70);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 50);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;

            // buttonBackspace
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonBackspace.Location = new System.Drawing.Point(78, 70);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(60, 50);
            this.buttonBackspace.TabIndex = 2;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.UseVisualStyleBackColor = true;

            // buttonPercent
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonPercent.Location = new System.Drawing.Point(144, 70);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(60, 50);
            this.buttonPercent.TabIndex = 3;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;

            // buttonDivide
            this.buttonDivide.BackColor = System.Drawing.Color.Orange;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDivide.Location = new System.Drawing.Point(210, 70);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(60, 50);
            this.buttonDivide.TabIndex = 4;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = false;

            // button7
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button7.Location = new System.Drawing.Point(12, 126);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 50);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;

            // button8
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button8.Location = new System.Drawing.Point(78, 126);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 50);
            this.button8.TabIndex = 6;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;

            // button9
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button9.Location = new System.Drawing.Point(144, 126);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 50);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;

            // buttonMultiply
            this.buttonMultiply.BackColor = System.Drawing.Color.Orange;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMultiply.Location = new System.Drawing.Point(210, 126);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(60, 50);
            this.buttonMultiply.TabIndex = 8;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = false;

            // button4
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button4.Location = new System.Drawing.Point(12, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;

            // button5
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button5.Location = new System.Drawing.Point(78, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 50);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;

            // button6
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button6.Location = new System.Drawing.Point(144, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 50);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;

            // buttonMinus
            this.buttonMinus.BackColor = System.Drawing.Color.Orange;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMinus.Location = new System.Drawing.Point(210, 182);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(60, 50);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;

            // button1
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(12, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;

            // button2
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(78, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 50);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;

            // button3
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.Location = new System.Drawing.Point(144, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 50);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;

            // buttonPlus
            this.buttonPlus.BackColor = System.Drawing.Color.Orange;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonPlus.Location = new System.Drawing.Point(210, 238);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(60, 50);
            this.buttonPlus.TabIndex = 16;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;

            // button0
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button0.Location = new System.Drawing.Point(12, 294);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(126, 50);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;

            // buttonDecimal
            this.buttonDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDecimal.Location = new System.Drawing.Point(144, 294);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(60, 50);
            this.buttonDecimal.TabIndex = 18;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;

            // buttonEquals
            this.buttonEquals.BackColor = System.Drawing.Color.Orange;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonEquals.Location = new System.Drawing.Point(210, 294);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(60, 50);
            this.buttonEquals.TabIndex = 19;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;

            // textBoxHistory
            this.textBoxHistory.Location = new System.Drawing.Point(280, 70);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.ReadOnly = true;
            this.textBoxHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHistory.Size = new System.Drawing.Size(150, 274);
            this.textBoxHistory.TabIndex = 20;

            // labelHistory
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHistory.Location = new System.Drawing.Point(277, 50);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(104, 17);
            this.labelHistory.TabIndex = 21;
            this.labelHistory.Text = "История ввода:";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 361);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.textBoxHistory);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxDisplay);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Label labelHistory;
    }
}