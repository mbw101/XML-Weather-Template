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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void DisplayCondition(int day)
        {
            // TODO: save condition and change all the 5 day pictures
            string conditionsText;
            Image conditionsImage;

            if (Form1.days[day].conditionNumber >= 200 && Form1.days[day].conditionNumber <= 232)
            {
                // thunderstorm
                conditionsText = "Thunderstorm";
                conditionsImage = Properties.Resources.storm;
            }
            else if ((Form1.days[day].conditionNumber >= 300 && Form1.days[day].conditionNumber <= 321)
                || (Form1.days[day].conditionNumber >= 500 && Form1.days[day].conditionNumber <= 531))
            {
                // rain
                conditionsText = "Rain";
                conditionsImage = Properties.Resources.rain;
            }
            else if (Form1.days[day].conditionNumber >= 600 && Form1.days[day].conditionNumber <= 622)
            {
                // snow
                conditionsText = "Snow";
                conditionsImage = Properties.Resources.snow;
            }
            else if (Form1.days[day].conditionNumber >= 801 && Form1.days[day].conditionNumber <= 804)
            {
                // cloudy
                conditionsText = "Cloudy";
                conditionsImage = Properties.Resources.cloudy;
            }
            else
            {
                // 800 = sun
                conditionsText = "Sunny";
                conditionsImage = Properties.Resources.sunny;
            }

            for (int counter = 0; counter <= 5; counter++)
            {
                switch (counter)
                {
                    case 0:
                        conditions1Label.Text = conditionsText;
                        imageBox1.BackgroundImage = conditionsImage;
                        break;

                    case 1:
                        conditions2Label.Text = conditionsText;
                        imageBox2.BackgroundImage = conditionsImage;
                        break;

                    case 2:
                        conditions3Label.Text = conditionsText;
                        imageBox3.BackgroundImage = conditionsImage;
                        break;

                    case 3:
                        conditions4Label.Text = conditionsText;
                        imageBox4.BackgroundImage = conditionsImage;
                        break;

                    case 4:
                        conditions5Label.Text = conditionsText;
                        imageBox5.BackgroundImage = conditionsImage;
                        break;
                }
            }
        }

        public void displayForecast()
        {
            // TODO: Show next 5 days 
            locationLabel.Text = Form1.days[0].location;
            date1Label.Text = DateTime.Now.ToString("dddd, MMMM dd");

            for (int counter = 1; counter <= 4; counter++)
            {
                switch (counter)
                {
                    case 1:
                        date2Label.Text = DateTime.Now.AddDays(counter).ToString("dddd, MMMM dd");
                        break;

                    case 2:
                        date3Label.Text = DateTime.Now.AddDays(counter).ToString("dddd, MMMM dd");
                        break;

                    case 3:
                        date4Label.Text = DateTime.Now.AddDays(counter).ToString("dddd, MMMM dd");
                        break;

                    case 4:
                        date5Label.Text = DateTime.Now.AddDays(counter).ToString("dddd, MMMM dd");
                        break;
                }
            }

            for (int i = 0; i <= 4; i++)
            {
                switch (i)
                {
                    case 0:
                        
                        break;

                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
