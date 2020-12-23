using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AYSAdalet.Models.Modeller;

namespace AYSAdalet.ViewModels
{
    public class PersonelViewModel
    {
        public Personel Personel { get; set; }
        public IEnumerable<Unvanlar> Unvanlar { get; set; }
        public IEnumerable<Birimler> Birimler { get; set; }
        //public Talep Talep { get; set; }
    }
}