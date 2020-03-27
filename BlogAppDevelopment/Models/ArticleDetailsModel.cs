using BlogAppDevelopment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAppDevelopment.Models
{
    public class ArticleDetailsModel
    {
        int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public List<TagModel> Tags { get; set; }
        public AuthorModel Author { get; set; }
    }
}