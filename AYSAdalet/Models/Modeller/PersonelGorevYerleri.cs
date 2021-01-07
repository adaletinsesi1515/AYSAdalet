using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    [Table("PersonelGorevYerleri")]
    public class PersonelGorevYerleri
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GorevYeriID { get; set; }

        public int PersonelID { get; set; }
        public virtual Personel Personel { get; set; }

        public int BirimID { get; set; }
        public virtual  Birimler Birimler { get; set; }
        public bool Durum { get; set; }
        public virtual List<BilgiZimmet> BilgiZimmet { get; set; }
    }
}