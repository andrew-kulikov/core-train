using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace coreTrain.Controllers
{
	[Route("api/cities")]
	public class CitiesController : Controller
	{
		[HttpGet]
		public JsonResult GetCities() => new JsonResult(CitiesDataStore.Current.Cities);

		[HttpGet("{id:int}")]
		public JsonResult GetCity(int id) => new JsonResult(
			CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id)
			);
	}
}