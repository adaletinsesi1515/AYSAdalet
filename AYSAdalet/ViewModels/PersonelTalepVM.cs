using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using AYSAdalet.Models.Modeller;

namespace AYSAdalet.ViewModels
{
    public class PersonelTalepVM
    {
        public List<Birimler> Birimler { get; set; }
        public List<PersonelGorevYerleri> GorevYerleri { get; set; }
        public Personel Personel { get; set; }
    }
}