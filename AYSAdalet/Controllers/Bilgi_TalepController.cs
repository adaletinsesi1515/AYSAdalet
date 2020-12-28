using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.DataContext;
using AYSAdalet.Models.Modeller;

namespace AYSAdalet.Controllers
{
    public class Bilgi_TalepController : Controller
    {
        // GET: Bilgi_Talep

        AdliyeDBContext db = new AdliyeDBContext();

        public ActionResult Index(string t)
        {
            //var Model = db.Personel.FirstOrDefault(x => x.PersonelSicil.Sta || t != null && x.Durum == true).ToList();
            var Model = db.Personel.FirstOrDefault(x => x.PersonelSicil == t  && x.Durum == true);
            ////List<Personel> listemp = db.Personel.Where(x => x.Durum== true).ToList();
            
            return View(Model);
            //return View();

        }
        
        [HttpPost]
        public ActionResult MesajKayit(int PersonelId,string txtMsg)
        {
            var UserModel = db.Personel.FirstOrDefault(x => x.PersonelID == PersonelId);
            BilgiTalepler _BlgTlp = new BilgiTalepler
            {
                PersonelSicili = UserModel.PersonelSicil,
                TalepMesaji = txtMsg,
                BildirimTarihi = DateTime.Now,
                Durum = false
            };
            db.BilgiTalepler.Add(_BlgTlp);
            db.SaveChanges();
            return Redirect("Index");
        }
    }
}