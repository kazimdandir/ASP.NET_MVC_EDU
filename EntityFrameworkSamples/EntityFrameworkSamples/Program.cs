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

            Console.ReadLine();
        }
    }
}
