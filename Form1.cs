using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculatorWindowsForm
{
    public partial class Form1 : Form
    {
        private int NumW2s;
        private int GrossIncome = 0;
        private int AdjGrossIncome = 0;
        private int deduction;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void HandleEnter()
        {
       
        }

        private void W2AnswerBox_TextChanged(object sender, EventArgs e)
        {
            string answer = W2AnswerBox.Text;
            int NumW2s = Int32.Parse(answer);
        }

        private void W2EntryBox_TextChanged(object sender, EventArgs e)
        {
            string W2Entry;
            int W2EntryAsInt;
            for (int counter = 0; counter < NumW2s; counter++)
            {
                W2Entry = W2EntryBox.Text;
                W2EntryAsInt = Int32.Parse(W2Entry);
                GrossIncome += W2EntryAsInt;
                W2AnswerBox.Clear();
            }
            textBox1_TextChanged(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            deduction = 6350;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2_TextChanged(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string itemizedEntryString = itemizedEntry.Text;
            int itemizedEntryInt = Int32.Parse(itemizedEntryString);
            while (itemizedEntryInt != 0)
            {
                deduction += itemizedEntryInt;
                itemizedEntry.Clear();
                itemizedEntryString = itemizedEntry.Text;
                itemizedEntryInt = Int32.Parse(itemizedEntryString);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "$"+ GrossIncome.ToString();
        }

        private void adjGrossIncomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void W2AnswerBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                W2AnswerBox_TextChanged(sender, e);
            }
        }

        private void W2EntryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            W2EntryBox_TextChanged(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }
    }
}
