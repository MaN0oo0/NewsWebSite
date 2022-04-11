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
    
            return View(db.Catogeries.ToList());
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


      
        public IActionResult Messages()
        {
            
            return View(db.Contacts.ToList());
        }


        public IActionResult News(int id)
        {
            Catogery c = db.Catogeries.Find(id);
            ViewBag.Cat = c.Name;
            
            //Loop to get CatogryName
          var res =  db.News.Where(x => x.CatogeryId == id).OrderByDescending(x=>x.date).ToList();
            return View(res);
        }



        public IActionResult DeleteNews(int id)

        {
           var resalt = db.News.Find(id);
            db.News.Remove(resalt);
            db.SaveChanges();


            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}