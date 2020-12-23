using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.DataContext;
using AYSAdalet.Models.Modeller;

namespace AYSAdalet.Controllers
{
    public class BirimController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();
        // GET: Birim
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Birimler birim)
        {

            var KayitVarMi = db.Birimler.FirstOrDefault(x => x.BirimAdi== birim.BirimAdi);

            if (KayitVarMi == null)
            {
                db.Birimler.Add(birim);
                db.SaveChanges();
            }
            else
            {
                TempData["Uyari"] = "Bu birim veritabanında kayıtlıdır";
                return RedirectToAction("Ekle");
            }
            return RedirectToAction("Liste");
        }

        public ActionResult Liste()
        {
            var model = db.Birimler.ToList();
            return View(model);
        }
    }
}