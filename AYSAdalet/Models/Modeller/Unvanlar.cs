using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    [Table("Unvanlar")]
    public class Unvanlar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UnvanID { get; set; }
        [Required, StringLength(100)]
        public string Unvani { get; set; }

        public virtual List<Personel> Personeller { get; set; }

         
    }
}