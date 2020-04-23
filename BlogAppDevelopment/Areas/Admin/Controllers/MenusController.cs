using BlogAppDevelopment.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogAppDevelopment.Areas.Admin.Controllers
{
    public class MenusController : Controller
    {
        private readonly BlogDbContext _blogDbContext;
        public MenusController()
        {
            _blogDbContext = new BlogDbContext();
        }
        // GET: Admin/Menus
        public async Task<ActionResult> Index()
        {
            var AllMenus = await _blogDbContext.Menus.ToListAsync();
            return View(AllMenus);
        }
    }
}