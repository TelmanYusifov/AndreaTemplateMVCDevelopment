using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAppDevelopment.Data
{
    public class Author
    {
        public Author()
        {
            Articles = new HashSet<Article>();
        }
        public int Id { get; set; }
        public AppUser User { get; set; }
        public int UserId { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}