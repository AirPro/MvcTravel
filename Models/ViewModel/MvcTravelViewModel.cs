using MvcTravel.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Models.ViewModel
{
	public class MvcTravelViewModel
	{
		public IEnumerable<Event> Events { get; set; }
		public IEnumerable<Venue> Venues { get; set; }
		public IEnumerable<Promoter> Promoters { get; set; }
	}
}
