using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
     [Table("Talep")]
    public class Talep
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(50), Required]
        public string TalepBasligi { get; set; }
        [StringLength(5000), Required]
        public string Talep1 { get; set; }
        [Required, StringLength(30)]
        public string TalepTarihi { get; set; }
        public bool TalepDurumu { get; set; }

        public virtual Personel Personel { get; set; }

        
    }
}