using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.DataContext;

namespace AYSAdalet.Controllers
{
    public class HomeController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}