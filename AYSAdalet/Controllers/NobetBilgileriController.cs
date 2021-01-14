using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.ViewModels;
using AYSAdalet.Models.DataContext;

namespace AYSAdalet.Controllers
{
    public class NobetBilgileriController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();

        // GET: NobetBilgileri
        public ActionResult Index()
        {
                      
            var liste = db.nobetSistemi.ToList();
            return View(liste);
        }

        public ActionResult AdminIndex()
        {

            
            var liste = db.nobetSistemi.ToList();
            return View(liste);
        }

    }
}