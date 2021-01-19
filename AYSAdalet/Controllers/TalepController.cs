using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.DataContext;
using AYSAdalet.Models.Modeller;
using AYSAdalet.ViewModels;

namespace AYSAdalet.Controllers
{
    public class TalepController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();
        PersonelTalepVM pt = new PersonelTalepVM();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string sicil)
        {
            var sicilbul = db.Personel.Where(x => x.PersonelSicil == sicil).FirstOrDefault();

            if (sicilbul != null)
            {
                var gorevyeribul = db.PersonelGorevYerleri.Where(x => x.PersonelID == sicilbul.PersonelID).ToList();
                pt.Personel = sicilbul;
                pt.GorevYerleri = gorevyeribul;
                pt.Birimler = db.Birimler.ToList();
                return View(pt);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult KaydaYolla()
        {

            return View();
        }

        [HttpPost]
        public ActionResult KaydaYolla(int PersonelId, string mesaj, string Birimler)
        {

            var model = db.Personel.Where(x => x.PersonelID == PersonelId).FirstOrDefault();
            if (model.PersonelID>0)
            {
                IdariTalepler tlp = new IdariTalepler
                {
                    BildirimTarihi = DateTime.Now,
                    PersonelId = model.PersonelID,
                    Durum = true,
                    TalepMesaji = mesaj,
                    PersonelGorevYeri = Birimler
                };

                db.IdariTaleplers.Add(tlp);
                int sonuc = db.SaveChanges();

                if (sonuc==1)
                {
                    ViewBag.success = "Talebiniz Başarılı Bir Şekilde Oluşturuldu";
                } else if (sonuc==2)
                {
                    ViewBag.hata = "Talebiniz İletilemedi";
                }
            }

            return RedirectToAction("Index");
        }

    }
}