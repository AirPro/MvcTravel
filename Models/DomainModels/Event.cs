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
		[Required]
		public string EventName { get; set; }

		[StringLength (50)]
		[Required]
		public string EventCity { get; set; }

		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
		[Required]
		public DateTime EventDate { get; set; }

		public ICollection<Event> Events { get; set; }
	}
}
