using System.Collections.Generic;
using AYSAdalet.Models.DataContext;
using AYSAdalet.Models.Modeller;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;


namespace AYSAdalet.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        AdliyeDBContext db = new AdliyeDBContext();
        public ActionResult Index()
        {

            var bassavci = db.Personel.Where(x => x.Unvanlar.Unvani == "Cumhuriyet Başsavcısı" && x.Durum == true).Count();
            ViewBag.bassavci1 = bassavci;

            var savcilar = db.Personel.Where(x => x.Unvanlar.Unvani == "Cumhuriyet Savcısı" && x.Durum == true).Count();
            ViewBag.savci1 = savcilar;

            var baskanlar = db.Personel.Where(x => x.Unvanlar.Unvani == "Ağır Ceza Mahkemesi Başkanı" && x.Durum == true).Count();
            ViewBag.baskan1 = baskanlar;

            var hakimler = db.Personel.Where(x => x.Unvanlar.UnvanID == 4 && x.Durum == true).Count();
            ViewBag.hakim1 = hakimler;


            var Model = db.Personel.Where(X => X.Durum == true).ToList();
            var birimlist = db.PersonelGorevYerleri.ToList();
            ViewBag.birimlist1 = birimlist;

            ViewBag.BirimID1 = new SelectList(db.Birimler, "BirimID", "BirimAdi");
            return View(Model);
            

        }

        public ActionResult BirimListeGetir(int PersonelId)
        {
            var BirimModel = db.PersonelGorevYerleri.Where(x => x.PersonelID == PersonelId).ToList();
            return PartialView("BirimListeGetir",BirimModel);
        }

        [HttpGet]
        public ActionResult PersonelEkle()
        {
            var Model = db.Personel.Where(X => X.Durum == true).ToList();
            ViewBag.BirimID1 = new SelectList(db.Birimler, "BirimID", "BirimAdi");


            return View(Model);
        }


        [HttpPost]
        public ActionResult PersonelEkle(Personel b, List<int> BirimID)
        {

            //Aynı sicilden kayıtlı başka personel olup olmadığını kontrol ediyor
            var PersonelVarMi = db.Personel.FirstOrDefault(x => x.PersonelSicil == b.PersonelSicil);

            if (PersonelVarMi == null)
            {
                b.Durum = true;


                //b.GorevYeriID = c.GorevYeriID;
              
                db.Personel.Add(b);
              
                db.SaveChanges();

                foreach (var GelenBirimler in BirimID)
                {
                    //Mükerrer kayıt olmaması açısından kayıt varmı önce kontrol edilecek. yok ise birim kaydını kaydedecek.

                    PersonelGorevYerleri BirimKaydi = new PersonelGorevYerleri
                    {
                        PersonelID = b.PersonelID,
                        BirimID = GelenBirimler
                    };

                    db.PersonelGorevYerleri.Add(BirimKaydi);
                    db.SaveChanges();
                }

            }
            else
            {
                TempData["Uyari"] = "Bu Personel sistemde kayıtlıdır";
                return RedirectToAction("PersonelEkle");
            }
            return RedirectToAction("Index");


        }
        
        public ActionResult PersonelEklePartial()
        {
            ////bir list oluştuyoruz selectlistitem tipi alacak
            //List<SelectListItem> birimlerList = new List<SelectListItem>();
            ////foreach ile db.Categories deki kategorileri listemize ekliyoruz
            //foreach (var item in db.Birimler.ToList())
            //{   //Text = Görünen kısımdır. Kategori ismini yazdıyoruz
            //    //Value = Değer kısmıdır.ID değerini atıyoruz
            //    birimlerList.Add(new SelectListItem { Text = item.BirimAdi, Value = item.BirimID.ToString() });
            //}
            ////Dinamik bir yapı oluşturup kategoriler list mizi view mize göndereceğiz
            ////bunun için viewbag kullanıyorum
            //ViewBag.birimler= birimlerList;


            //return View();

            ViewBag.UnvanID=new SelectList(db.Unvanlar, "UnvanID", "Unvani");

            ViewBag.BirimID = new SelectList(db.Birimler, "BirimID", "BirimAdi");

            return PartialView("PersonelEklePartial");
        }

        public ActionResult PasifEt(int Id)
        {

            var b = db.Personel.Find(Id);

            b.Durum = false;

            db.Entry(b).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult PersonelBilgiGetir(int id)
        {
            var iddegeri = db.Personel.Find(id);
            ViewBag.UnvanID = new SelectList(db.Unvanlar, "UnvanID", "Unvani");
            ViewBag.GorevYeriID = new SelectList(db.PersonelGorevYerleri, "GorevYeriID", "GorevYeriID");
            ViewBag.BirimID = new SelectList(db.Birimler, "BirimID", "BirimAdi");
            return View("PersonelBilgiGetir", iddegeri);
        }

        public ActionResult PersonelGuncelle(Personel c)
        {
            var deger = db.Personel.Find(c.PersonelID);
            deger.UnvanID = c.UnvanID;
            //deger.GorevYeriID= c.GorevYeriID;
            //ViewBag.UnvanID1 = new SelectList(db.Unvanlar, "UnvanID", "Unvani");
            //ViewBag.BirimID1 = new SelectList(db.Birimler, "BirimID", "BirimAdi");
            deger.PersonelSicil = c.PersonelSicil;
            deger.PersonelAdSoyad = c.PersonelAdSoyad;
            

            //deger.Birimler.BirimAdi = c.Birimler.BirimAdi;
            //deger.Unvanlar.Unvani = c.Unvanlar.Unvani;
            deger.CepTelefonu = c.CepTelefonu;
            deger.DahiliNo1 = c.DahiliNo1;
            deger.DahiliNo2 = c.DahiliNo2;
            deger.Durum = true;
            db.SaveChanges();

            db.Entry(deger).State = EntityState.Modified;
            return RedirectToAction("Index");

        }

    }
}