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

            model.UrunSayisi = VeriTabani.Liste.Count();
            model.Urunler = VeriTabani.Liste;

            //ViewBag.UrunSayisi = urunler.Count();
            //ViewBag.Kategoriler = kategoriler;

            return View(model);
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