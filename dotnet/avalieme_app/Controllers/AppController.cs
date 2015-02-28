using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Newtonsoft.Json.Linq;

namespace avalieme_app.Controllers
{
    public class AppController : Controller
    {
        //
        // GET: /App/

        public ActionResult Index()
        {
            return RedirectToAction("Dashboard", "App");
        }

        public ActionResult Dashboard()
        {
            if (Request.IsAuthenticated)
            {
                ViewBag.Message = "Dashboard Page";
                ViewBag.Description = "See your Stats";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult Jobs()
        {
            if (Request.IsAuthenticated)
            {
                ViewBag.Message = "Jobs Page";
                ViewBag.Description = "Manage your Jobs";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult Clients()
        {
            if (Request.IsAuthenticated)
            {
                ViewBag.Message = "Clients Page";
                ViewBag.Description = "Manage your Clients";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

    }
}
