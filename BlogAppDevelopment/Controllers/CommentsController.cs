using BlogAppDevelopment.Data;
using BlogAppDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogAppDevelopment.Controllers
{
    public class CommentsController : Controller
    {
        private readonly BlogDbContext _blogDbContext;
        public CommentsController()
        {
            _blogDbContext = new BlogDbContext();
        }
        [ActionName("Add")]
        public async Task<ActionResult> AddAsync(CommentModel comment)
        {
            if (Request.IsAjaxRequest())
            {
                if (ModelState.IsValid)
                {
                    comment.CommentDate = DateTime.UtcNow;
                    Comment c = new Comment
                    {
                        ArticleId = comment.ArticleId,
                        Email = comment.Email,
                        Name = comment.Name,
                        Text = comment.Text,
                        WebSite = comment.WebSite,
                        Id = comment.Id,
                        CommentDate = comment.CommentDate
                    };
                    _blogDbContext.Comments.Add(c);
                    await _blogDbContext.SaveChangesAsync();
                    return Json(comment);
                }
                return Json("Bad Validation");
            }
            else
            {
                return Json("BadRequest");
            }
        }
        // GET: Comments
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[ActionName("Add")]
        //public async Task<ActionResult> AddAsync(CommentModel comment)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        comment.CommentDate = DateTime.UtcNow;
        //        Comment c = new Comment
        //        {
        //            ArticleId = comment.ArticleId,
        //            Email = comment.Email,
        //            Name = comment.Name,
        //            Text = comment.Text,
        //            WebSite = comment.WebSite,
        //            Id = comment.Id,
        //            CommentDate = comment.CommentDate
        //        };
        //        _blogDbContext.Comments.Add(c);
        //        await _blogDbContext.SaveChangesAsync();
        //    }
        //    return RedirectToAction(nameof(ArticlesController.Details), "Articles", new { id = comment.ArticleId });
        //}
    }
}