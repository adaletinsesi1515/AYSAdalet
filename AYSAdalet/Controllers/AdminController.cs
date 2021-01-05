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

        public ActionResult BilgiTalepGetir(int id)
        {
            var iddegeri = db.BilgiTalepler.Find(id);
            ViewBag.TeknikPersonel1 = new SelectList(db.TeknikPersonels, "TeknikPersonelID", "Teknik Personel");

            //ViewBag.BirimID1 = new SelectList(db.Birimler, "BirimID", "BirimAdi");

            return View("BilgiTalepGetir", iddegeri);
        }

        public ActionResult BilgiTalepGuncelle(BilgiTalepler c)
        {
            var deger = db.BilgiTalepler.Find(c.TalepID);
            deger.TeknikPersonelNotu = c.TeknikPersonelNotu;
            deger.SonuclanmaTarihi = c.SonuclanmaTarihi;
            
            //deger.Durum = true;
            db.SaveChanges();

            db.Entry(deger).State = EntityState.Modified;
            return RedirectToAction("Index");

        }
    }
}