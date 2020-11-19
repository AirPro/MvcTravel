using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Models.DomainModels
{
	public class Venue
	{
		public int VenueId { get; set; }

		[StringLength(100)]
		[Required(ErrorMessage = "Please enter a Venue Name.")]
		public string VenueName { get; set; }

		[StringLength(100)]
		[Required(ErrorMessage = "Please enter a Venue Address.")]
		public string VenueAddress { get; set; }

		[StringLength(100)]
		[Required(ErrorMessage = "Please enter the Venue Contact Information.")]
		public String VenueContactInfo { get; set; }
	}
}
