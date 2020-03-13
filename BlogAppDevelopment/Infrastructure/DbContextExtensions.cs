using BlogAppDevelopment.Data;
using BlogAppDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAppDevelopment.Infrastructure
{
    public static class DbContextExtensions
    {
        public static IEnumerable<ArticleIndexModel> GetPaginatableData(this BlogDbContext blogDbContext, int page, int itemsPerPage)
        {
            return blogDbContext.Articles.OrderByDescending(x => x.PublishDate).Skip((page - 1) * itemsPerPage).Take(itemsPerPage).Select(x => new ArticleIndexModel
            {
                Id = x.Id,
                Categories = x.Categories.Select(y => new CategoryModel
                {
                    Id = y.Id,
                    Name = y.Name
                }),
                ImagePath = x.ImagePath,
                PublishDate = x.PublishDate,
                ShortDescription = x.ShortDescription,
                Title = x.Title,
                CommentCount = x.Comments.Count(),
                Author = x.Author
                //ViewCount = x.ViewCount
            }).ToList();
        }
    }
}