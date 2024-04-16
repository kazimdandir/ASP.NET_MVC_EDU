using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ViewResult Index()
        {
            return View();
        }

        //Urun/Liste
        public ViewResult Liste()
        {   
            return View(); 
        }

        public ViewResult UrunDetay()
        {
            return View();
        }
    }
}