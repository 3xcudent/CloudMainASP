using CloudMainASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CloudMainASP.Controllers
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

    
        [HttpGet]
        [Route("regulamin")]
        public IActionResult Regulamin()
        {
            return View();
        }
        [HttpGet]
        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        [Route("listagenerowana")]
        public IActionResult listagenerowana()
        {
            return View();
        }
        [HttpGet]
        [Route("wyswietlanie")]
        public IActionResult wyswietlanie()
        {
            return View();
        }
        [HttpGet]
        [Route("ogloszenia")]
        public IActionResult ogloszenia()
        {
            return View();
        }
        [HttpGet]
        [Route("kontakt")]
        public IActionResult kontakt()
        {
            return View();
        }
    }
}
