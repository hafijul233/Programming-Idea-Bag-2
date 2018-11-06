using _Controllers;
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
    public partial class ChangeReturn : Form
    {
        public ChangeReturnController crpController;
        public ChangeReturn()
        {
            InitializeComponent();
        }

        private void ChangeReturn_Load(object sender, EventArgs e)
        {
            crpController = new ChangeReturnController();
        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(customerNameTextBox.Text != String.Empty)
            {
                string temp = customerNameTextBox.Text;

                foreach (char c in temp)
                {
                    if(Char.IsLetter(c) == false)
                    {
                        MessageBox.Show("Only Alphabet Are Allowed.");
                    }
                }
            }
        }

        private void customerIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (customerIdTextBox.Text != String.Empty)
            {
                string temp = customerIdTextBox.Text;

                foreach (char c in temp)
                {
                    if (Char.IsDigit(c) == false)
                    {
                        MessageBox.Show("Only Numbers Are Allowed.");
                    }
                }
            }
        }
    }
}
