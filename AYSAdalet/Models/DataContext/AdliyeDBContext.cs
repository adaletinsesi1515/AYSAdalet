using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AYSAdalet.Models.Modeller;

namespace AYSAdalet.Models.DataContext
{
    public class AdliyeDBContext : DbContext
    {
        public AdliyeDBContext():base("AYSDB")
        {
            
        }

        public DbSet<Login> Login { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Birimler> Birimler { get; set; }
        public DbSet<Unvanlar> Unvanlar { get; set; }
        public DbSet<Bilgi_Bilgisayarlar> BilgiBilgisayarlar { get; set; }
        public DbSet<Bilgi_Monitorler> BilgiMonitorler { get; set; }
        public DbSet<Bilgi_Yazicilar> BilgiYazicilar { get; set; }
        public DbSet<Bilgi_Tarayicilar> BilgiTarayicilar { get; set; }
        public DbSet<Talep> GelenTalep { get; set; }
        public DbSet<PersonelGorevYerleri> PersonelGorevYerleri { get; set; }
        public DbSet<BilgiTalepler> BilgiTalepler { get; set; }

        public DbSet<TeknikPersonel> TeknikPersonels { get; set; }

    }
}