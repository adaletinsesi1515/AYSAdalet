using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.DataContext;
using AYSAdalet.Models.Modeller;

namespace AYSAdalet.Controllers
{
    public class UnvanController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();


        public ActionResult Liste()
        {
            ViewBag.kayitToplam = db.Unvanlar.Count();

            return View(db.Unvanlar.ToList());
        }


        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Unvanlar unvan)
        {

            //var result = db.TBL_UNVANLAR.Sum(x => x.UNVANID);
            var toplamKayit = db.Unvanlar.Count();

            var KayitVarMi = db.Unvanlar.FirstOrDefault(x => x.Unvani== unvan.Unvani);

            if (KayitVarMi == null)
            {
                db.Unvanlar.Add(unvan);
                db.SaveChanges();
            }
            else
            {
                TempData["Uyari"] = "Bu ünvan veritabanında kayıtlıdır";
                //ViewBag.Uyari = "Bu seri no kayıtlıdır";
                return RedirectToAction("Ekle");
            }
            //ViewBag.idToplam = result;
            ViewBag.kayitToplam = toplamKayit;
            return RedirectToAction("Liste");

        }
    }
}