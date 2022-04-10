using FirstCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstCoreApp.Controllers
{
    public class HomeController : Controller
    {


        NewsContext db;
        public  HomeController(NewsContext context, ILogger<HomeController> logger)
        {
            db = context;
            _logger = logger;
        }
        
        private readonly ILogger<HomeController> _logger;

    

        public IActionResult Index()
        {
     var res = db.Catogeries.ToList();
            return View(res);
        }

        public IActionResult Contact()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult SaveContact(Contact_Us model)
        {
            db.Contacts.Add(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult About()
        {

            return View();
        }

        public IActionResult Team()
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
    }
}