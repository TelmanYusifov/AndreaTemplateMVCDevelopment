using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAppDevelopment.Models
{
    public class AuthorModel
    {
        public int UserId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string Description { get; set; }
    }
}