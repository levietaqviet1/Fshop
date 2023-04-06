using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestIdentity.Areas.Identity.Data;
using TestIdentity.Models;

namespace TestIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<UsingIdentityUser> _userManager;
        public HomeController(ILogger<HomeController> logger, UserManager<UsingIdentityUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    var result = await _userManager.CreateAsync(new UsingIdentityUser { UserName = "user" + i, FirstName = "user", LastName = "user", Email = "user" + i + "@gmail.com" }, "User@1234567");
            //    if (result.Succeeded)
            //    {
            //        Console.WriteLine("Success");
            //    }
            //}

            return View();
        }
        [Authorize]
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