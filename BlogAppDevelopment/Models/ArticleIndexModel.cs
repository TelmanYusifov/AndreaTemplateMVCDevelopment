using BlogAppDevelopment.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogAppDevelopment.Models
{
    public class ArticleIndexModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 200, MinimumLength = 3)]
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        public uint ViewCount { get; set; }
        public int CommentCount { get; set; }
        public Author Author { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}