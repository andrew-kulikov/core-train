using coreTrain.Models;
using System.Collections.Generic;

namespace coreTrain
{
	public class CitiesDataStore
	{
		public static CitiesDataStore Current { get; } = new CitiesDataStore();
		public List<CityDto> Cities { get; set; }

		public CitiesDataStore()
		{
			Cities = new List<CityDto>()
			{
				new CityDto()
				{
					Id = 1,
					Name = "NY",
					Description = "sdfsdfsdfsdfsdf"
				},
				new CityDto()
				{
					Id = 2,
					Name = "LA",
					Description = "ert er ertsdf s"
				},
				new CityDto()
				{
					Id = 3,
					Name = "MSK",
					Description = "uioui uuiuj bv"
				},
			};
		}
	}
}
