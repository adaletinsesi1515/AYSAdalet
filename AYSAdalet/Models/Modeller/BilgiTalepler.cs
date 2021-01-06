using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    [Table("BilgiTalepler")]
    public class BilgiTalepler
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TalepID { get; set; }

        public int PersonelId { get; set; }
        public virtual Personel Personel { get; set; }

        public DateTime BildirimTarihi { get; set; }


        [Required, StringLength(2500)]
        public string TalepMesaji { get; set; }
        

        [StringLength(2500)]
        public string TeknikPersonelNotu{ get; set; }
        public Nullable<DateTime> SonuclanmaTarihi { get; set; }
        public bool  Durum { get; set; }      

        [Required]
        public virtual List<TeknikPersonel> TeknikPersonel { get; set; }



        

        
    }
}