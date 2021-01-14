using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.DataContext;
using AYSAdalet.Models.Modeller;
using AYSAdalet.ViewModels;
using Microsoft.SqlServer.Server;

namespace AYSAdalet.Controllers
{
    public class AdminController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();

        int toplampersonel = 200;
       // int toplamariza = 200;

        public static BilgiTalepTeknikPersonelVM bt;
        public ActionResult Index()
        {
            var Model = db.BilgiTalepler.Where(X => X.Durum == false).ToList();
            var birimlist = db.PersonelGorevYerleri.ToList();
            ViewBag.birimlist1 = birimlist;

            var unvanlist = db.Unvanlar.ToList();
            ViewBag.urvanlist1 = unvanlist;

            var personellist = db.Personel.ToList();
            ViewBag.personellist1 = personellist;

            ViewBag.tumariza = db.BilgiTalepler.Count();
            ViewBag.bekleyenariza = db.BilgiTalepler.Where(x => x.Durum == true).Count();

            ViewBag.idaritumariza = db.IdariTaleplers.Count();
            ViewBag.idaribekleyenariza = db.IdariTaleplers .Where(x => x.Durum == true).Count();


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
            var Model = db.BilgiTalepler.Where(X => X.Durum == true).ToList();
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
            bt = new BilgiTalepTeknikPersonelVM
            {
                BilgiTalepler = db.BilgiTalepler.Find(id),
                TeknikPersonels = db.TeknikPersonels.ToList()
            };

            return View("BilgiTalepGetir", bt);
        }
               

        [HttpPost]
        public ActionResult BilgiTalepGuncelle(BilgiTalepTeknikPersonelVM m,int TeknikPersonels)
        {
            var kayit = db.BilgiTalepler.Where(k => k.TalepID== m.BilgiTalepler.TalepID).SingleOrDefault();
            kayit.TeknikPersonelID=TeknikPersonels;
            kayit.TeknikPersonelNotu = m.BilgiTalepler.TeknikPersonelNotu;
            if (kayit.TeknikPersonelNotu!=null)
            {
                kayit.Durum = false;
            }            
            kayit.SonuclanmaTarihi= m.BilgiTalepler.SonuclanmaTarihi;
            db.SaveChanges();
            ViewBag.sonuc = "Kayıt Güncelle";
            return RedirectToAction("Index");

        }





        public ActionResult IdariTalepFormListe()
        {
            var Model = db.IdariTaleplers.Where(X => X.Durum == true).ToList();
            var birimlist = db.PersonelGorevYerleri.ToList();
            ViewBag.birimlist1 = birimlist;

            var unvanlist = db.Unvanlar.ToList();
            ViewBag.urvanlist1 = unvanlist;

            var personellist = db.Personel.ToList();
            ViewBag.personellist1 = personellist;
            return View(Model);
        }

        public ActionResult IdariTalepGetir(int id)
        {
            bt = new BilgiTalepTeknikPersonelVM
            {
                IdariTalepler = db.IdariTaleplers.Find(id),
                TeknikPersonels = db.TeknikPersonels.ToList()
            };

            return View("IdariTalepGetir", bt);
        }


        [HttpPost]
        public ActionResult IdariTalepGuncelle(BilgiTalepTeknikPersonelVM m, int TeknikPersonels)
        {
            var kayit = db.IdariTaleplers.Where(k => k.TalepID == m.IdariTalepler.TalepID).SingleOrDefault();
            kayit.TeknikPersonelID = TeknikPersonels;
            kayit.TeknikPersonelNotu = m.IdariTalepler.TeknikPersonelNotu;
            if (kayit.TeknikPersonelNotu != null)
            {
                kayit.Durum = false;
            }
            kayit.SonuclanmaTarihi = m.IdariTalepler.SonuclanmaTarihi;
            db.SaveChanges();
            ViewBag.sonuc = "Kayıt Güncelle";
            return RedirectToAction("Index");

        }

    }
}