using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    class KategoriUrunModel
    {
        public string KategoriAdi { get; set; }
        public List<UrunModel> Urunler { get; set; }
    }
}
