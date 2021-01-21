using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AYSAdalet.Models.DataContext;
using AYSAdalet.ViewModels;

namespace AYSAdalet.Controllers
{
    public class NobetController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult NobeTanim()
        {
            NobetBilgiListVm vm = new NobetBilgiListVm
            {
                Personels = db.Personel.ToList(),
            };
            return View(vm);
        }
    }
}