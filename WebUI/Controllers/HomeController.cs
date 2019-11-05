using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISecurityUpdateService _securityUpdateService;
        public HomeController(ILogger<HomeController> logger, ISecurityUpdateService securityUpdateService)
        {
            _logger = logger;
            _securityUpdateService = securityUpdateService ?? throw new ArgumentNullException("securityUpdateService");
        }

        public IActionResult Index(string filter)
        {
            ViewData["CurrentFilter"] = filter;

            var allUpdates = _securityUpdateService.GetAll();

            if (!String.IsNullOrEmpty(filter))
            {
                allUpdates = allUpdates.Where(s => s.Id.Contains(filter));
            }

            UpdatesViewModel updatesViewModel = new UpdatesViewModel(allUpdates.Select(e => new SecurityUpdateViewModel(e)));

            return View(updatesViewModel);
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
