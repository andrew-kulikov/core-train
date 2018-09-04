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
			return new JsonResult(new List<object>
			{
				new { id = 1, Name = "NY" },
				new { id = 2, Name = "LA" }
			});
		}
	}
}