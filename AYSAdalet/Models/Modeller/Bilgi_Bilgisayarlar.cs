using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    [Table("Bilgi_Bilgisayarlar")]
    public class Bilgi_Bilgisayarlar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BilgisayarID { get; set; }

        [Required, StringLength(50)]
        public string BilgisayarMarka { get; set; }

        [Required, StringLength(50)]
        public string BilgisayarModel { get; set; }

        [StringLength(50)]
        public string BilgisayarSeriNo { get; set; }
        public bool Durum { get; set; }

        public virtual List<BilgiZimmet> BilgiZimmet { get; set; }

    }
}