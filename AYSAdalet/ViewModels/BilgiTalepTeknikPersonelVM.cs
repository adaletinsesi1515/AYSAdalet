using AYSAdalet.Models.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AYSAdalet.ViewModels
{
    public class BilgiTalepTeknikPersonelVM
    {
        public List<TeknikPersonel> TeknikPersonels { get; set; }
        public BilgiTalepler BilgiTalepler { get; set; }

        public IdariTalepler IdariTalepler { get; set; }

    }
}