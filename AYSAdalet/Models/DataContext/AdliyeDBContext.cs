﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AYSAdalet.Models.Modeller;

namespace AYSAdalet.Models.DataContext
{
    public class AdliyeDBContext : DbContext
    {
        
        public AdliyeDBContext() : base("AYSDB")
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
        public DbSet<PersonelGorevYerleri> PersonelGorevYerleri { get; set; }
        public DbSet<BilgiTalepler> BilgiTalepler { get; set; }

        public DbSet<TeknikPersonel> TeknikPersonels { get; set; }

        public DbSet<IdariTalepler> IdariTaleplers { get; set; }
        public DbSet<NobetSistemi> nobetSistemi { get; set; }

        //public DbSet<BilgiZimmet> BilgiZimmets { get; set; }





        public DbSet<ZimmetEnvanter> ZimmetEnvanters { get; set; }
        public DbSet<EnvanterTipleri> EnvanterTipleris { get; set; }
        public DbSet<Envanterler> Envanterlers { get; set; }

    }
}