using BlogAppDevelopment.Areas.Admin.Models;
using BlogAppDevelopment.Data;
using BlogAppDevelopment.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogAppDevelopment.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly BlogDbContext _blogDbContext;
        public AccountController()
        {
            _blogDbContext = new BlogDbContext();
        }
        // GET: Admin/Account
        [HttpGet]
        public ActionResult Login()
        {
            ViewData["title"] = "Login Page";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = _blogDbContext.AppUsers.UserExists(loginModel);
                if(appUser == null)
                {
                    ModelState.AddModelError("", "Given username or password not exists.");
                    ViewBag.Error = "Given UserName or Password not exists.";
                    return RedirectToAction(nameof(Login));
                }
                else
                {
                    Session.Add("UserInfo",appUser.Id);
                    return RedirectToAction(nameof(Success));
                    
                }
            }
            return RedirectToAction(nameof(Login));
        }
        public ActionResult Success()
        {
            if (Session["UserInfo"] != null)
                return View();
            else
                return RedirectToAction(nameof(Login));
        }
    }
}