using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003FactorialFinderApp
{
    public partial class FactorialFinderUi : Form
    {
        private const string _programTitle = "Factorial Finder";

        public FactorialFinderUi()
        {
            InitializeComponent();
        }

        private void FactorialFinderUi_Load(object sender, EventArgs e)
        {

        }

        private void InputNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = InputNumberTextBox.Text;

            foreach (char c in temp)
            {
                if(Char.IsDigit(c) == false)
                {
                    MessageBox.Show("Only Integer Number are Allowed.", _programTitle);
                }
            }

            if(temp.Length > 2)
            {
                OutputTextBox.Text = "Input Is Too Big Too Calculate.";
            }

            else
            {
                if (temp == String.Empty)
                {

                }
                else
                {
                    int value = Convert.ToInt32(temp);

                    if (value > 27)
                    {
                        OutputTextBox.Text = "Calculation Range is 1 to 27(max).";
                    }
                    else
                    {
                        OutputTextBox.Text = "";
                    }
                }
            }
        }

        private void FactorialButton_Click(object sender, EventArgs e)
        {
            if(InputNumberTextBox.Text == String.Empty)
            {
                OutputTextBox.Text = "Input Field is Empty.";
            }

            else if(InputNumberTextBox.Text == "0")
            {
                OutputTextBox.Text = "0 Cannot be Factorized.";
            }

            else
            {
                decimal inputNumber = Convert.ToDecimal(InputNumberTextBox.Text);
                decimal resultNumber = 1;

                while(inputNumber>=1)
                {
                    resultNumber = resultNumber * (inputNumber);
                    inputNumber = inputNumber - 1;
                }

                OutputTextBox.Text = Convert.ToString(resultNumber);
            }

        }

        private void FactorialFinderUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you Really Want to Quit.", _programTitle,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
