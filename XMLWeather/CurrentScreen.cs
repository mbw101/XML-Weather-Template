using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCondition()
        {
            if (Form1.days[0].conditionNumber >= 200 && Form1.days[0].conditionNumber <= 232)
            {
                // thunderstorm
                conditionsLabel.Text = "Thunderstorm";
                imageBox.BackgroundImage = Properties.Resources.storm;
            }
            else if ((Form1.days[0].conditionNumber >= 300 && Form1.days[0].conditionNumber <= 321)
                || (Form1.days[0].conditionNumber >= 500 && Form1.days[0].conditionNumber <= 531))
            {
                // rain
                conditionsLabel.Text = "Rain";
                imageBox.BackgroundImage = Properties.Resources.rain;
            }
            else if (Form1.days[0].conditionNumber >= 600 && Form1.days[0].conditionNumber <= 622)
            {
                // snow
                conditionsLabel.Text = "Snow";
                imageBox.BackgroundImage = Properties.Resources.snow;
            }
            else if (Form1.days[0].conditionNumber >= 801 && Form1.days[0].conditionNumber <= 804)
            {
                // cloudy
                conditionsLabel.Text = "Cloudy";
                imageBox.BackgroundImage = Properties.Resources.cloudy;
            }
            else
            {
                // sun
                conditionsLabel.Text = "Sun";
                imageBox.BackgroundImage = Properties.Resources.sunny;
            }
        }

        public void DisplayCurrent()
        {
            // display the current location
            locationLabel.Text = Form1.days[0].location;

            // convert date and display it
            dateLabel.Text = DateTime.Now.ToString("dddd, h:mm tt");

            // display current temperatures and min/max temperatures
            currentLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.") + "°C";
            minLabel.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + "°C";
            maxLabel.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + "°C";

            // write current condition
            DisplayCondition();
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
