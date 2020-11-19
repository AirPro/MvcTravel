using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Models.DomainModels
{
	public class Promoter
	{
		public int PromoterId { get; set; }

		[StringLength(100)]
		[Required(ErrorMessage = "Please enter a Promoter Name.")]
		public string PromoterName { get; set; }

		[StringLength(100)]
		[Required(ErrorMessage = "Please enter a Promoter Address.")]
		public string PromoterAddress { get; set; }

		[StringLength(100)]
		[Required(ErrorMessage = "Please enter the Promoter Contact Information.")]
		public string PromoterContactInfo { get; set; }
	}
}
