using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class UrunContext : DbContext
    {
        public UrunContext() :base("urunConnection")
        {
            Database.SetInitializer(new DataInitializer()); //initializerden uygulamayı haberdar ediyoruz
        }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
