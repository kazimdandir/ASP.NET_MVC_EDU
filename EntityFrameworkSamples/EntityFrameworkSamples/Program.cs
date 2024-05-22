using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//İlk olarak NuGet üzerinden EntityFramework install edildi.

namespace EntityFrameworkSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Inserting Data
            // LINQ (Language integrated query)
            //UrunContext context = new UrunContext();

            //List<Urun> urunler = new List<Urun>()
            //{
            //    new Urun(){UrunAdi="Samsung S4", Fiyat = 2000, StokAdeti = 100, Satistami = true},
            //    new Urun(){UrunAdi="Samsung S5", Fiyat = 3000, StokAdeti = 200, Satistami = false},
            //    new Urun(){UrunAdi="Samsung S6", Fiyat = 4000, StokAdeti = 300, Satistami = true},
            //    new Urun(){UrunAdi="Samsung S7", Fiyat = 5000, StokAdeti = 400, Satistami = false},
            //    new Urun(){UrunAdi="Samsung S8", Fiyat = 6000, StokAdeti = 100, Satistami = true}
            //};

            //foreach (var urun in urunler)
            //{
            //    context.Urunler.Add(urun);
            //}

            //context.SaveChanges();

            //Console.WriteLine("kayıt edildi");
            #endregion

            #region Updating Data

            //UrunContext context = new UrunContext();

            ////var urun = context.Urunler.Find(1);

            ////Console.WriteLine("Urun Id : {0} Urun Adı : {1} Fiyat : {2}", urun.Id, urun.UrunAdi, urun.Fiyat);

            ////urun.Fiyat = urun.Fiyat + (urun.Fiyat * 0.5);
            ////urun.UrunAdi = "Samsung S6";
            ////urun.StokAdeti += 100;

            ////context.SaveChanges();

            ////urun = context.Urunler.Find(1);

            ////Console.WriteLine("Urun Id : {0} Urun Adı : {1} Fiyat : {2}", urun.Id, urun.UrunAdi, urun.Fiyat);

            //var urunler = context.Urunler.ToList();

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("Fiyat : {0}", urun.Fiyat);
            //}

            //Console.WriteLine("--------------");

            //foreach (var urun in urunler)
            //{
            //    urun.Fiyat *= 1.5;
            //}

            //context.SaveChanges();

            //urunler = context.Urunler.ToList();

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("Fiyat : {0}", urun.Fiyat);
            //}

            #endregion

            #region Deleting Data

            //UrunContext db = new UrunContext();

            ////var urun = db.Urunler.Find(2);

            ////if (urun != null)
            ////{
            ////    db.Urunler.Remove(urun);
            ////}

            ////db.SaveChanges();

            //////var urunler = db.Urunler.ToList();
            ////foreach (var item in db.Urunler)
            ////{
            ////    Console.WriteLine("Urun Id : {0} Urun Adı : {1}", item.Id, item.UrunAdi);
            ////}


            //// Aşağıdaki kod tüm ürünleri siler, yukarıdaki belirttiğin ürünü siler
            //var urunler = db.Urunler.ToList();

            //foreach (var urun in urunler)
            //{
            //    db.Urunler.Remove(urun);
            //}

            //db.SaveChanges();

            //if (db.Urunler.Count() == 0)
            //{
            //    Console.WriteLine("Veritabanında ürün bulunamadı");
            //}
            //else
            //{
            //    foreach (var item in db.Urunler)
            //    {
            //        Console.WriteLine("Urun Id : {0} Urun Adı : {1}", item.Id, item.UrunAdi);
            //    }
            //}

            #endregion

            #region Seeding Data

            //// entity framework initializer : test verilerini her seferinde veritabanına getiriyor

            //// https://www.entityframeworktutorial.net/code-first/database-initialization-strategy-in-code-first.aspx

            //// DataInitializer sınıfında DropCreateDatabaseIfModelChanges<UrunContext>'ı kalıtım alarak db'deki entity sınıflarında bir değişiklik olursa db'yi silmesini ve yeniden oluşturmasını sağladık

            //UrunContext db = new UrunContext();
            //var urunler = db.Urunler.ToList();

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine("urun adı : {0}, ikinci el mi ? : {1}", item.UrunAdi, item.IkinciElMi);
            //}

            //Console.WriteLine("veritabanı oluştu");

            #endregion

            #region Entity Relationships

            // Buraya kadar yaptığımız örneklerde Urun ve Kategori sınıflarımız vardı ama hiç bir ürün ile kategoriyi ilişkilendirmedik şimdi entity sınıflarını ilişkilendireceğiz.

            //Arka tarafta Urun ve Kategori sınıflarında gerekli yapıları oluşturduk ve Tedarikci sınıfını da oluşturup çoka çok bir ilişki kurduk.

            #endregion

            #region Linq To Objects

            string[] isimler = { "ahmet", "mehmet", "hasan", "ayşe" };
            //var isimler2 = isimler.Select(i => i.Length > 4); //true, falsa döner

            var isimler2 = isimler.Where(i => i.Length > 4); //değeri seçmek için where kullanmalıyız

            foreach (var item in isimler2)
            {
                Console.WriteLine(item);
            }

            //int[] sayilar = { 1, 5, 6, 4, 9, 8, 3 };

            ////var sayilar2 = sayilar.Select(i => i + 1); //linq ile her sayıya bir ekledik ve foreach ile aşağıdaki yazdırdık

            ////var sayilar2 = sayilar.Select(i => i % 2 == 1); //true-false döner

            //var sayilar2 = sayilar.Where(i => i % 2 == 1).OrderByDescending(i => i); //değer döndürür ve sıralar


            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            Console.ReadLine();
        }
    }
}
