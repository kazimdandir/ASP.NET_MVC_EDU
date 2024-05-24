using BlogMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();

        // GET: Home
        public ActionResult Index()
        {
            var blogs = context.Blogs
                               .Select(i => new BlogModel()
                               {
                                   Id = i.Id,
                                   Title = i.Title.Length > 100 ? i.Title.Substring(0, 100) + "..." : i.Title,
                                   Description = i.Description,
                                   DateOfUpload = i.DateOfUpload,
                                   HomePage = i.HomePage,
                                   Approval = i.Approval,
                                   Picture = i.Picture
                               })
                               .Where(i => i.Approval == true && i.HomePage == true);

            return View(blogs.ToList());
        }
    }
}