using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/istanbul/EN"),
				Headers =
	{
		{ "x-rapidapi-key", "8189ffcc04msh89957af40346776p12f8ebjsndc8eef993d4e" },
		{ "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();

				var json=JObject.Parse(body);
				var fahrenheit = json["main"]["feels_like"].ToString();
				var windSpeed = json["wind"]["speed"];
				var humidity = json["main"]["humidity"];
				double celcius=(double.Parse(fahrenheit)-32);
				double celciusValue = celcius / 1.8;

				var main = json["weather"][0]["main"].ToString();

				string imagePath = @"C:\Users\EdaGunes\Source\Repos\20ProjectsIn20Lessons\RapidApiWeatherProject\WeatherApp\images";
				string imageFile = "";

				switch (main)
				{
					case "Clouds":
						imageFile = "cloud.png";
						break;

					case "Clear":
						imageFile = "cloudandsun.png";
						break;

					case "Rain":
						imageFile = "rainy.png";
						break;

					case "Snow":
						imageFile = "snow.png";
						break;

					case "Sun":
						imageFile = "sun.png";
						break;

					default:
						imageFile = "cloudandsun.png"; 
						break;
				}

				string fullImagePath = Path.Combine(imagePath, imageFile);
				pictureBox1.Image = Image.FromFile(fullImagePath);

				lblFahrenheit.Text = fahrenheit;
				lblWindSpeed.Text = windSpeed.ToString();
				lblHumidity.Text = humidity.ToString();
				lblCelcius.Text = celciusValue.ToString("0.00");
			}
		}
	}
}
