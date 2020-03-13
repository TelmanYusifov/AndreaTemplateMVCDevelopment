namespace BlogAppDevelopment.Migrations
{
    using BlogAppDevelopment.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Configuration;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogAppDevelopment.Data.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogAppDevelopment.Data.BlogDbContext context)
        {
            string email = ConfigurationManager.AppSettings["Email"];
            string username = ConfigurationManager.AppSettings["Username"];
            string password = ConfigurationManager.AppSettings["Password"];
            context.AppUsers.AddOrUpdate(new AppUser
            {
                Id=1,
                IsActive=true,
                IsAuthor=true,
                Email=email,
                Password= password,
                Username=username
            });
            context.Authors.AddOrUpdate(new Author
            {
                Id = 1,
                UserId = 1
            });
            context.Categories.AddOrUpdate(new Category
            {
                Name = "Fashion",
                Id = 1,
            }, 
            new Category
            {
                Name = "Technology",
                Id = 2,
            }, 
            new Category
            {
                Name = "Travel",
                Id = 3,
            }, 
            new Category
            {
                Name = "Food",
                Id = 4,
            }, 
            new Category
            {
                Name = "Photography",
                Id = 5,
            });
            context.Articles.AddOrUpdate(new Article
            {
                AuthorId=1,
                ShortDescription= "A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                Description= "A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                ImagePath="image_1.jpg",
                MenuId=1,
                PublishDate=DateTime.Now,
                Title= "A Loving Heart is the Truest Wisdom",
                ViewCount = 1,
                WrittenDate = DateTime.Now,
                Id = 1
            },
            new Article
            {
                AuthorId = 1,
                ShortDescription = "A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                Description = "A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                ImagePath = "image_2.jpg",
                MenuId = 1,
                PublishDate = DateTime.Now,
                Title = "Great Things Never Came from Comfort Zone",
                ViewCount = 1,
                WrittenDate = DateTime.Now,
                Id = 2
            },
            new Article
            {
                AuthorId = 1,
                ShortDescription = "A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                Description = "A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.A small river named Duden flows by their place and supplies it with the necessary regelialia.",
                ImagePath = "image_3.jpg",
                MenuId = 1,
                PublishDate = DateTime.Now,
                Title = "Paths Are Made by Walking",
                ViewCount = 1,
                WrittenDate = DateTime.Now,
                Id = 3
            });

            context.Menus.AddOrUpdate(new Menu
            {
                Id = 1,
                IsActive = true,
                Name = "Travel",
                ControllerName = "Home",
                ActionName = "Travel",
                Order=1
            },
            new Menu
            {
                Id = 2,
                IsActive = true,
                Name = "Fashion",
                ControllerName = "Home",
                ActionName = "Fashion",
                Order=2
            },
            new Menu
            {
                Id = 3,
                IsActive = true,
                Name = "About",
                ControllerName = "Home",
                ActionName = "About",
                Order=3
            },
            new Menu
            {
                Id = 4,
                IsActive = true,
                Name = "Contact",
                ControllerName = "Home",
                ActionName = "Contact",
                Order=4
            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
