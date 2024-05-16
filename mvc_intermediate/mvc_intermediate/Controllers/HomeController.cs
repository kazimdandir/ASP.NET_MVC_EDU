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
            UrunKategoriModel model = new UrunKategoriModel();

            model.UrunSayisi = VeriTabani.Liste.Where(i => i.Satistami == true).Count();
            model.Urunler = VeriTabani.Liste.Where(i => i.Satistami == true).ToList();

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var urun = VeriTabani.Liste.Where(i => i.UrunId == id).FirstOrDefault();
            
            return View(urun);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}