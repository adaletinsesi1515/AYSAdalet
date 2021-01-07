using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    [Table("BilgiZimmet")]
    public class BilgiZimmet
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZimmetID { get; set; }

        public int PersonelId { get; set; }
        public virtual Personel Personel { get; set; }

        public int PersonelGorevYerleriID { get; set; }
        public virtual PersonelGorevYerleri PersonelGorevYerleri { get; set; }

        public int BilgisayarID { get; set; }
        public virtual Bilgi_Bilgisayarlar Bilgi_Bilgisayarlar { get; set; }

        public int MonitorID { get; set; }
        public virtual Bilgi_Monitorler Bilgi_Monitorler { get; set; }

        public int YaziciID { get; set; }
        public virtual Bilgi_Yazicilar Bilgi_Yazicilar { get; set; }

        public int TarayiciID { get; set; }
        public virtual Bilgi_Tarayicilar Bilgi_Tarayicilar { get; set; }

        public string DomainAdi { get; set; }
        public bool Durum { get; set; }

    }
}