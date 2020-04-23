using BlogAppDevelopment.Data;
using BlogAppDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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
        public async Task<ActionResult> Api(int id)
        {
            //Search for Article by Id
            var article = await _blogDbContext.Articles.FirstOrDefaultAsync(x=> x.Id == id);
            if (article == null)
            {
                return RedirectToAction("Error", "Home");
            }

            ArticleDetailsModel model = new ArticleDetailsModel
            {
                Author = new AuthorModel
                {
                    AuthorName = article.Author.AuthorName,
                    AuthorSurname = article.Author.AuthorSurname,
                    Description = article.Author.Description,
                    UserId = article.Author.UserId
                },
                Description = article.Description,
                Id = article.Id,
                ImagePath = article.ImagePath,
                ShortDescription = article.ShortDescription,
                Title = article.Title,
                Tags = article.Tags.Select(c => new TagModel
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList(),
                Comments = article.Comments.Select(c => new CommentModel
                {
                    ArticleId = c.ArticleId,
                    Email = c.Email,
                    Name = c.Name,
                    Text = c.Text,
                    WebSite = c.WebSite,
                    Id = c.Id,
                    CommentDate = c.CommentDate
                }).ToList()
            };

            return Json(model, JsonRequestBehavior.AllowGet);
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

            ArticleDetailsModel model = new ArticleDetailsModel
            {
                Author = new AuthorModel
                {
                    AuthorName = article.Author.AuthorName,
                    AuthorSurname = article.Author.AuthorSurname,
                    Description = article.Author.Description,
                    UserId = article.Author.UserId
                },
                Description = article.Description,
                Id = article.Id,
                ImagePath = article.ImagePath,
                ShortDescription = article.ShortDescription,
                Title = article.Title,
                Tags = article.Tags.Select(c=> new TagModel 
                { 
                    Id = c.Id,
                    Name = c.Name
                }).ToList(),
                Comments = article.Comments.Select(c=> new CommentModel
                {
                    ArticleId = c.ArticleId,
                    Email = c.Email,
                    Name = c.Name,
                    Text = c.Text,
                    WebSite = c.WebSite,
                    Id = c.Id,
                    CommentDate = c.CommentDate
                }).ToList()
            };

            return View(model);
        }
    }
}
