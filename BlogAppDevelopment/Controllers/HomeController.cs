using BlogAppDevelopment.Data;
using BlogAppDevelopment.Infrastructure;
using BlogAppDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
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
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync(int page=1)
        {
            return View(await _blogDbContext.GetPaginatableDataAsync(page, _itemsPerPage));
        }
        public ActionResult Travel()
        {
            return View();
        }
        public  ActionResult Categories()
        {
            var categories = _blogDbContext.Categories.Select(x => new CategoryModel
            {
                ArticleCount = x.Articles.Count,
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return View(categories);
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}