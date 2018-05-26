using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tets.Models;

namespace Tets.Controllers
{
    public class HomeController : Controller
    {
        PersonDbContext db = new PersonDbContext();
        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Person> people = db.People;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.People = people;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}