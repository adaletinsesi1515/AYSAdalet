using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{
    [Table("Login")]
    public class Login
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required, StringLength(15)]
        public string KullaniciAdi { get; set; }

        [Required, StringLength(15)]
        public string Parola { get; set; }
        public string YetkiDuzeyi { get; set; }

    }
}