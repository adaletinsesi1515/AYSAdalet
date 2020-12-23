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
    public class PersonelController : Controller
    {
        // GET: Personel
        AdliyeDBContext db = new AdliyeDBContext();
        public ActionResult Index()
        {
            
            var bassavci= db.Personel.Where(x => x.Unvanlar.Unvani== "Cumhuriyet Başsavcısı" && x.Durum == true).Count();
            ViewBag.bassavci1 = bassavci;

            var savcilar= db.Personel.Where(x => x.Unvanlar.Unvani== "Cumhuriyet Savcısı" && x.Durum == true).Count();
            ViewBag.savci1= savcilar;

            var baskanlar= db.Personel.Where(x => x.Unvanlar.Unvani == "Ağır Ceza Mahkemesi Başkanı" && x.Durum == true).Count();
            ViewBag.baskan1= baskanlar;

            var hakimler = db.Personel.Where(x => x.Unvanlar.Unvani == "Hakim" && x.Durum == true).Count();
            ViewBag.hakim1= hakimler;


            var Model = db.Personel.Where(X => X.Durum == true).ToList();
            return View(Model);

        }


        [HttpGet]
        public ActionResult PersonelEkle()
        {

            var Model = db.Personel.Where(X=>X.Durum == true).ToList();
            return View(Model);
        }


        [HttpPost]
        public ActionResult PersonelEkle(Personel b)
        {
            //Aynı sicilden kayıtlı başka personel olup olmadığını kontrol ediyor
            var PersonelVarMi= db.Personel.FirstOrDefault(x => x.PersonelSicil== b.PersonelSicil);

            if (PersonelVarMi== null)
            {
                b.Durum = true;
                db.Personel.Add(b);
                db.SaveChanges();
            }
            else
            {
                TempData["Uyari"] = "Bu Personel sistemde kayıtlıdır";
                return RedirectToAction("PersonelEkle");
            }
            return RedirectToAction("Index");


        }

        public ActionResult PersonelEklePartial()
        {
            ViewBag.UnvanID=new SelectList(db.Unvanlar, "UnvanID", "Unvani");
            ViewBag.BirimID = new SelectList(db.Birimler, "BirimID", "BirimAdi");
            return PartialView("PersonelEklePartial");
        }

        public ActionResult PasifEt(int Id) {

            var b = db.Personel.Find(Id);

            b.Durum= false;

            db.Entry(b).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("PersonelEkle");
        }


    }
}