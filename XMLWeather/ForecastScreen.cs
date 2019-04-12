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
            DisplayCondition();
        }

        public void DisplayCondition()
        {
            // save condition and change all the 5 day pictures
            string conditionsText;
            Image conditionsImage;
            int counter = 0;

            foreach (Day day in Form1.days)
            {
                if (day.conditionNumber >= 200 && day.conditionNumber <= 232)
                {
                    // thunderstorm
                    conditionsText = "Thunderstorm";
                    conditionsImage = Properties.Resources.storm;

                    if (counter == 0)
                    {
                        conditions1Label.Text = conditionsText;
                        imageBox1.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 1)
                    {
                        conditions2Label.Text = conditionsText;
                        imageBox2.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 2)
                    {
                        conditions3Label.Text = conditionsText;
                        imageBox3.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 3)
                    {
                        conditions4Label.Text = conditionsText;
                        imageBox4.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 4)
                    {
                        conditions5Label.Text = conditionsText;
                        imageBox5.BackgroundImage = conditionsImage;
                    }
                }
                else if ((day.conditionNumber >= 300 && day.conditionNumber <= 321)
                    || (day.conditionNumber >= 500 && day.conditionNumber <= 531))
                {
                    // rain
                    conditionsText = "Rain";
                    conditionsImage = Properties.Resources.rain;

                    if (counter == 0)
                    {
                        conditions1Label.Text = conditionsText;
                        imageBox1.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 1)
                    {
                        conditions2Label.Text = conditionsText;
                        imageBox2.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 2)
                    {
                        conditions3Label.Text = conditionsText;
                        imageBox3.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 3)
                    {
                        conditions4Label.Text = conditionsText;
                        imageBox4.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 4)
                    {
                        conditions5Label.Text = conditionsText;
                        imageBox5.BackgroundImage = conditionsImage;
                    }
                }
                else if (day.conditionNumber >= 600 && day.conditionNumber <= 622)
                {
                    // snow
                    conditionsText = "Snow";
                    conditionsImage = Properties.Resources.snow;

                    if (counter == 0)
                    {
                        conditions1Label.Text = conditionsText;
                        imageBox1.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 1)
                    {
                        conditions2Label.Text = conditionsText;
                        imageBox2.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 2)
                    {
                        conditions3Label.Text = conditionsText;
                        imageBox3.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 3)
                    {
                        conditions4Label.Text = conditionsText;
                        imageBox4.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 4)
                    {
                        conditions5Label.Text = conditionsText;
                        imageBox5.BackgroundImage = conditionsImage;
                    }
                }
                else if (day.conditionNumber >= 801 && day.conditionNumber <= 804)
                {
                    // cloudy
                    conditionsText = "Cloudy";
                    conditionsImage = Properties.Resources.cloudy;

                    if (counter == 0)
                    {
                        conditions1Label.Text = conditionsText;
                        imageBox1.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 1)
                    {
                        conditions2Label.Text = conditionsText;
                        imageBox2.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 2)
                    {
                        conditions3Label.Text = conditionsText;
                        imageBox3.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 3)
                    {
                        conditions4Label.Text = conditionsText;
                        imageBox4.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 4)
                    {
                        conditions5Label.Text = conditionsText;
                        imageBox5.BackgroundImage = conditionsImage;
                    }
                }
                else
                {
                    // 800 = sun
                    conditionsText = "Sunny";
                    conditionsImage = Properties.Resources.sunny;

                    if (counter == 0)
                    {
                        conditions1Label.Text = conditionsText;
                        imageBox1.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 1)
                    {
                        conditions2Label.Text = conditionsText;
                        imageBox2.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 2)
                    {
                        conditions3Label.Text = conditionsText;
                        imageBox3.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 3)
                    {
                        conditions4Label.Text = conditionsText;
                        imageBox4.BackgroundImage = conditionsImage;
                    }
                    else if (counter == 4)
                    {
                        conditions5Label.Text = conditionsText;
                        imageBox5.BackgroundImage = conditionsImage;
                    }
                }

                counter++;
            }
        }

        public void displayForecast()
        {
            // Show next 5 days 
            // display the location
            locationLabel.Text = Form1.days[0].location;

            // display all the dates and days
            date1Label.Text = DateTime.Now.AddDays(0).ToString("dddd, MMMM dd");
            date2Label.Text = DateTime.Now.AddDays(1).ToString("dddd, MMMM dd");
            date3Label.Text = DateTime.Now.AddDays(2).ToString("dddd, MMMM dd");
            date4Label.Text = DateTime.Now.AddDays(3).ToString("dddd, MMMM dd");
            date5Label.Text = DateTime.Now.AddDays(4).ToString("dddd, MMMM dd");

            // display min/max tempertures for each day
            temperature1Label.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + "°C"
                + "/" + Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + "°C";

            temperature2Label.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.") + "°C"
                + "/" + Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.") + "°C";

            temperature3Label.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.") + "°C"
                + "/" + Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.") + "°C";

            temperature4Label.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0.") + "°C"
                + "/" + Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.") + "°C";

            temperature5Label.Text = Convert.ToDouble(Form1.days[4].tempLow).ToString("0.") + "°C"
                + "/" + Convert.ToDouble(Form1.days[4].tempHigh).ToString("0.") + "°C";
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

