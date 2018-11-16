using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Numbers.DistanceCalculator.DAL;

namespace Numbers.DistanceCalculator.BLL
{
    public class DistanceCalculatorController
    {
        public Database _cityDatabase = new Database();

        private const double _earthRadius = 6371137.00;

        public bool StringValidation(string value)
        {
            foreach (char c in value)
            {
                if (Char.IsDigit(c) == false && c != '.')
                {
                    return false;
                }
            }

            return true;
        }

        public string[] Calculatedistance(string startlat, string startlong, string endlat, string endlong)
        {
            string[] distancesStrings = new string[4];

            //Start Co ordination Value Conversion
            double startLatitude = Convert.ToDouble(startlat);
            startLatitude *= (Math.PI / 180);//Radians Conversation

            double startLongitude = Convert.ToDouble(startlong);
            startLongitude *= (Math.PI / 180);//Radians Conversation

            //End Co ordinate Value Conversion
            double endLatitude = Convert.ToDouble(endlat);
            endLatitude *= (Math.PI / 180);//Radians Conversation

            double endLongitude = Convert.ToDouble(endlong);
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
            distancesStrings[0] = string.Format("{0:F6}", meters);

            //Converting Meters into Miles
            double miles = distance / 1609.334;
            distancesStrings[1] = String.Format("{0:F6}", miles);

            //Converting Meters into Kilometers
            double kilometers = distance / 1000;
            distancesStrings[2] = String.Format("{0:F6}", kilometers);

            //converting meters in Nautical miles
            double nauticalmiles = distance / 1852;
            distancesStrings[3] = String.Format("{0:F6}", nauticalmiles);

            return distancesStrings;
        }

        public List<string> getCountryList()
        {   
            List<string> countryList = new List<string>();

            foreach (City city in _cityDatabase.CityList)
            {
                countryList.Add(city._Country);
            }

            return countryList.Distinct().ToList();   
        }

        public List<string> getCityList(string country)
        {
            List<string> cityList = new List<string>();

            foreach (City city in _cityDatabase.CityList)
            {
                if (city._Country == country)
                    cityList.Add(city._Name);
            }

            return cityList.Distinct().ToList();
        }

        public string getPosition(string countryName, string cityName)
        {
            string position = null;

            foreach (City city in _cityDatabase.CityList)
            {
                if (city._Country == countryName && city._Name == cityName)
                {
                    position = "Lat: " + Convert.ToString(city._Latitude) + "      Long: " + Convert.ToString(city._Longitude);
                    break;
                }

            }

            return position;
        }

        public string[] getcitiesPositions(string startcountry, string startcity, string endcountry, string endcity)
        {
            string[] positions = new string[4];

            foreach (City city in _cityDatabase.CityList)
            {
                if (city._Country == startcountry && city._Name == startcity)
                {
                    positions[0] = Convert.ToString(city._Latitude);
                    positions[1] = Convert.ToString(city._Longitude);
                }

                if (city._Country == endcountry && city._Name == endcity)
                {
                    positions[2] = Convert.ToString(city._Latitude);
                    positions[3] = Convert.ToString(city._Longitude);
                }

            }

            return positions;
        }
    }
}
