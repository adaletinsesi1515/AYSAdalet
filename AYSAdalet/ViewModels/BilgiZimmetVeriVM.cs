using AYSAdalet.Models.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AYSAdalet.ViewModels
{
    public class BilgiZimmetVeriVM
    {
        public List<Bilgi_Bilgisayarlar> Bilgi_Bilgisayarlars { get; set; }
        public List<Bilgi_Monitorler> Bilgi_Monitorlers { get; set; }

        public List<Bilgi_Yazicilar> Bilgi_Yazicilars { get; set; }

        public List<Bilgi_Tarayicilar> Bilgi_Tarayicilars { get; set; }

        public List<Personel> personels { get; set; }
        public List<BilgiZimmet> BilgiZimmets { get; set; }
    }
}