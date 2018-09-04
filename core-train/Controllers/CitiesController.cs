using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace coreTrain.Controllers
{
	[Route("api/cities")]
	public class CitiesController : Controller
	{
		[HttpGet]
		public IActionResult GetCities() => Ok(CitiesDataStore.Current.Cities);

		[HttpGet("{id:int}")]
		public IActionResult GetCity(int id)
		{
			var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
			if (city == null)
				return NotFound();

			return Ok(city);
		}
	}
}