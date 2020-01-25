using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    [Table("table_kiralanmislar")]
    class Kiralanmislar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KiralanmisId { get; set; }

        public int KitapId { get; set; }
        [StringLength(50)] public string RehinTarih { get; set; }
        [StringLength(50)] public string TeslimTarih { get; set; }

        public int Alici_id { get; set; }
        public bool TeslimAlindi { get; set; }




    }
}
