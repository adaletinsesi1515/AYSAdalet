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
            var Model = db.BilgiTalepler.Where(X => X.Durum == false).ToList();
            var birimlist = db.PersonelGorevYerleri.ToList();
            ViewBag.birimlist1 = birimlist;

            var unvanlist = db.Unvanlar.ToList();
            ViewBag.urvanlist1 = unvanlist;

            var personellist = db.Personel.ToList();
            ViewBag.personellist1= personellist;

            ViewBag.toplamKayit = db.Personel.Count();
            ViewBag.toplamPersonelYuzdesi = yuzdesi();
            ViewBag.toplampersonel = toplampersonel;
            return View(Model);
        }

        public double yuzdesi()
        {
            return (double)db.Personel.Count() * 100 / toplampersonel;
        }


        public ActionResult Notlar()
        {
            return View();
        }

        public ActionResult Model()
        {
            var model1 = db.BilgiTalepler.ToList();
            return View();

        }

        public ActionResult BilgiTalepFormListe()
        {
            var Model = db.BilgiTalepler.Where(X => X.Durum == false).ToList();
            var birimlist = db.PersonelGorevYerleri.ToList();
            ViewBag.birimlist1 = birimlist;

            var unvanlist = db.Unvanlar.ToList();
            ViewBag.urvanlist1 = unvanlist;

            var personellist = db.Personel.ToList();
            ViewBag.personellist1 = personellist;
            return View(Model);
        }
    }
}