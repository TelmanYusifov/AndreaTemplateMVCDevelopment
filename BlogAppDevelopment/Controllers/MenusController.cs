using BlogAppDevelopment.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogAppDevelopment.Controllers
{
    public class MenusController : Controller
    {
        private readonly BlogDbContext _blogDbContext;
        public MenusController()
        {
            _blogDbContext = new BlogDbContext();
        }
        // GET: Menus
        public PartialViewResult AllMenus()
        {
            var menus = _blogDbContext.Menus.Where(x=>x.IsActive==true).ToList();
            return PartialView(menus);
        }
    }
}