using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    [Table("TeknikPersonel")]

    public class TeknikPersonel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeknikPersonelID { get; set; }

        [Required, StringLength(10)]
        public string PersonelSicil { get; set; }

        [Required, StringLength(50)]
        public string PersonelAdSoyad { get; set; }
        public bool Durum { get; set; }

        //public virtual BilgiTalepler BilgiTalepler { get; set; }



    }
}
