using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace coreTrain.Controllers
{
	[Route("api/cities")]
	public class CitiesController : Controller
	{
		[HttpGet]
		public JsonResult Index()
		{		
			return new JsonResult(CitiesDataStore.Current.Cities);
		}
	}
}