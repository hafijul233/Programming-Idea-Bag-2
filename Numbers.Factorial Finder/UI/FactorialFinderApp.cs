using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Numbers.Factorial_Finder.BLL;

namespace Numbers.Factorial_Finder
{
    public partial class FactorialFinderForn : Form
    {
        private FactorialFinderController fFController = new FactorialFinderController();
        public FactorialFinderForn()
        {
            InitializeComponent();
        }

        private void FactorialFinderForn_Load(object sender, EventArgs e)
        {

        }

        private void InputNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string result = fFController.StringValidation(InputNumberTextBox.Text);

            if (result != "")
            {
                OutputFactorialTextBox.Text = result;
            }
        }

        private void FactorialButton_Click(object sender, EventArgs e)
        {
            if (InputNumberTextBox.Text == String.Empty)
            {
                OutputFactorialTextBox.Text = "Input Field is Empty.";
            }
            else
            {
                int Number = Convert.ToInt32(InputNumberTextBox.Text);

                string factorialValue = fFController.getFactorial(Number);

                OutputFactorialTextBox.Text = factorialValue;
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputNumberTextBox.Text = String.Empty;
            OutputFactorialTextBox.Text = String.Empty;
        }
    }
}
