﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogAppDevelopment.Data
{
    public class Article
    {
        public Article()
        {
            Comments = new HashSet<Comment>();
            Tags = new HashSet<Tag>();
            Categories = new HashSet<Category>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:200,MinimumLength =3)]
        public string Title { get; set; }
        public virtual Author Author { get; set; }
        public int AuthorId { get; set; }
        public DateTime PublishDate { get; set; }
        [Required]
        public DateTime WrittenDate { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        public uint ViewCount { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual Menu Menu { get; set; }
        public int MenuId { get; set; }
        public ICollection<Category> Categories { get; set; }

    }
}