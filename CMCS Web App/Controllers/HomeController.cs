using CMCS_Web_App.Data;
using CMCS_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CMCS_Web_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            //_context.Add(new Lecturer
            //{
            //    FirstName = "John",
            //    Surname = "Doe",
            //    Email = "john@doe.com",
            //    Faculty = "Science"
            //});

            //_context.SaveChanges();

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult CreateClaim()
        {
            return View();
        }

        public IActionResult ReviewClaim()
        {
            return View();
        }

        public IActionResult RegisterUser(Lecturer lecturer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lecturer);
                _context.SaveChanges();
            }
            else
            {
                return View("Register");
            }

            return RedirectToAction("Login", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
