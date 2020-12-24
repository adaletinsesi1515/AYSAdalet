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
    public class LoginController : Controller
    {
        AdliyeDBContext db = new AdliyeDBContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login p)
        {
            var bilgiler =
                db.Login.FirstOrDefault(x => x.KullaniciAdi== p.KullaniciAdi&& x.Parola== p.Parola);

            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi, false);
                Session["KULLANICIADI"] = bilgiler.KullaniciAdi.ToString();

                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

    }
}