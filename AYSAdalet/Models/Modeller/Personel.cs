﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    [Table("Personel")]
    public class Personel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonelID { get; set; }
        public string PersonelSicil { get; set; }

        public string PersonelAdSoyad { get; set; }

        public string CepTelefonu { get; set; }

        public string DahiliNo1 { get; set; }
        public string DahiliNo2 { get; set; }
        public bool Durum { get; set; }

        public int UnvanID { get; set; }
        public virtual Unvanlar Unvanlar { get; set; }

       public virtual List<PersonelGorevYerleri> PersonelGorevYerleris { get; set; }

        public virtual List<NobetSistemi> NobetSistemis { get; set; }
        //public virtual List<BilgiZimmet> BilgiZimmet { get; set; }
    }
}