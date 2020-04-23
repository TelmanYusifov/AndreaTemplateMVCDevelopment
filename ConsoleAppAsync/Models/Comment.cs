namespace ConsoleAppAsync
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Text { get; set; }

        public int ArticleId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string WebSite { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CommentDate { get; set; }

        public virtual Article Article { get; set; }
    }
}
