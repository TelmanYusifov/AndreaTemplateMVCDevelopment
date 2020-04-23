namespace ConsoleAppAsync
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AndreaModel : DbContext
    {
        public AndreaModel()
            : base("name=AndreaModel")
        {
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>()
                .HasMany(e => e.Authors)
                .WithRequired(e => e.AppUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Article>()
                .HasMany(e => e.Categories)
                .WithMany(e => e.Articles)
                .Map(m => m.ToTable("CategoryArticles"));

            modelBuilder.Entity<Article>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Articles)
                .Map(m => m.ToTable("TagArticles"));
        }
    }
}
