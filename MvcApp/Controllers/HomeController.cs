using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcApp.Models;
using MvcApp.Models.DB;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBlogRepository _repo;

        public HomeController(ILogger<HomeController> logger, IBlogRepository repoo)
        {
            _logger = logger;
            _repo = repoo;
        }

        public IActionResult Index()
        {
            // var newUser = new User()
            // {
            //     Id = Guid.NewGuid(),
            //     FirstName = "Andrey",
            //     LastName = "Petrov",
            //     JoinDate = DateTime.Now
            // };
            // await _repo.AddUser(newUser);
            //
            // Console.WriteLine($"User with id {newUser.Id}, named {newUser.FirstName} was successfully added on {newUser.JoinDate}");
            //
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

        // public async Task<IActionResult> Authors()
        // {
        //     var authors = await _repo.GetUsers();
        //     return View(authors);
        // }
    }
}
