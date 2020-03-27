using BlogAppDevelopment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogAppDevelopment.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly BlogDbContext _blogDbContext;
        public ArticlesController()
        {
            _blogDbContext = new BlogDbContext();
        }
        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            //Search for Article by Id
            var article = await _blogDbContext.Articles.FindAsync(id);
            if(article == null)
            {
                return RedirectToAction("Error", "Home");
            }
            //_blogDbContext.Articles.Include("Authoe").Include("Tags")
            var art = _blogDbContext.Articles.Where(x => x.Id == id).FirstOrDefault();
            return View(article);
        }
    }
}
