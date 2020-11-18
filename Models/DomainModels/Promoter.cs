using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Models
{
	public class Promoter
	{
		public int PromoterId { get; set; }

		[StringLength(100)]
		[Required]
		public string PromoterName { get; set; }

		[StringLength(100)]
		[Required]
		public string PromoterAddress { get; set; }

		[StringLength(100)]
		[Required]
		public string PromoterContactInfo { get; set; }
	}
}
