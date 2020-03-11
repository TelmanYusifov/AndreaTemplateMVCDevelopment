using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogAppDevelopment.Data
{
    public class AppUser
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 3)]
        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength:30,MinimumLength =8)]
        public string Password { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public bool IsAuthor { get; set; }
    }
}