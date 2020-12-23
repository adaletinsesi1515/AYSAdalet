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
    public class Bilgi_DonanimController : Controller
    {
        // GET: BilgiDonanim

        AdliyeDBContext db = new AdliyeDBContext();
        public ActionResult Index()
        {
            //Bilgisayar Kasası Türü
            var kasaturu = db.BilgiBilgisayarlar.Where(x => x.Durum== true).Count();
            ViewBag.kasaturu1 = kasaturu;

            //Bilgisayar Monitör Türü
            var monitorturu = db.BilgiMonitorler.Where(x => x.Durum== true).Count();
            ViewBag.monitorturu1 = monitorturu;

            //Yazıcı Türü
            var yazicituru = db.BilgiYazicilar.Where(x => x.Durum== true).Count();
            ViewBag.yazicituru1 = yazicituru;

            //Tarayıcı Türü
            var tarayicituru = db.BilgiTarayicilar.Where(x => x.Durum== true).Count();
            ViewBag.tarayicituru1 = tarayicituru;


            //Bilgisayar Kasa Marka ve Modele göre sayı bulma
            var hpg1 = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "HP" && x.BilgisayarModel== "G1" && x.Durum== true).Count();
            ViewBag.hpg1sayisi = hpg1;

            var hpg2 = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "HP" && x.BilgisayarModel== "G2" && x.Durum== true).Count();
            ViewBag.hpg2sayisi = hpg2;

            var fup5731 = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "FUJİTSU" && x.BilgisayarModel== "P5731" && x.Durum== true).Count();
            ViewBag.fup5731sayisi = fup5731;

            var fup700 = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "FUJİTSU" && x.BilgisayarModel== "P700" && x.Durum== true).Count();
            ViewBag.fup700sayisi = fup700;

            var fup710 = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "FUJİTSU" && x.BilgisayarModel== "P710" && x.Durum== true).Count();
            ViewBag.fup710sayisi = fup710;

            var fup920 = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "FUJİTSU" && x.BilgisayarModel== "P920" && x.Durum== true).Count();
            ViewBag.fup920sayisi = fup920;

            var hp8300 = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "HP" && x.BilgisayarModel== "ELITE 8300" && x.Durum== true).Count();
            ViewBag.hp8300sayisi = hp8300;

            var lenm93p = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "LENOVO" && x.BilgisayarModel== "M93P" && x.Durum== true).Count();
            ViewBag.lenm93psayisi = lenm93p;

            var lenm715q = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "LENOVO" && x.BilgisayarModel== "M715Q" && x.Durum== true).Count();
            ViewBag.lenm715qsayisi = lenm715q;

            var lenm920x = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "LENOVO" && x.BilgisayarModel== "M920X" && x.Durum== true).Count();
            ViewBag.lenm920xsayisi = lenm920x;

            var adlisicil = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "ADLİ SİCİL" && x.BilgisayarModel== "ADLİ SİCİL" && x.Durum== true).Count();
            ViewBag.adlisicilsayisi = adlisicil;

            var adlitip = db.BilgiBilgisayarlar.Where(x => x.BilgisayarMarka== "ADLİ TIP" && x.BilgisayarModel== "ADLİ TIP" && x.Durum== true).Count();
            ViewBag.adlitipsayisi = adlitip;



            return View();

        }

        // Bilgisayar Kasası Ekleme işlemlerinin yapıldığı alan

        [HttpGet]
        public ActionResult BilgisayarEkle()
        {
            var listeleme = db.BilgiBilgisayarlar.Where(x => x.Durum== true).ToList();

            return View(listeleme);
        }


        public ActionResult BilgisayarEklePartial()
        {
            return PartialView("BilgisayarEklePartial");
        }

        public ActionResult BilgisayarBilgiGetir(int id)
        {
            var iddegeri = db.BilgiBilgisayarlar.Find(id);

            return View("BilgisayarBilgiGetir", iddegeri);
        }

        public ActionResult BilgisayarGuncelle(Bilgi_Bilgisayarlar c)
        {
            var deger = db.BilgiBilgisayarlar.Find(c.BilgisayarID);

            deger.BilgisayarMarka= c.BilgisayarMarka;
            deger.BilgisayarModel= c.BilgisayarModel;
            deger.BilgisayarSeriNo= c.BilgisayarSeriNo;
            deger.Durum= true;

            db.Entry(deger).State = EntityState.Modified;

            db.SaveChanges();
            return RedirectToAction("BilgisayarEkle");
        }

        [HttpPost]
        public ActionResult BilgisayarEkle(Bilgi_Bilgisayarlar b)
        {
            //Aynı seri no dan kayıtlı olup olmadığını kontrol ediyor
            var SeriNoVarmi = db.BilgiBilgisayarlar.FirstOrDefault(x => x.BilgisayarSeriNo== b.BilgisayarSeriNo);

            if (SeriNoVarmi == null)
            {
                //TempData["Uyari"] = "KAyit Başarılı";
                b.Durum= true;
                db.BilgiBilgisayarlar.Add(b);
                db.SaveChanges();
            }
            else
            {
                TempData["Uyari"] = "Bu seri no kayıtlıdır";
                //ViewBag.Uyari = "Bu seri no kayıtlıdır";
                return RedirectToAction("BilgisayarEkle");
            }
            return RedirectToAction("Index");


        }
        public ActionResult PasifEt(int Id)
        {

            //var pasif = db.TBL_BILGISAYARLAR.Find(b.BILGISAYARID);
            //pasif.DURUM = false;
            //db.SaveChanges();
            var b = db.BilgiBilgisayarlar.Find(Id);

            b.Durum= false;

            db.Entry(b).State = EntityState.Modified;
            db.SaveChanges();


            return RedirectToAction("BilgisayarEkle");
        }


        // Monitör Ekleme işlemlerinin yapıldığı alan

        [HttpGet]
        public ActionResult MonitorEkle()
        {
            var listeleme = db.BilgiMonitorler.Where(x => x.Durum== true).ToList();

            return View(listeleme);
        }


        public ActionResult MonitorEklePartial()
        {
            return PartialView("MonitorEklePartial");
        }

        public ActionResult MonitorBilgiGetir(int id)
        {
            var iddegeri = db.BilgiMonitorler.Find(id);

            return View("MonitorBilgiGetir", iddegeri);
        }

        public ActionResult MonitorGuncelle(Bilgi_Monitorler c)
        {
            var deger = db.BilgiMonitorler.Find(c.MonitorID);

            deger.MonitorMarka= c.MonitorMarka;
            deger.MonitorModel= c.MonitorModel;
            deger.MonitorSeriNo= c.MonitorSeriNo;
            deger.Durum= true;

            db.Entry(deger).State = EntityState.Modified;

            db.SaveChanges();
            return RedirectToAction("MonitorEkle");
        }

        [HttpPost]
        public ActionResult MonitorEkle(Bilgi_Monitorler b)
        {
            //Aynı seri no dan kayıtlı olup olmadığını kontrol ediyor
            var SeriNoVarmi = db.BilgiMonitorler.FirstOrDefault(x => x.MonitorSeriNo== b.MonitorSeriNo);

            if (SeriNoVarmi == null)
            {
                //TempData["Uyari"] = "KAyit Başarılı";
                b.Durum= true;
                db.BilgiMonitorler.Add(b);
                db.SaveChanges();
            }
            else
            {
                TempData["Uyari"] = "Bu seri no kayıtlıdır";
                //ViewBag.Uyari = "Bu seri no kayıtlıdır";
                return RedirectToAction("MonitorEkle");
            }
            return RedirectToAction("Index");

        }
        public ActionResult PasifEtMonitor(int Id)
        {

            //var pasif = db.TBL_BILGISAYARLAR.Find(b.BILGISAYARID);
            //pasif.DURUM = false;
            //db.SaveChanges();
            var b = db.BilgiMonitorler.Find(Id);

            b.Durum= false;

            db.Entry(b).State = EntityState.Modified;
            db.SaveChanges();


            return RedirectToAction("MonitorEkle");
        }


        // Yazıcı Ekleme işlemlerinin yapıldığı alan

        [HttpGet]
        public ActionResult YaziciEkle()
        {
            var listeleme = db.BilgiYazicilar.Where(x => x.Durum== true).ToList();

            return View(listeleme);
        }


        public ActionResult YaziciEklePartial()
        {
            return PartialView("YaziciEklePartial");
        }

        public ActionResult YaziciBilgiGetir(int id)
        {
            var iddegeri = db.BilgiYazicilar.Find(id);

            return View("YaziciBilgiGetir", iddegeri);
        }

        public ActionResult YaziciGuncelle(Bilgi_Yazicilar c)
        {
            var deger = db.BilgiYazicilar.Find(c.YaziciID);

            deger.YaziciMarka= c.YaziciMarka;
            deger.YaziciModel= c.YaziciModel;
            deger.YaziciSeriNo = c.YaziciSeriNo;
            deger.Durum= true;

            db.Entry(deger).State = EntityState.Modified;

            db.SaveChanges();
            return RedirectToAction("YaziciEkle");
        }

        [HttpPost]
        public ActionResult YaziciEkle(Bilgi_Yazicilar b)
        {
            //Aynı seri no dan kayıtlı olup olmadığını kontrol ediyor
            var SeriNoVarmi = db.BilgiYazicilar.FirstOrDefault(x => x.YaziciSeriNo== b.YaziciSeriNo);

            if (SeriNoVarmi == null)
            {
                //TempData["Uyari"] = "KAyit Başarılı";
                b.Durum= true;
                db.BilgiYazicilar.Add(b);
                db.SaveChanges();
            }
            else
            {
                TempData["Uyari"] = "Bu seri no kayıtlıdır";
                //ViewBag.Uyari = "Bu seri no kayıtlıdır";
                return RedirectToAction("YaziciEkle");
            }
            return RedirectToAction("Index");

        }
        public ActionResult PasifEtYazici(int Id)
        {


            var b = db.BilgiYazicilar.Find(Id);

            b.Durum= false;

            db.Entry(b).State = EntityState.Modified;
            db.SaveChanges();


            return RedirectToAction("YaziciEkle");
        }







        // Tarayıcı Ekleme işlemlerinin yapıldığı alan

        [HttpGet]
        public ActionResult TarayiciEkle()
        {
            var listeleme = db.BilgiTarayicilar.Where(x => x.Durum== true).ToList();

            return View(listeleme);
        }


        public ActionResult TarayiciEklePartial()
        {
            return PartialView("TarayiciEklePartial");
        }

        public ActionResult TarayiciBilgiGetir(int id)
        {
            var iddegeri = db.BilgiTarayicilar.Find(id);

            return View("TarayiciBilgiGetir", iddegeri);
        }

        public ActionResult TarayiciGuncelle(Bilgi_Tarayicilar c)
        {
            var deger = db.BilgiTarayicilar.Find(c.TarayiciID);

            deger.TarayiciMarka= c.TarayiciMarka;
            deger.TarayiciModel = c.TarayiciModel;
            deger.TarayiciSeriNo= c.TarayiciSeriNo;
            deger.Durum= true;

            db.Entry(deger).State = EntityState.Modified;

            db.SaveChanges();
            return RedirectToAction("TarayiciEkle");
        }

        [HttpPost]
        public ActionResult TarayiciEkle(Bilgi_Tarayicilar b)
        {
            //Aynı seri no dan kayıtlı olup olmadığını kontrol ediyor
            var SeriNoVarmi = db.BilgiTarayicilar.FirstOrDefault(x => x.TarayiciSeriNo== b.TarayiciSeriNo);

            if (SeriNoVarmi == null)
            {
                //TempData["Uyari"] = "KAyit Başarılı";
                b.Durum= true;
                db.BilgiTarayicilar.Add(b);
                db.SaveChanges();
            }
            else
            {
                TempData["Uyari"] = "Bu seri no kayıtlıdır";
                //ViewBag.Uyari = "Bu seri no kayıtlıdır";
                return RedirectToAction("TarayiciEkle");
            }
            return RedirectToAction("Index");

        }
        public ActionResult PasifEtTarayici(int Id)
        {


            var b = db.BilgiTarayicilar.Find(Id);

            b.Durum= false;

            db.Entry(b).State = EntityState.Modified;
            db.SaveChanges();


            return RedirectToAction("TarayiciEkle");
        }


    }
}