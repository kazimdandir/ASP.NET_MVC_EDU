using mvc_intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_intermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //veritabanına bağlanır ve bilgileri getirir
            //getirilen bilgiler bir model içerisine yani bir sınıf içerisine aktarılır ve model view'e gönderilir

            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){ UrunId = 1, UrunAdi = "Samsung S6", Aciklama = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", Fiyat = 1000, Satistami = true },
                new Urun(){ UrunId = 2, UrunAdi = "Samsung S7", Aciklama = "Kötü", Fiyat = 1500, Satistami = false },
                new Urun(){ UrunId = 3, UrunAdi = "Samsung S8", Aciklama = "İdare Eder", Fiyat = 2000, Satistami = true },
                new Urun(){ UrunId = 4, UrunAdi = "Iphone 6", Aciklama = "Kötü", Fiyat = 3000, Satistami = false },
                new Urun(){ UrunId = 5, UrunAdi = "Iphone 7 Plus", Aciklama = "Kötü", Fiyat = 4000, Satistami = true },
                new Urun(){ UrunId = 6, UrunAdi = "Iphone 8 Plus", Aciklama = "Kötü", Fiyat = 5000, Satistami = true },
                new Urun(){ UrunId = 7, UrunAdi = "Iphone 10", Aciklama = "İdare Eder", Fiyat = 6000, Satistami = false },
                new Urun(){ UrunId = 8, UrunAdi = "Iphone 11", Aciklama = "İdare Eder", Fiyat = 7000, Satistami = true },
                new Urun(){ UrunId = 9, UrunAdi = "Iphone 11 Plus", Aciklama = "İyi", Fiyat = 8000, Satistami = false }
            };

            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){ Id = 1, KategoriAdi = "Telefon"},
                new Kategori(){ Id = 2, KategoriAdi = "Tablet"},
                new Kategori(){ Id = 3, KategoriAdi = "Laptop"},
            };

            ViewBag.UrunSayisi = urunler.Count();
            ViewBag.Kategoriler = kategoriler;

            return View(urunler);
        }
    }
}