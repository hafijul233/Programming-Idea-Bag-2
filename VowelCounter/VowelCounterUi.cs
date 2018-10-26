using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VowelCounter
{
    public partial class VowelCounterUi : Form
    {
        public VowelCounterUi()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (InputStringTextBox.Text == String.Empty)
            {
                MessageBox.Show("Empty String Uncountable", "Vowel Checker",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string inputString = Convert.ToString(InputStringTextBox.Text);

                ulong counter = 0;

                foreach(char letter in inputString)
                {
                    char c = Char.ToLower(letter);

                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        counter++;
                    }
                }

                ReplyLabel.Text = "Total Number of Vowels: " + counter;
               
            }
        }
    }
}
