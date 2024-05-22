using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public bool IkinciElMi { get; set; }
        public double Fiyat { get; set; }
        public int StokAdeti { get; set; }
        public bool Satistami { get; set; }

        public int KategoriId { get; set; } //foreign key, otomatik bağlantı kuracak, KategoriId = Kategori + Id

        public Kategori Kategori { get; set; } //burası program anında kullanılacak 

        public List<Tedarikci> Tedarikciler { get; set; } //burası program anında kullanılacak 
    }
}
