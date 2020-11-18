using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Models
{
	public class Venue
	{
		public int VenueId { get; set; }

		[StringLength(100)]
		[Required]
		public string VenueName { get; set; }

		[StringLength(100)]
		[Required]
		public string VenueAddress { get; set; }

		[StringLength(100)]
		[Required]
		public String VenueContactInfo { get; set; }
	}
}
