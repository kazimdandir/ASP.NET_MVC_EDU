using mvc_intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_intermediate.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult KategoriMenu()
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){ Id = 1, KategoriAdi = "Telefon"},
                new Kategori(){ Id = 2, KategoriAdi = "Tablet"},
                new Kategori(){ Id = 3, KategoriAdi = "Laptop"},
            };

            return PartialView("KategoriMenu", kategoriler);
        }
    }
}