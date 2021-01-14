using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    //[Table("BilgiZimmet")]
    //public class BilgiZimmet
    //{
    //    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int ZimmetID { get; set; }

    //    public int PersonelId { get; set; }
    //    public virtual Personel Personel { get; set; }

    //    public int BilgisayarID { get; set; }
    //    public virtual Bilgi_Bilgisayarlar Bilgi_Bilgisayarlar { get; set; }

    //    public int MonitorID { get; set; }
    //    public virtual Bilgi_Monitorler Bilgi_Monitorler { get; set; }

    //    public int YaziciID { get; set; }
    //    public virtual Bilgi_Yazicilar Bilgi_Yazicilar { get; set; }

    //    public int TarayiciID { get; set; }
    //    public virtual Bilgi_Tarayicilar Bilgi_Tarayicilar { get; set; }

    //    public string DomainAdi { get; set; }
    //    public bool Durum { get; set; }

    //}





    public class ZimmetEnvanter
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZimmetEnvanterId { get; set; }


        public int PersonelId { get; set; }
        public virtual Personel Personel { get; set; }



        public int EnvanterlerId { get; set; }
        public virtual  Envanterler Envanterler { get; set; }

        public DateTime Tarih { get; set; }
    }


    public class EnvanterTipleri
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnvanterTipleriId { get; set; }

        public string EnvanterTip { get; set; }
    }


    public class Envanterler
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnvanterlerId { get; set; }

        public int EnvanterTipleriId { get; set; }
        public virtual  EnvanterTipleri EnvanterTipleri { get; set; }


        public string Marka { get; set; }

        public string Model { get; set; }

        public string SeriNo { get; set; }

        public string Domain { get; set; }

        public bool Durum { get; set; }
    }



}