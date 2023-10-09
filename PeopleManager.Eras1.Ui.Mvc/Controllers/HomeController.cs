using Microsoft.AspNetCore.Mvc;
using PeopleManager.Eras1.Ui.Mvc.Models;
using System.Diagnostics;

namespace PeopleManager.Eras1.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FirstName = "Bavo";

            var people = GetPeople();

            return View(people);
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private IList<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person { FirstName = "Bavo", LastName = "Ketels", Email = "bavo.ketels@vives.be" },
                new Person { FirstName = "Bavo2", LastName = "Ketels2", Email = "bavo2.ketels@vives.be" },
                new Person { FirstName = "Bavo3", LastName = "Ketels3", Email = "bavo3.ketels@vives.be" },
                new Person { FirstName = "Bavo4", LastName = "Ketels4", Email = "bavo4.ketels@vives.be" },
                new Person { FirstName = "Bavo5", LastName = "Ketels5", Email = "bavo5.ketels@vives.be" }
            };
        }
    }
}