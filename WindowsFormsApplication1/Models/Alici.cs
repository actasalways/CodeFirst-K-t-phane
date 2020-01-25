using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    [Table("table_alicilar")]

    class Alici
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int Alici_id { get; set; }
        [StringLength(50), Required] public string AliciAd { get; set; }
        [StringLength(50), Required] public string AliciSoyad { get; set; }
        [StringLength(50), Required] public string AliciTelefon { get; set; }

        public int AliciCeza { get; set; }

    }
}
