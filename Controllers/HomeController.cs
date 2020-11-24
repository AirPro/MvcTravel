using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcTravel.Models;
using MvcTravel.Models.DataLayer;
using MvcTravel.Models.ViewModel;
using System.Diagnostics;
using System.Linq;

namespace MvcTravel.Controllers
{
	public class HomeController : Controller
	{
		//private readonly  MvcTravelContext dbSet = new MvcTravelContext();

		private readonly ILogger<HomeController> _logger;


		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			//var tables = new MvcTravelViewModel()
			//{
			//	Events=dbSet.Event.ToList(),
			//	Venues=dbSet.Venue.ToList(),
			//	Promoters=dbSet.Promoter.ToList()

			//};
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
