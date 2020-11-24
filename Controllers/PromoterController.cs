using Microsoft.AspNetCore.Mvc;
using MvcTravel.Models.DataLayer;
using MvcTravel.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Controllers
{
	public class PromoterController : Controller
	{

		private ClassMvcTravelUnitOfWork data { get; set; }
		public PromoterController(MvcTravelContext ctx) => data = new ClassMvcTravelUnitOfWork(ctx);
		public ViewResult Index(int id)
		{
            var promoterOptions = new QueryOptions<Promoter>
            {
                OrderBy = p => p.PromoterId
            };

            if (id == 0)
            {
                promoterOptions.OrderBy = p => p.PromoterId;
            }
            else
            {
                promoterOptions.OrderBy = p => p.PromoterId;
            }

            // execute queries
            ViewBag.Promoters = data.Promoters.List(promoterOptions);
            return View(data.Promoters.List(promoterOptions));
        }
	}
}
