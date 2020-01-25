using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    [Table("table_kitaplar")]
    class Kitap
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int KitapId { get; set; }
        [StringLength(50), Required] public string KitapAd { get; set; }
        [StringLength(50), Required] public string KitapYazar { get; set; }
        [StringLength(50), Required] public string KitapISBN { get; set; }
        [StringLength(50)] public string KitapBasimTarihi { get; set; }
        [StringLength(50)] public string KitapYayinevi{ get; set; }
        public int KitapStok{ get; set; }




    }
}