using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    class DatabaseContext:DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Alici> Alicilar { get; set; }
        public DbSet<Kiralanmislar> Kiralanmislar { get; set; }

    }
}
