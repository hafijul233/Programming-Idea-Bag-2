using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004HappyNumbers
{
    public partial class HappyNumbersUi : Form
    {
        private const string _programTitle = "Happy Numbers";
        private int proof = 0;

        public HappyNumbersUi()
        {
            InitializeComponent();
        }

        private void FindHappyNumber(string TestNumber)
        {
            uint digit = 0, square = 0;

            if (TestNumber.Length == 1)
            {
                if (TestNumber == "1" || TestNumber == "0") proof = 1;

                else proof = 0;

            }

            else
            {
                ulong squareSum = 0;

                foreach(char c in TestNumber)
                {
                    digit = Convert.ToUInt32(c) - 48;
                    square = digit * digit;
                    squareSum = squareSum +  square;
                }

                TestNumber = Convert.ToString(squareSum);

                FindHappyNumber(TestNumber);
            }
        }

        private void InputNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = InputNumberTextBox.Text;

            foreach(char c in temp)
            {
                if(Char.IsDigit(c) == false)
                {
                    MessageBox.Show("Only NUmbers are Allowed.", _programTitle);
                }
            }

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string inputValue = InputNumberTextBox.Text;

            if (inputValue == String.Empty)
            {
                ReplyLabel.Text = "Input value is Empty.";
            }

            else
            {

                FindHappyNumber(inputValue);

                InputNumberTextBox.Text = String.Empty;

                if (proof == 1)
                    ReplyLabel.Text = inputValue + " is a Happy Number.";

                else
                    ReplyLabel.Text = inputValue + " is a Sad Number.";
            }
        }

        private void HappyNumbersUi_FormClosing(object sender, FormClosingEventArgs e)
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
