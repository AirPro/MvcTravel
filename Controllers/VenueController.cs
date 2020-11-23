using Microsoft.AspNetCore.Mvc;
using MvcTravel.Models.DataLayer;
using MvcTravel.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Controllers
{
	public class VenueController : Controller
	{
		private ClassMvcTravelUnitOfWork data { get; set; }
		public VenueController(MvcTravelContext ctx) => data = new ClassMvcTravelUnitOfWork(ctx);

		public ViewResult Index(int id)
        {
            // options for Venue query
            var venueOptions = new QueryOptions<Venue>
            {
                OrderBy = v => v.VenueId
            };

            if (id == 0)
            {
               venueOptions.OrderBy = v => v.VenueId;
            }
            else
            {
                venueOptions.OrderBy = v => v.VenueName;
            }

            // execute queries
            ViewBag.Venues = data.Venues.List(venueOptions);
            return View(data.Venues.List(venueOptions));

        }
    }
}
