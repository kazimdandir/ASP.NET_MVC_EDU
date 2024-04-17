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

            string[] kurslar = { "Mvc kursu", "web form kursu", "c# kursu", "Mvc kursu", "web form kursu", "c# kursu" };

            return View(kurslar);
        }
    }
}