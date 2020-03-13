using BlogAppDevelopment.Data;
using BlogAppDevelopment.Infrastructure;
using BlogAppDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogAppDevelopment.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogDbContext _blogDbContext;
        private byte _itemsPerPage=4;
        public HomeController()
        {
            _blogDbContext = new BlogDbContext();
        }
        // GET: Home
        public ActionResult Index(int page=1)
        {
            return View(_blogDbContext.GetPaginatableData(page, _itemsPerPage));
        }
        public ActionResult Travel()
        {
            return View();
        }
        public ActionResult Categories()
        {
            var categories = _blogDbContext.Categories.Select(x => new CategoryModel
            {
                ArticleCount = x.Articles.Count,
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return View(categories);
        }
    }
}