using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySite.Models;

namespace MySite.Controllers
{
    public class TheoryController : Controller
    {
        private readonly ILogger<TheoryController> _logger;

        TheoryContext context;
        public TheoryController(TheoryContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Articles.ToList());
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
