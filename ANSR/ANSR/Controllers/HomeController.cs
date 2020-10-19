using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ANSR.Models;

namespace ANSR.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Account()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult TaskCreated()
        {
            return View();
        }
        public IActionResult Analytics()
        {
            return View();
        }

        public IActionResult Issues()
        {
            return View();
        }

        public IActionResult Issue()
        {
            return View();
        }

        public IActionResult IssuesInProgress()
        {
            return View();
        }

        public IActionResult NewIssues()
        {
            return View();
        }

        public IActionResult AllIssues()
        {
            return View();
        }

        public IActionResult CompletedIssues()
        {
            return View();
        }

        public IActionResult NewIssue()
        {
            return View();
        }

        public IActionResult IssueReport()
        {
            return View();
        }

        public IActionResult Shops()
        {
            return View();
        }

    }
}
