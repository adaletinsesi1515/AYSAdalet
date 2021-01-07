using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{

    [Table("Bilgi_Tarayicilar")]
    public class Bilgi_Tarayicilar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TarayiciID { get; set; }

        [Required, StringLength(50)]

        public string TarayiciMarka { get; set; }

        [Required, StringLength(50)]

        public string TarayiciModel { get; set; }

        [StringLength(50)]

        public string TarayiciSeriNo { get; set; }
        public bool Durum { get; set; }

        //public virtual List<BilgiZimmet> BilgiZimmet { get; set; }
    }

}