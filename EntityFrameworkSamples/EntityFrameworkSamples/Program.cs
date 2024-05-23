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

            //string[] isimler = { "ahmet", "mehmet", "hasan", "ayşe" };
            ////var isimler2 = isimler.Select(i => i.Length > 4); //true, falsa döner

            //var isimler2 = isimler.Where(i => i.Length > 4); //değeri seçmek için where kullanmalıyız

            //foreach (var item in isimler2)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] sayilar = { 1, 5, 6, 4, 9, 8, 3 };

            ////var sayilar2 = sayilar.Select(i => i + 1); //linq ile her sayıya bir ekledik ve foreach ile aşağıdaki yazdırdık

            ////var sayilar2 = sayilar.Select(i => i % 2 == 1); //true-false döner

            //var sayilar2 = sayilar.Where(i => i % 2 == 1).OrderByDescending(i => i); //değer döndürür ve sıralar


            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Selecting

            //UrunContext db = new UrunContext();

            #region #1

            //// model için bir obje üretelim
            //// view'in modeli --> @model List<KategoriUrunModel>()

            //var kategoriler = db.Kategoriler
            //    .Select(a => new KategoriUrunModel()
            //    {
            //        KategoriAdi = a.KategoriAdi,
            //        Urunler = a.Urunler.Select(b => new UrunModel()
            //        {
            //            UrunAdi = b.UrunAdi,
            //            Fiyat = b.Fiyat
            //        }).ToList()
            //    })
            //    .ToList();

            //foreach (var kategori in kategoriler)
            //{
            //    Console.WriteLine("kategori : {0}", kategori.KategoriAdi);
            //    Console.WriteLine("-------------------------------------");
            //    foreach (var urun in kategori.Urunler)
            //    {
            //        Console.WriteLine("urun adı = {0} fiyat : {1}", urun.UrunAdi, urun.Fiyat);
            //    }
            //}

            #endregion

            #region #2

            //var urunler = db.Urunler.
            //    Select(i => new UrunModel()
            //    {
            //        //anonymous object
            //        UrunAdi = i.UrunAdi.Length > 12 ? i.UrunAdi.Substring(0, 9) + "..." : i.UrunAdi,
            //        Fiyat = i.Fiyat, // burada TERNERT EXPRESSION  kullandık (koşul ? kod_1 : kod_2;)
            //        Kategori = i.Kategori.KategoriAdi
            //    })
            //    .ToList();

            //// @model List<UrunModel>
            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("urun adı : {0} fiyat : {1} kategori : {2}", urun.UrunAdi, urun.Fiyat, urun.Kategori);
            //}

            #endregion

            #region #3

            //var urunler = db.Urunler.
            //    Select(i => new
            //    {
            //        //anonymous object
            //        ProductName = i.UrunAdi.Length > 12 ? i.UrunAdi.Substring(0, 9) + "..." : i.UrunAdi,
            //        Price = i.Fiyat // burada TERNERT EXPRESSION  kullandık (koşul ? kod_1 : kod_2;)
            //    })
            //    .ToList();

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("urun adı : {0} fiyat : {1}", urun.ProductName, urun.Price);
            //}

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("urun id : {4} urun adı : {0} fiyat : {1} stok : {2} kategori id : {3}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti, urun.KategoriId, urun.Id);
            //}

            #endregion

            #endregion

            #region Inserting

            //UrunContext db = new UrunContext();

            #region #1

            //var kategoriler = db.Kategoriler
            //    .Where(i => i.KategoriAdi == "Temizlik")
            //    .Select(i =>
            //    new
            //    {
            //        i.KategoriAdi,
            //        i.Urunler
            //    }).
            //    ToList();

            //foreach (var kategori in kategoriler)
            //{
            //    Console.WriteLine(kategori.KategoriAdi);

            //    foreach (var urun in kategori.Urunler)
            //    {
            //        Console.WriteLine(urun.UrunAdi);
            //    }
            //}

            #endregion

            #region #2

            //Urun urun = new Urun();
            //urun.UrunAdi = "Omo Çamaşır Deterjanı";
            //urun.StokAdeti = 200;
            //urun.Fiyat = 30;

            //urun.Kategori = db.Kategoriler.Where(i=>i.KategoriAdi=="Temizlik").FirstOrDefault();

            //db.Urunler.Add(urun);
            //db.SaveChanges();

            //foreach (var item in db.Kategoriler.Where(i => i.KategoriAdi == "Temizlik"))
            //{
            //    foreach (var entity in item.Urunler)
            //    {
            //        Console.WriteLine(entity.UrunAdi);
            //    }
            //}

            #endregion

            #region #3

            //Urun urun = new Urun();
            //urun.UrunAdi = "Ace Çamaşır Suyu";
            //urun.StokAdeti = 200;
            //urun.Fiyat = 10;

            //urun.Kategori = new Kategori() { KategoriAdi = "Temizlik" };

            //db.Urunler.Add(urun);
            //db.SaveChanges();

            //foreach (var item in db.Kategoriler.Where(i=>i.KategoriAdi=="Temizlik"))
            //{
            //    foreach (var entity in item.Urunler)
            //    {
            //        Console.WriteLine(entity.UrunAdi);
            //    }
            //}

            #endregion

            #region #4

            //Kategori kategori = new Kategori();
            //kategori.KategoriAdi = "Kişisel Bakım";

            //Urun urun = new Urun();
            //urun.UrunAdi = "Signal Diş Macunu";
            //urun.Fiyat = 15;
            //urun.StokAdeti = 100;

            //kategori.Urunler.Add(urun);
            //db.Kategoriler.Add(kategori);

            //db.SaveChanges();

            //foreach (var item in db.Urunler.Where(i => i.Kategori.KategoriAdi == "Kişisel Bakım"))
            //{
            //    Console.WriteLine(item.UrunAdi);
            //}

            #endregion

            #region #5

            //Urun entity = new Urun();
            //entity.UrunAdi = "iPhone 7 Plus";
            //entity.Fiyat = 4000;
            //entity.StokAdeti = 100;
            //entity.KategoriId = 1;
            //db.Urunler.Add(entity);
            //db.SaveChanges();

            //foreach (var item in db.Urunler.Where(i => i.KategoriId == 1))
            //{
            //    Console.WriteLine("urun adı : {0}", item.UrunAdi);
            //}

            //Kategori entity = new Kategori();
            //entity.KategoriAdi = "Kitap";
            //db.Kategoriler.Add(entity);
            //db.SaveChanges();

            //foreach (var kategori in db.Kategoriler)
            //{
            //    Console.WriteLine(kategori.KategoriAdi);
            //}

            #endregion

            #endregion

            #region Updating

            //UrunContext db = new UrunContext();

            #region Kategori üzerinden ürün güncelleme

            //var kategoriler = db.Kategoriler.Where(i => i.Id == 1).Select(i => new { i.KategoriAdi, i.Urunler }).ToList();

            //foreach (var kategori in kategoriler)
            //{
            //    foreach (var urun in kategori.Urunler)
            //    {
            //        urun.UrunAdi += " deneme";
            //    }
            //}

            //db.SaveChanges();

            //var urunler = db.Urunler.Where(i => i.KategoriId == 1).ToList();

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine(item.UrunAdi);
            //}

            #endregion

            #region Ürünler için güncelleme

            //var urunler = db.Urunler.ToList();

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine("urun adı : {0} fiyat : {1} ", item.UrunAdi, item.Fiyat);
            //}

            //foreach (var item in urunler)
            //{
            //    item.Fiyat *= 1.25;
            //}

            //db.SaveChanges();

            //Console.WriteLine("------------------------");

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine("urun adı : {0} fiyat : {1} ", item.UrunAdi, item.Fiyat);
            //}

            #endregion

            #region Kategoriler için güncelleme

            //var kategori = db.Kategoriler.Where(i => i.Id == 1).FirstOrDefault();

            //if (kategori != null)
            //{
            //    kategori.KategoriAdi = "Telefonlar";
            //    db.SaveChanges();
            //}

            //foreach (var item in db.Kategoriler)
            //{
            //    Console.WriteLine(item.KategoriAdi);
            //}

            #endregion



            #endregion

            #region Deleting

            //UrunContext db = new UrunContext();

            #region Ürün silme

            //var urunler = db.Urunler.Where(i => i.KategoriId == 2).ToList();

            //foreach (var urun in urunler)
            //{
            //    db.Urunler.Remove(urun);
            //}

            //db.SaveChanges();

            #endregion

            #region Kategori silme

            //var kategori = db.Kategoriler.Where(i => i.Id == 1).FirstOrDefault();

            //if (kategori != null)
            //{
            //    db.Kategoriler.Remove(kategori);
            //}

            //db.SaveChanges();

            //foreach (var item in db.Kategoriler)
            //{
            //    Console.WriteLine(item.Id);
            //}

            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
