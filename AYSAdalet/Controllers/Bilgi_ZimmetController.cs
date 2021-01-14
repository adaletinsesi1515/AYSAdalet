using AYSAdalet.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.Modeller;

namespace AYSAdalet.Controllers
{
    public class Bilgi_ZimmetController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();



        public ActionResult Index()
        {
            var ZimmetlerModel = db.ZimmetEnvanters.ToList();
            return View(ZimmetlerModel);
        }


        public ActionResult ZimmetEkle()
        {
            ViewBag.PersonelId=new SelectList(db.Personel, "PersonelID", "PersonelAdSoyad");


            var EnvModel = db.Envanterlers.ToList();
            return View(EnvModel);
        }


        public ActionResult PersonelZimmetGetir(int Id)
        {
            var Model = db.ZimmetEnvanters.Where(x => x.PersonelId == Id).ToList();
            return PartialView(Model);
        }

        public JsonResult ZimmetEkleJson(int Id,int PerId)
        {
            ZimmetEnvanter YeniZimmet = new ZimmetEnvanter();
            YeniZimmet.PersonelId = PerId;
            YeniZimmet.EnvanterlerId = Id;
            YeniZimmet.Tarih = DateTime.Now;
            db.ZimmetEnvanters.Add(YeniZimmet);
            db.SaveChanges();


            return Json(JsonRequestBehavior.AllowGet);
        }

    }
}