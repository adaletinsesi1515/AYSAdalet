using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    [Table("Birimler")]
    public class Birimler
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BirimID { get; set; }
        [Required, StringLength(100)]
        public string BirimAdi { get; set; }

        public ICollection<Personel> Personel { get; set; }

    }
}