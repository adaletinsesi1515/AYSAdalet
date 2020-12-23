using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    [Table("Bilgi_Yazicilar")]
    public class Bilgi_Yazicilar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YaziciID { get; set; }

        [Required, StringLength(50)]
        public string YaziciMarka { get; set; }

        [Required, StringLength(50)]
        public string YaziciModel { get; set; }

        [StringLength(50)]
        public string YaziciSeriNo { get; set; }
        public bool Durum { get; set; }

    }
}