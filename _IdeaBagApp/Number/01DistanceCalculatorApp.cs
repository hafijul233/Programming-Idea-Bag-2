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
    public partial class _01DistanceCalculatorApp : Form
    {
        private const string _programTitle = "Distance Calculator";
        private const double _earthRadius = 6371137.00;

        public _01DistanceCalculatorApp()
        {
            InitializeComponent();
        }

        private void StringValidation(string value)
        {
            foreach (char c in value)
            {
                if (Char.IsDigit(c) == false && c != '.')
                {
                    MessageBox.Show("Only Numbers and (.) are Allowed.", _programTitle);
                }
            }
        }

        private void _01DistanceCalculatorApp_Load(object sender, EventArgs e)
        {
            //Input Fields Empty
            StartLatitudeTextBox.Text = "0";
            StartLongitudeTextBox.Text = "0";

            EndLatitudeTextBox.Text = "0";
            EndLongitudeTextBox.Text = "0";

            //Result Fields Empty

            KilometerTextBox.Text = String.Empty;
            MeterTextBox.Text = String.Empty;
            NautilesMilesTextBox.Text = String.Empty;
            MilesTextBox.Text = String.Empty;
        }

        private void StartLatitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StartLatitudeTextBox.Text == String.Empty)
                StartLatitudeTextBox.Text = "0";

            else
                StringValidation(StartLatitudeTextBox.Text);

        }

        private void StartLongitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StartLongitudeTextBox.Text == String.Empty)
                StartLongitudeTextBox.Text = "0";

            else
                StringValidation(StartLongitudeTextBox.Text);

        }

        private void EndLatitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EndLatitudeTextBox.Text == String.Empty)
                EndLatitudeTextBox.Text = "0";

            else
                StringValidation(EndLatitudeTextBox.Text);
        }

        private void EndLongitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EndLongitudeTextBox.Text == String.Empty)
                EndLongitudeTextBox.Text = "0";

            else
                StringValidation(EndLongitudeTextBox.Text);

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (StartLatitudeTextBox.Text == String.Empty || StartLongitudeTextBox.Text == String.Empty ||
               EndLatitudeTextBox.Text == String.Empty || EndLongitudeTextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Fields are Empty.Please Fill up All the Fields.", _programTitle);
            }
            else
            {
                //Start Co ordination Value Conversion
                double startLatitude = Convert.ToDouble(StartLatitudeTextBox.Text);
                startLatitude *= (Math.PI / 180);//Radians Conversation

                double startLongitude = Convert.ToDouble(StartLongitudeTextBox.Text);
                startLongitude *= (Math.PI / 180);//Radians Conversation

                //End Co ordinate Value Conversion
                double endLatitude = Convert.ToDouble(EndLatitudeTextBox.Text);
                endLatitude *= (Math.PI / 180);//Radians Conversation

                double endLongitude = Convert.ToDouble(EndLongitudeTextBox.Text);
                endLongitude *= (Math.PI / 180);//Radians Conversation

                //Difference Between two Coordinates
                double latitudeDifference = Math.Abs(endLatitude - startLatitude);
                double longitudeDifference = Math.Abs(endLongitude - startLatitude);

                //Calculation For Distance
                double angles = Math.Sin(latitudeDifference / 2) * Math.Sin(latitudeDifference / 2) +
                                    Math.Cos(startLatitude) * Math.Cos(endLatitude) *
                                        Math.Sin(longitudeDifference / 2) * Math.Sin(longitudeDifference / 2);

                double curious = 2 * Math.Atan2(Math.Sqrt(angles), Math.Sqrt(1 - angles));


                double distance = _earthRadius * curious;//distance in meters

                //Values in Meter
                double meters = distance;
                MeterTextBox.Text = String.Format("{0:F6}", meters);

                //Converting Meters into Miles
                double miles = distance / 1609.334;
                MilesTextBox.Text = String.Format("{0:F6}", miles);

                //Converting Meters into Kilometers
                double kilometers = distance / 1000;
                KilometerTextBox.Text = String.Format("{0:F6}", kilometers);

                //converting meters in Nautical miles
                double nauticalmiles = distance / 1852;
                NautilesMilesTextBox.Text = String.Format("{0:F6}", nauticalmiles);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Input Fields Empty
            StartLatitudeTextBox.Text = "0";
            StartLongitudeTextBox.Text = "0";

            EndLatitudeTextBox.Text = "0";
            EndLongitudeTextBox.Text = "0";

            //Result Fields Empty

            KilometerTextBox.Text = String.Empty;
            MeterTextBox.Text = String.Empty;
            NautilesMilesTextBox.Text = String.Empty;
            MilesTextBox.Text = String.Empty;
        }

        private void _01DistanceCalculatorApp_FormClosing(object sender, FormClosingEventArgs e)
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
