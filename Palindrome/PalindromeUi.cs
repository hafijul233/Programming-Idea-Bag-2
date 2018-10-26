using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrome
{
    public partial class PalindromeUi : Form
    {
        public PalindromeUi()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if(InputStringTextBox.Text == String.Empty)
            {
                MessageBox.Show("Empty String Can not Tested", "Palindrome Checker",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string inputString = Convert.ToString(InputStringTextBox.Text);
                int length = inputString.Length;
                char[] reverseText = new char[length];
                for(int i=0; i<length; i++)
                {
                    reverseText[i] = inputString[length - i - 1];
                }

                string reverseString = new String(reverseText);
                if(inputString == reverseString)
                {
                    ReplyLabel.Text = "This String is Palindrome";
                }
                else
                {
                    ReplyLabel.Text = "This String is not Palindrome";
                }
            }
        }
    }
}
