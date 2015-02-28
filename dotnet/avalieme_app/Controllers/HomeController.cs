using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace avalieme_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.Page = "active";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            ViewBag.Page = "active";
            return View();
        }

        public ActionResult Depoimentos()
        {
            ViewBag.Message = "Your app testimonials page.";
            ViewBag.Page = "active";
            return View();
        }

        public ActionResult Price()
        {
            ViewBag.Message = "Your app price page.";
            ViewBag.Page = "active";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Page = "active";
            return View();
        }
    }
}
