using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Controllers
{
    public class HomeController : Controller
    {
        public Order custOrder = new Order();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Pizzas()
        {
            
            return View();
            
        }

        public IActionResult orderPage()
        {

            return View();

        }
        public IActionResult orderConfirmation()
        {

            return View();

        }
        public IActionResult thanks()
        {

            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /*protected void checkclick_click(object sender, EventArgs e)
        {
            hide.style.display = "block";
            
        }*/
    }
}
