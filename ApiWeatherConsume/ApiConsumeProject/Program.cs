#region Menü Başlangıcı
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json.Nodes;

Console.WriteLine("Api Consume İşlemine Hoş Geldiniz");
Console.WriteLine();
Console.WriteLine("Lütfen işlem yapmak istediğiniz servisi seçiniz");
Console.WriteLine();
Console.WriteLine("1- Şehir Listesini Getir");
Console.WriteLine("2- Şehir ve Hava Durumu Listesi");
Console.WriteLine("3- Yeni Şehir Ekleme");
Console.WriteLine("4- Şehir Silme İşlemi");
Console.WriteLine("5- Şehir Güncelleme İşlemi");
Console.WriteLine("6- Id'ye göre Şehir Getirme");
#endregion

string number;

Console.Write("Tercihiniz: ");
number = Console.ReadLine();
Console.WriteLine();

if (number == "1")
{
	string url = "https://localhost:7117/api/Weathers";
	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.GetAsync(url);
		string responseBody = await response.Content.ReadAsStringAsync();
		JArray jArray = JArray.Parse(responseBody);
		foreach (var item in jArray)
		{
			string cityName = item["cityName"].ToString();
			Console.WriteLine($"Şehir Adı: {cityName}");
		}
	}
}
if (number == "2")
{
	string url = "https://localhost:7117/api/Weathers";
	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.GetAsync(url);
		string responseBody = await response.Content.ReadAsStringAsync();
		JArray jArray = JArray.Parse(responseBody);
		foreach (var item in jArray)
		{
			string cityName = item["cityName"].ToString();
			string temp = item["temp"].ToString();
			string country = item["country"].ToString();
			Console.WriteLine(cityName + "-" + country + "-->" + temp + "Derece");
		}
	}
}
if (number == "3")
{
	Console.WriteLine("Şehir Ekleme Alanı");
	Console.WriteLine();
	string cityName, country, detail;
	decimal temp;

	Console.Write("Şehir Adı: ");
	cityName = Console.ReadLine();

	Console.Write("Ülke: ");
	country = Console.ReadLine();

	Console.Write("Sıcaklık: ");
	temp = Convert.ToDecimal(Console.ReadLine());

	Console.Write("Detay: ");
	detail = Console.ReadLine();

	string url = "https://localhost:7117/api/Weathers";
	var newWeatherCity = new
	{
		cityName = cityName,
		country = country,
		temp = temp,
		detail = detail
	};

	using (HttpClient client = new HttpClient())
	{
		string json = JsonConvert.SerializeObject(newWeatherCity);
		StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
		HttpResponseMessage response = await client.PostAsync(url, content);
		response.EnsureSuccessStatusCode();
	}
}
if (number == "4")
{
	string url = "https://localhost:7117/api/Weathers?id=";
	Console.Write("Silmek İstediğiniz Id Değeri");
	int id=int.Parse(Console.ReadLine());

	using (HttpClient client=new HttpClient())
	{
		HttpResponseMessage response = await client.DeleteAsync(url + id);
		response.EnsureSuccessStatusCode();
	}
}
if (number == "5")
{
	string url = "https://localhost:7117/api/Weathers";
	Console.WriteLine("Şehir Güncelleme Alanı");
	Console.WriteLine();
	string cityName, country, detail;
	decimal temp;
	int cityId;

	Console.Write("Şehir Adı: ");
	cityName = Console.ReadLine();

	Console.Write("Ülke: ");
	country = Console.ReadLine();

	Console.Write("Sıcaklık: ");
	temp = Convert.ToDecimal(Console.ReadLine());

	Console.Write("Detay: ");
	detail = Console.ReadLine();

	Console.Write("Şehir Id: ");
	cityId = Convert.ToInt32(Console.ReadLine());

	var updatedWeatherValues= new
	{
		cityName = cityName,
		country = country,
		temp = temp,
		detail = detail,
		cityId = cityId
	};

	using (HttpClient client=new HttpClient())
	{
		string json =JsonConvert.SerializeObject(updatedWeatherValues);
		StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
		HttpResponseMessage response = await client.PutAsync(url, content);
		response.EnsureSuccessStatusCode();
	}	
}

if (number=="6")
{
	string url = "https://localhost:7117/api/Weathers/GetByIdWeatherCity?id=";
	Console.Write("Bilgilerini Getirmek İstediğiniz Id Değeri: ");
	int id = Convert.ToInt32(Console.ReadLine());

	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.GetAsync(url + id);
		response.EnsureSuccessStatusCode();
		string responseBody = await response.Content.ReadAsStringAsync();
		JObject jObject = JObject.Parse(responseBody);

		string cityName = jObject["cityName"].ToString();
		decimal temp = decimal.Parse(jObject["temp"].ToString());
		string country = jObject["country"].ToString();
		string detail = jObject["detail"].ToString();

		Console.WriteLine(cityName + "-" + country + "-->" + " " + detail +" " + temp + " " + "Derece");
	}
}

Console.Read();
