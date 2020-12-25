using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using AYSAdalet.Models.Modeller;

namespace AYSAdalet.ViewModels
{
    public class PerBirimEkleVM
    {
        public List<Personel> Personeller { get; set; }
        public Personel Personel { get; set; }
        public PersonelGorevYerleri PersonelGorevYerleri { get; set; }
        public Birimler Birimler { get; set; }
    }
}