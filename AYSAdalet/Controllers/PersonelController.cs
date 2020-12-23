using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.DataContext;
using AYSAdalet.Models.Modeller;
using AYSAdalet.ViewModels;

namespace AYSAdalet.Controllers
{
    public class PersonelController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();


        public ActionResult Index()
        {
            return View(db.Personel.ToList());
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            PersonelViewModel pvm = new PersonelViewModel()
            {
                Unvanlar = db.Unvanlar,
                Birimler = db.Birimler,
            };

            return View(pvm);
        }

        [HttpPost]
        public ActionResult Ekle(Personel personel)
        {
            db.Personel.Add(personel);
            db.SaveChanges();
            return RedirectToAction("Index", "Personel");
        }

        public ActionResult PersonalCard(int id)
        {
            var random = new Random();
            ViewBag.rasgele = random.Next(1, 100);
            var per = db.Personel.Find(id);
            return View(per);
        }

    }
}