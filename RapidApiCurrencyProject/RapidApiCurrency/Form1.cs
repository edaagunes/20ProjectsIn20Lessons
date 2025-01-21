using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidApiCurrency
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		decimal dollar = 0;
		decimal euro = 0;
		decimal pound = 0;

		private async void Form1_Load(object sender, EventArgs e)
		{
			#region Dollar
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
				Headers =
	{
		{ "x-rapidapi-key", "8189ffcc04msh89957af40346776p12f8ebjsndc8eef993d4e" },
		{ "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var json = JObject.Parse(body);
				var value=json["result"].ToString();
				lblDollar.Text = value;
				dollar = Convert.ToDecimal(value);
			}
			#endregion

			#region Euro
			var client2 = new HttpClient();
			var request2 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
				Headers =
	{
		{ "x-rapidapi-key", "8189ffcc04msh89957af40346776p12f8ebjsndc8eef993d4e" },
		{ "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
	},
			};
			using (var response2 = await client2.SendAsync(request2))
			{
				response2.EnsureSuccessStatusCode();
				var body2 = await response2.Content.ReadAsStringAsync();
				var json2 = JObject.Parse(body2);
				var value2 = json2["result"].ToString();
				lblEuro.Text = value2;
				euro = Convert.ToDecimal(value2);
			}
			#endregion

			#region Pound
			var client3 = new HttpClient();
			var request3 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
				Headers =
	{
		{ "x-rapidapi-key", "8189ffcc04msh89957af40346776p12f8ebjsndc8eef993d4e" },
		{ "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
	},
			};
			using (var response3 = await client3.SendAsync(request3))
			{
				response3.EnsureSuccessStatusCode();
				var body3 = await response3.Content.ReadAsStringAsync();
				var json3 = JObject.Parse(body3);
				var value3 = json3["result"].ToString();
				lblPound.Text = value3;
				pound = Convert.ToDecimal(value3);
			}
			#endregion

			txtTotalPrice.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text);
			decimal totalPrice = 0;

			if (rdbDollar.Checked)
			{
				totalPrice = unitPrice * dollar; 
			}
			else if (rdbEuro.Checked)
			{
				totalPrice = unitPrice * euro;
			}
			else if (rdbPound.Checked)
			{
				totalPrice = unitPrice * pound;
			}
			txtTotalPrice.Text = totalPrice.ToString();
		}
	}
}
