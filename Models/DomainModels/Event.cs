using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Models
{
	public class Event
	{
		public int EventId { get; set; }

		[StringLength(100)]
		[Required(ErrorMessage = "Please enter the Event Name.")]
		public string EventName { get; set; }

		[StringLength (50)]
		[Required(ErrorMessage = "Please enter a Event City.")]
		public string EventCity { get; set; }

		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
		[Required(ErrorMessage = "Please enter the Event Date in dd-MM-yyyy form.")]
		public DateTime EventDate { get; set; }

		public ICollection<Event> Events { get; set; }

		public int VenueId { get; set; }                  // Foreign key property
		public Venue Venue { get; set; }                // Navigation property

		public int PromoterId { get; set; }                      // Foreign key property
		public Promoter Promoter { get; set; }                        // Navigation property
	}
}
