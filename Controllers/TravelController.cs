using Microsoft.AspNetCore.Mvc;
using Models.DomainModels;
using MvcTravel.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Controllers
{
	public class TravelController : Controller
	{
		private ClassMvcTravelUnitOfWork data { get; set; }
		public TravelController(MvcTravelContext ctx) => data = new ClassMvcTravelUnitOfWork(ctx);

		public ViewResult Index(int id)
		{
            // options for Event query
            var eventOptions = new QueryOptions<Event>
            {
                OrderBy = e => e.EventId
            };

            // options for Venue query
            var venueOptions = new QueryOptions<Venue>
            {
                Includes = "VenueName, PromoterName"
            };
            if (id == 0)
            {
                venueOptions.OrderBy = e => e.VenueId;
                //venueOptions.ThenOrderBy = e => c.MilitaryTime;
            }
            else
            {
                //venueOptions.Where = e => Id == id;
                venueOptions.OrderBy = e => e.VenueName;
            }

            // execute queries
            ViewBag.Events = data.Events.List(eventOptions);
            return View(data.Events.List(eventOptions));

        }

		//public IActionResult Index()
		//{
		//	return View();
		//}
	}
}
