using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormSubmission.Models;

namespace FormSubmission.Controllers
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
        [HttpPost("user/create")]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User()
                {
                    FirstName = user.FirstName, 
                    LastName = user.LastName, 
                    Email = user.Email, 
                    Age = user.Age, 
                    Password = user.Password
                };
                Console.WriteLine($"First Name: {user.FirstName} Last Name: {user.LastName} Email: {user.Email} Age: {user.Age} Password: {user.Password}");
                return RedirectToAction("Result");

            }
            else
                return View("Index");

        }
        public string Result()
        {
            return "Successfuly Created";
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
