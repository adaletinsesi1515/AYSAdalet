using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.DataContext;
using AYSAdalet.ViewModels;

namespace AYSAdalet.Controllers
{
    public class AdliyeRehberController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();
        
        public ActionResult Index()
        {
            AdliyeRehberListVM  model = new AdliyeRehberListVM
            {
                PersonelGorevYerleris = db.PersonelGorevYerleri.ToList(),
                Personels = db.Personel.ToList(),
                birimlers = db.Birimler.ToList()
            };
            return View(model);
        }

        public ActionResult AdminIndex()
        {
            AdliyeRehberListVM model = new AdliyeRehberListVM
            {
                PersonelGorevYerleris = db.PersonelGorevYerleri.ToList(),
                Personels = db.Personel.ToList(),
                birimlers = db.Birimler.ToList()
            };
            return View(model);
        }

        public ActionResult RehberIndex()
        {
            ViewBag.bassavci = db.Personel.Where(x => x.Unvanlar.Unvani == "Cumhuriyet Başsavcısı").Select(y => y.Unvanlar.Unvani).Count();
            ViewBag.hakim = db.Personel.Where(x => x.Unvanlar.Unvani == "HÂKİM").Select(y => y.Unvanlar.Unvani).Count();
            ViewBag.savci = db.Personel.Where(x => x.Unvanlar.Unvani == "CUMHURİYET SAVCISI").Select(y => y.Unvanlar.Unvani).Count();
            return View(db.Personel.ToList());
        }
    }
}