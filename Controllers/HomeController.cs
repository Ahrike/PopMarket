using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PopMarket.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PopMarket.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerInfo info)
        {
            _logger.LogInformation("Starting Index...");
            double amount = info.amount;

            return RedirectToActionPermanent("Index", "Pop", new { amount = amount});
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

        /* Notes
    * the products can be added to a database and be fetch with query or stored procedure but since for this demo
    * i only image the customer has just a merchant on it platform. At the point of signing up to the platform, the platform can assign an id 
    * to each creator, Insert their details to a database.
    *The platform can also create a module where creators can login to delete contents they dont want to display again, upload new ones
    * edit price and all
    */

    }
}
