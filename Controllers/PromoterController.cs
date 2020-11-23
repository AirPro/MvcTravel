using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTravel.Controllers
{
	public class PromoterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
