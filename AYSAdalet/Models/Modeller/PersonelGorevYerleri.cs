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
        public int ID { get; set; }
        [StringLength(50), Required]
        //public string  Birimler { get; set; }

        public string GorevYeri { get; set; }
        public virtual Personel Personel { get; set; }
        
    }
}