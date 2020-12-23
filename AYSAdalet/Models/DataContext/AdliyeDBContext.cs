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


    }
}