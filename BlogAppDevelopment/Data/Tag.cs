using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogAppDevelopment.Data
{
    public class Tag
    {
        public Tag()
        {
            Articles = new HashSet<Article>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50,MinimumLength =2)]
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}