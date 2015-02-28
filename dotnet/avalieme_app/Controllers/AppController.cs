using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace avalieme_app.Controllers
{
    public class AppController : Controller
    {
        //
        // GET: /App/

        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                ViewBag.Message = "App Fisrt Page";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

    }
}
