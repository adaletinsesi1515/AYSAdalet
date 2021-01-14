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
    }
}