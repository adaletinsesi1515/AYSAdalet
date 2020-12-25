using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.DataContext;
using AYSAdalet.Models.Modeller;

namespace AYSAdalet.Controllers
{
    public class UnvanController : Controller
    {
        // GET: Unvanlar
        AdliyeDBContext db = new AdliyeDBContext();
        public ActionResult Index()
        {

            var Model1 = db.Unvanlar.ToList();
            return View(Model1);

        }

        [HttpGet]
        public ActionResult UnvanlarEkle()
        {
            var Model = db.Unvanlar.ToList();
            return View(Model);
        }


        [HttpPost]
        public ActionResult UnvanlarEkle(Unvanlar b)
        {
            
            db.Unvanlar.Add(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UnvanlarEklePartial()
        {
            return PartialView("UnvanlarEklePartial");
        }

      
        public ActionResult UnvanlarBilgiGetir(int id)
        {
            var iddegeri = db.Unvanlar.Find(id);

            return View("UnvanlarBilgiGetir", iddegeri);
        }

        public ActionResult UnvanlarGuncelle(Unvanlar c)
        {
            var deger = db.Unvanlar.Find(c.UnvanID);
            deger.Unvani= c.Unvani;
            
            db.SaveChanges();
            db.Entry(deger).State = EntityState.Modified;
            return RedirectToAction("Index");
        }
    }
}