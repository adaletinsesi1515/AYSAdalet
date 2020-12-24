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
    public class BirimController : Controller
    {
        // GET: Birimler
        AdliyeDBContext db = new AdliyeDBContext();
        public ActionResult Index()
        {
            
            var Model = db.Birimler.Where(X => X.Durum== true).ToList();
            return View(Model);

        }

        [HttpGet]
        public ActionResult BirimlerEkle()
        {
            var Model = db.Birimler.Where(X => X.Durum == true).ToList();
            return View(Model);
        }


        [HttpPost]
        public ActionResult BirimlerEkle(Birimler b)
        {
                b.Durum = true;
                db.Birimler.Add(b);
                db.SaveChanges();
                return RedirectToAction("Index");
        }

        public ActionResult BirimlerEklePartial()
        {
            return PartialView("BirimlerEklePartial");
        }

        public ActionResult PasifEt(int Id)
        {

            var b = db.Birimler.Find(Id);

            b.Durum = false;

            db.Entry(b).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult BirimlerBilgiGetir(int id)
        {
            var iddegeri = db.Birimler.Find(id);
            
            return View("BirimlerBilgiGetir", iddegeri);
        }

        public ActionResult BirimlerGuncelle(Birimler c)
        {
            var deger = db.Birimler.Find(c.BirimID);
            deger.BirimAdi= c.BirimAdi;
            deger.Durum = true;
            db.SaveChanges();
            db.Entry(deger).State = EntityState.Modified;
            return RedirectToAction("Index");
        }
    }
}