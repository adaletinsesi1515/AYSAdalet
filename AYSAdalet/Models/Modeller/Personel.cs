using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    [Table("Personel")]
    public class Personel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonelID { get; set; }

        [Required, StringLength(10)]
        public string PersonelSicil { get; set; }

        [Required, StringLength(50)]
        public string PersonelAdSoyad { get; set; }

        [Required, StringLength(15)]
        public string CepTelefonu { get; set; }

        public string DahiliNo1 { get; set; }
        public string DahiliNo2 { get; set; }
        public bool Durum { get; set; }

        public int UnvanID { get; set; }
        public virtual Unvanlar Unvanlar { get; set; }

        public int BirimID { get; set; }
        public virtual Birimler Birimler { get; set; }

        public virtual List<Talep> Talepler { get; set; }
        

    }
}