using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _IdeaBagApp.Number
{
    public partial class FactorialFinder : Form
    {
        public string _programTitle = "Factorial Finder";
        public FactorialFinder()
        {
            InitializeComponent();
        }

        private void InputNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = InputNumberTextBox.Text;

            foreach (char c in temp)
            {
                if (Char.IsDigit(c) == false)
                {
                    MessageBox.Show("Only Integer Number are Allowed.", _programTitle);
                }
            }

            if (temp.Length > 2)
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
           
        }
    }
}
