using AYSAdalet.Models.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AYSAdalet.ViewModels
{
    public class NobetBilgiListVm
    {
        public List<Personel> Personels { get; set; }
        public Personel Personel { get; set; }

        public List<Unvanlar> unvanlars { get; set; }

        public Unvanlar Unvanlar { get; set; }

        public NobetSistemi NobetSistemi { get; set; }
        public List<NobetSistemi> nobetSistemis { get; set; }

        public List<Birimler> birimlers { get; set; }

        public Birimler Birimler { get; set; }



    }
}