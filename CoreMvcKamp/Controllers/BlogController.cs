using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcKamp.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.value = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult BlogReadAll(Blog p)
        {
            bm.BlogUpdate(p);
            return View();
        }
    }
}
