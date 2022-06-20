using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using meemweb_mvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace meemweb_mvc.Controllers
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

       public IActionResult Blog()
        {
            return View();
        }

        public IActionResult footer()
        {
            var contact = new Contact()
            {
                Email = "mojtabamoradiw@gmail.com",
                Mobile = "09382420202",
                Instagram = "instagram.com/meemweb",
            };
            return View(contact); 
        }
        public IActionResult Services()
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
