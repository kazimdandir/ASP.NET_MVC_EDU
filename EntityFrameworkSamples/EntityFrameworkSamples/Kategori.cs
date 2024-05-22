using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class Kategori
    {
        //[Key]
        //public int KategoriId { get; set; }

        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public List<Urun> Urunler { get; set; } //burası program anında kullanılacak 
    }
}
