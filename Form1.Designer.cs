namespace TaxCalculatorWindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.W2AnswerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.W2EntryBox = new System.Windows.Forms.TextBox();
            this.W2Entries = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.itemizedEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemizedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adjGrossIncomeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // W2AnswerBox
            // 
            this.W2AnswerBox.AcceptsReturn = true;
            this.W2AnswerBox.Location = new System.Drawing.Point(21, 44);
            this.W2AnswerBox.Name = "W2AnswerBox";
            this.W2AnswerBox.Size = new System.Drawing.Size(171, 20);
            this.W2AnswerBox.TabIndex = 0;
            this.W2AnswerBox.TextChanged += new System.EventHandler(this.W2AnswerBox_TextChanged);
            this.W2AnswerBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.W2AnswerBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many W2\'s do you have?";
            // 
            // W2EntryBox
            // 
            this.W2EntryBox.Location = new System.Drawing.Point(21, 122);
            this.W2EntryBox.Name = "W2EntryBox";
            this.W2EntryBox.Size = new System.Drawing.Size(170, 20);
            this.W2EntryBox.TabIndex = 2;
            this.W2EntryBox.TextChanged += new System.EventHandler(this.W2EntryBox_TextChanged);
            this.W2EntryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.W2EntryBox_KeyPress);
            // 
            // W2Entries
            // 
            this.W2Entries.AutoSize = true;
            this.W2Entries.Location = new System.Drawing.Point(18, 87);
            this.W2Entries.Name = "W2Entries";
            this.W2Entries.Size = new System.Drawing.Size(170, 13);
            this.W2Entries.TabIndex = 3;
            this.W2Entries.Text = "Please Enter Gross Income Below:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // itemizedEntry
            // 
            this.itemizedEntry.Location = new System.Drawing.Point(21, 269);
            this.itemizedEntry.Name = "itemizedEntry";
            this.itemizedEntry.Size = new System.Drawing.Size(167, 20);
            this.itemizedEntry.TabIndex = 5;
            this.itemizedEntry.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gross Income:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Standard ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(123, 197);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Itemized";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Deduction Type";
            // 
            // itemizedLabel
            // 
            this.itemizedLabel.AutoSize = true;
            this.itemizedLabel.Location = new System.Drawing.Point(20, 236);
            this.itemizedLabel.Name = "itemizedLabel";
            this.itemizedLabel.Size = new System.Drawing.Size(172, 13);
            this.itemizedLabel.TabIndex = 10;
            this.itemizedLabel.Text = "Enter Deductions Below: (0 to end)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adjusted Gross Income:";
            // 
            // adjGrossIncomeBox
            // 
            this.adjGrossIncomeBox.Location = new System.Drawing.Point(233, 120);
            this.adjGrossIncomeBox.Name = "adjGrossIncomeBox";
            this.adjGrossIncomeBox.Size = new System.Drawing.Size(171, 20);
            this.adjGrossIncomeBox.TabIndex = 12;
            this.adjGrossIncomeBox.TextChanged += new System.EventHandler(this.adjGrossIncomeBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 364);
            this.Controls.Add(this.adjGrossIncomeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemizedLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemizedEntry);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.W2Entries);
            this.Controls.Add(this.W2EntryBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.W2AnswerBox);
            this.Name = "Form1";
            this.Text = "Federal Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox W2AnswerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox W2EntryBox;
        private System.Windows.Forms.Label W2Entries;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox itemizedEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label itemizedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adjGrossIncomeBox;
    }
}

