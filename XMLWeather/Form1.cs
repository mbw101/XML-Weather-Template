using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                // create a day object
                Day d = new Day();

                // get the date
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                // get the conditions number
                reader.ReadToFollowing("symbol");
                d.conditionNumber = Convert.ToInt16(reader.GetAttribute("number"));

                // get the min and max temperatures
                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                // if day object not null add to the days list
                if (d.date != null)
                {
                    days.Add(d);
                }
            }

            reader.Close();
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            // Get the city and country
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");
            reader.ReadToFollowing("country");
            days[0].location += ", " + reader.ReadString();

            // gets all the min, max, and current temperatures
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
            days[0].tempLow = reader.GetAttribute("min");
            days[0].tempHigh = reader.GetAttribute("max");

            // gets the condition number associated with current day
            reader.ReadToFollowing("weather");
            days[0].conditionNumber = Convert.ToInt16(reader.GetAttribute("number"));

            reader.Close();

        }

    }
}
