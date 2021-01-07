using AYSAdalet.Models.DataContext;
using AYSAdalet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AYSAdalet.Controllers
{
    public class Bilgi_ZimmetController : Controller
    {
        // GET: Bilgi_Zimmet
        AdliyeDBContext db = new AdliyeDBContext();

        public ActionResult Index()
        {
            var Model= db.BilgiZimmets.Where(x => x.Durum == true).ToList();
            return View(Model);
        }


        public ActionResult ZimmetEklePartial()
        {
            return PartialView("ZimmetEklePartial");
        }

        [HttpPost]
        public ActionResult ZimmetYap()
        {
            return View();
        }



        //public ActionResult Index(string t)
        //{
        //    //var Model = db.Personel.FirstOrDefault(x => x.PersonelSicil.Sta || t != null && x.Durum == true).ToList();
        //    var Model = db.Personel.FirstOrDefault(x => x.PersonelSicil == t && x.Durum == true);
        //    ////List<Personel> listemp = db.Personel.Where(x => x.Durum== true).ToList();

        //    return View(Model);
        //    //return View();

        //}

        //[HttpPost]
        //public ActionResult MesajKayit(int PersonelId, string txtMsg)
        //{

        //    var UserModel = db.Personel.FirstOrDefault(x => x.PersonelID == PersonelId);
        //    BilgiTalepler _BlgTlp = new BilgiTalepler
        //    {
        //        PersonelId = UserModel.PersonelID,
        //        TalepMesaji = txtMsg,
        //        BildirimTarihi = DateTime.Now,
        //        Durum = true
        //    };
        //    db.BilgiTalepler.Add(_BlgTlp);
        //    db.SaveChanges();
        //    TempData["mesaj"] = "Mesajınız sisteme iletilmiştir....";
        //    return Redirect("Index");
        //}



    }
}