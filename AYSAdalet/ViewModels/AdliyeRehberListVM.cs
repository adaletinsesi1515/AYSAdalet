using AYSAdalet.Models.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AYSAdalet.ViewModels
{
    public class AdliyeRehberListVM
    {
        public List<Personel> Personels { get; set; }
        public Personel Personel { get; set; }

        public List<PersonelGorevYerleri> PersonelGorevYerleris { get; set; }

        public PersonelGorevYerleri PersonelGorevYerleri { get; set; }

        public List<Birimler> birimlers { get; set; }

        public Birimler Birimler { get; set; }

    }
}