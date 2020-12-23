using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.DataContext;

namespace AYSAdalet.Controllers
{
    public class AdminController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();

        int toplampersonel = 200;
        public ActionResult Index()
        {

            ViewBag.toplamKayit = db.Personel.Count();
            ViewBag.toplamPersonelYuzdesi = yuzdesi();
            ViewBag.toplampersonel = toplampersonel;
            return View();
        }

        public double yuzdesi()
        {
            return (double)db.Personel.Count() * 100 / toplampersonel;
        }


        public ActionResult Notlar()
        {
            return View();
        }
    }
}