using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Numbers.DistanceCalculator.BLL;

namespace Numbers.DistanceCalculator
{
    public partial class DistanceCalculator : Form
    {

        private DistanceCalculatorController _distanceCalculatorController;

        public DistanceCalculator()
        {
            InitializeComponent();
        }

        private void DistanceCalculator_Load(object sender, EventArgs e)
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

            _distanceCalculatorController = new DistanceCalculatorController();

        }

        private void StartLatitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StartLatitudeTextBox.Text == String.Empty)
            {
                if (!_distanceCalculatorController.StringValidation(StartLatitudeTextBox.Text))
                {
                    MessageBox.Show(Properties.Resources.onlyDoubleValueWarning, Properties.Resources.programTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StartLongitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StartLongitudeTextBox.Text == String.Empty)
            {
                if (!_distanceCalculatorController.StringValidation(StartLongitudeTextBox.Text))
                {
                    MessageBox.Show(Properties.Resources.onlyDoubleValueWarning, Properties.Resources.programTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EndLatitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EndLatitudeTextBox.Text == String.Empty)
            {
                if (!_distanceCalculatorController.StringValidation(EndLatitudeTextBox.Text))
                {
                    MessageBox.Show(Properties.Resources.onlyDoubleValueWarning, Properties.Resources.programTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void EndLongitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EndLongitudeTextBox.Text == String.Empty)
            {
                if (!_distanceCalculatorController.StringValidation(EndLongitudeTextBox.Text))
                {
                    MessageBox.Show(Properties.Resources.onlyDoubleValueWarning, Properties.Resources.programTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string[] distances = new string[4];

            if (tabControl1.SelectedTab.Text == "Two Co-Ordinates")
            {
                if (StartLatitudeTextBox.Text == String.Empty || StartLongitudeTextBox.Text == String.Empty ||
                    EndLatitudeTextBox.Text == String.Empty || EndLongitudeTextBox.Text == String.Empty)
                {
                    MessageBox.Show(Properties.Resources.emptyFieldWarning, Properties.Resources.programTitle);
                }
                else
                {
                    distances = _distanceCalculatorController.Calculatedistance(StartLongitudeTextBox.Text,
                        StartLongitudeTextBox.Text,
                        EndLatitudeTextBox.Text, EndLongitudeTextBox.Text);
                }

            }

            else if (tabControl1.SelectedTab.Text == "Two Cities")
            {
                if (StartCountryComboBox.Text == String.Empty || StartCityComboBox.Text == String.Empty ||
                    EndCountryComboBox.Text == String.Empty || EndCityComboBox.Text == String.Empty)
                {
                    MessageBox.Show(Properties.Resources.emptyFieldWarning, Properties.Resources.programTitle);
                }
                else
                {
                    string[] coordonates = new string[4];

                    coordonates = _distanceCalculatorController.getcitiesPositions(StartCountryComboBox.Text,
                        StartCityComboBox.Text, EndCountryComboBox.Text, EndCityComboBox.Text);

                    distances = _distanceCalculatorController.Calculatedistance(coordonates[0], coordonates[1],
                        coordonates[2], coordonates[3]);

                    
                }
            }

            else
            {
                for (int i = 0; i < 4; i++)
                    distances[i] = String.Empty;
            }

                MeterTextBox.Text = distances[0];

                MilesTextBox.Text = distances[1];

                KilometerTextBox.Text = distances[2];

                NautilesMilesTextBox.Text = distances[3];

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Input Fields Empty
            StartLatitudeTextBox.Text = "0";

            StartLongitudeTextBox.Text = "0";

            StartCountryComboBox.Items.Clear();

            StartCityComboBox.Items.Clear();

            EndLatitudeTextBox.Text = "0";

            EndLongitudeTextBox.Text = "0";

            EndCountryComboBox.Items.Clear();

            EndCityComboBox.Items.Clear();
            //Result Fields Empty

            KilometerTextBox.Text = String.Empty;

            MeterTextBox.Text = String.Empty;

            NautilesMilesTextBox.Text = String.Empty;

            MilesTextBox.Text = String.Empty;
        }
        private void StartCityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CountryName = StartCountryComboBox.Text;

            string CityName = StartCityComboBox.Text;

            string position = _distanceCalculatorController.getPosition(CountryName, CityName);

            StartPositionLabel.Text = position;
        }

        private void StartCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartCityComboBox.Items.Clear();

            string countryName = StartCountryComboBox.Text;

            List<string> cityList = new List<string>();

            cityList = _distanceCalculatorController.getCityList(countryName);

            foreach (string cityName in cityList)
            {
                StartCityComboBox.Items.Add(cityName);
            }
        }

        private void EndCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EndCityComboBox.Items.Clear();

            string countryName = EndCountryComboBox.Text;

            List<string> cityList = new List<string>();

            cityList = _distanceCalculatorController.getCityList(countryName);

            foreach (string cityName in cityList)
            {
                EndCityComboBox.Items.Add(cityName);
            }
        }

        private void EndCityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CountryName = EndCountryComboBox.Text;

            string CityName = EndCityComboBox.Text;

            string position = _distanceCalculatorController.getPosition(CountryName, CityName);

            EndPositionLabel.Text = position;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> countryList = new List<string>();

            countryList = _distanceCalculatorController.getCountryList();

            foreach (string country in countryList)
            {
                StartCountryComboBox.Items.Add(country);
                EndCountryComboBox.Items.Add(country);
            }
        }
    }
}

