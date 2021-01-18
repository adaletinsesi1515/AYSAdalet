using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
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
            var Model = db.Personel.FirstOrDefault(x => x.PersonelSicil == t && x.Durum == true);

            //var Model = db.Personel.Where(x => x.PersonelSicil == t && x.Durum == true).ToList();
            return View(Model);

        }

        [HttpPost]
        public ActionResult MesajKayit(int PersonelId, string txtMsg)
        {

            var UserModel = db.Personel.FirstOrDefault(x => x.PersonelID == PersonelId);
            BilgiTalepler _BlgTlp = new BilgiTalepler
            {
                PersonelId = UserModel.PersonelID,
                TalepMesaji = txtMsg,
                BildirimTarihi = DateTime.Now,
                Durum = true
            };
            db.BilgiTalepler.Add(_BlgTlp);
            db.SaveChanges();
            TempData["mesaj"] = "Mesajınız sisteme iletilmiştir....";
            return Redirect("Index");
        }
    }
}