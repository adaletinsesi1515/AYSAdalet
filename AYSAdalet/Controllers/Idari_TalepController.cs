using AYSAdalet.Models.DataContext;
using AYSAdalet.Models.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AYSAdalet.Controllers
{
    public class Idari_TalepController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();

        public ActionResult Index(string t)
        {
            var Model = db.Personel.FirstOrDefault(x => x.PersonelSicil == t && x.Durum == true);
            return View(Model);
        }

        [HttpPost]
        public ActionResult İdariMesajKayit(int PersonelId, string txtMsg)
        {

            var UserModel = db.Personel.FirstOrDefault(x => x.PersonelID == PersonelId);
            IdariTalepler _IdariTlp = new IdariTalepler
            {
                PersonelId = UserModel.PersonelID,
                TalepMesaji = txtMsg,
                BildirimTarihi = DateTime.Now,
                Durum = true
            };
            db.IdariTaleplers.Add(_IdariTlp);
            db.SaveChanges();
            TempData["mesaj"] = "Mesajınız sisteme iletilmiştir....";
            return Redirect("Index");
        }



    }
}
