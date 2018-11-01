using _IdeaBagApp.Number;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _IdeaBagApp.Categories
{
    public partial class Numbers : Form
    {
        public Form RefToMainMenu { get; set; }

        public Numbers()
        {
            InitializeComponent();
        }

        private void Numbers_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefToMainMenu.Show();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
//            Alarm Clock
//Basic Calculator
//Change Return
//Circular Primes
//Coin Flip Simulation
//Distance Calculator
//Factorial Finder
//Fibonacci Sequence
//Friday the 13th
//Gravity Simulation
//Gray Code
//Guess the Number
//Happy Numbers
//Houseold budget
//Latin Squares
//Least / greatest Common Denominator
//Lotto
//Mortgage Calculator
//Neon Number
//Next Prime Number
//Nth Natural Number
//Number Base Converter
//Number of Days
//Pascal's Triangle
//Pi Nth Digit
//prime Factorization
//Pseudo Random Number Generator
//r to Nth Digit
//Ramanujan Number
//Roman Number Generator
//Roman to Arabic Converter
//Tax Calculator
//Unit Converter
//UUID
//Vigentere Cipher

            switch (toolStripComboBox1.Text)
            {
                case "Distance Calculator":
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }
                case "Tax Calculator":
                    {
                        TaxCalculator taxCalculatorApp = new TaxCalculator();
                        taxCalculatorApp.MdiParent = this;
                        taxCalculatorApp.Show();
                        break;
                    }

                case "Factorial Finder":
                    {
                        FactorialFinder factorialFinderApp = new FactorialFinder();
                        factorialFinderApp.MdiParent = this;
                        factorialFinderApp.Show();
                        break;
                    }

                case "Happy Numbers":
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

               /*case 5:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 6:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 7:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 8:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 9:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 10:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 11:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 12:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 13:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 14:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 15:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 16:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

                case 17:
                    {
                        DistanceCalculator distanceCalculatorApp = new DistanceCalculator();
                        distanceCalculatorApp.MdiParent = this;
                        distanceCalculatorApp.Show();
                        break;
                    }

    */

                default: break;
            }
            
        }
    }
}
