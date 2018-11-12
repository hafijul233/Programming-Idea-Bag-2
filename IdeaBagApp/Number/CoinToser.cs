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
    public partial class CoinToser : Form
    {
        Random _tossChecker = new Random();

        private const string _programTitle = "Coin Flip Simulator";
        private int _userChoice = 0;

        public CoinToser()
        {
            InitializeComponent();
        }

        private void HeadRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _userChoice = 1;
        }

        private void TellRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _userChoice = 2;
        }

        private async void ToseButton_ClickAsync(object sender, EventArgs e)
        {
            if (_userChoice == 0)
                MessageBox.Show("First Choose a Side.", _programTitle);

            else
            {
                int randomResult = _tossChecker.Next(1, 100000);

                int winner;

                switch (randomResult % 2)
                {
                    case 0:
                        winner = 1;
                        break;

                    default:
                        winner = 2;
                        break;
                }

                if (_userChoice == winner)
                    ToseResultLabel.Text = "Hurray!! You Won the Toss.";

                else
                    ToseResultLabel.Text = "Sorry!! You Lose the Toss.";
            }

            await Task.Delay(3000);

            ToseResultLabel.Text = " Wanna Try Again";
        }
    }
}
