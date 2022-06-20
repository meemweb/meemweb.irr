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
            return View(); 
        }
        public IActionResult ContactPage()
        {
            var contact = new Contact()
            {
                Email = "mojtabamoradiw@gmail.com",
                Mobile = "09382420202",
                Instagram = "instagram.com/meemweb",
                Github = "github.com/meemweb",
                Whatsapp = "https://api.whatsapp.com/send?phone=+989382420202&text=%D8%B3%D9%84%D8%A7%D9%85%20%D9%88%D9%82%D8%AA%20%D8%A8%D8%AE%DB%8C%D8%B1&source=&data="
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
