using ApiProject.Context;
using ApiProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WeathersController : ControllerBase
	{
		private readonly WeatherContext _context;

		public WeathersController(WeatherContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult WeatherCityList()
		{
			var values = _context.Cities.ToList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateWeatherCity(City city)
		{
			_context.Cities.Add(city);
			_context.SaveChanges();
			return Ok("Şehir Eklendi");
		}

		[HttpDelete]
		public IActionResult DeleteWeatherCity(int id)
		{
			var value = _context.Cities.Find(id);
			_context.Cities.Remove(value);
			_context.SaveChanges();
			return Ok("Şehir Silindi");
		}

		[HttpPut]
		public IActionResult UpdateWeatherCity(City city)
		{
			var value = _context.Cities.Find(city.CityId);
			value.CityName = city.CityName;
			value.Detail = city.Detail;
			value.Temp = city.Temp;
			value.Country = city.Country;
			_context.SaveChanges();
			return Ok("Şehir Güncellendi");
		}

		[HttpGet("GetByIdWeatherCity")]
		public IActionResult GetByIdWeatherCity(int id)
		{
			var value = _context.Cities.Find(id);
			return Ok(value);
		}

		[HttpGet("TotalCityCount")]
		public IActionResult TotalCityCount()
		{
			var value= _context.Cities.Count();
			return Ok(value);
		}

		[HttpGet("MaxTempCityName")]
		public IActionResult MaxTempCityName()
		{
			var value=_context.Cities.OrderByDescending(x=>x.Temp).Select(y=>y.CityName).FirstOrDefault();
			return Ok(value);
		}

		[HttpGet("MinTempCityName")]
		public IActionResult MinTempCityName()
		{
			var value = _context.Cities.OrderBy(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
			return Ok(value);
		}
	}
}
