using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AYSAdalet.Models.Modeller
{


    [Table("Bilgi_Monitorler")]
    public class Bilgi_Monitorler
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MonitorID { get; set; }

        [Required, StringLength(50)]
        public string MonitorMarka { get; set; }

        [Required, StringLength(50)]
        public string MonitorModel { get; set; }

        [StringLength(50)]
        public string MonitorSeriNo { get; set; }

        public bool Durum { get; set; }

        //public virtual List<BilgiZimmet> BilgiZimmet { get; set; }
    }


}