namespace BlogAppDevelopment.Migrations
{
    using BlogAppDevelopment.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogAppDevelopment.Data.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogAppDevelopment.Data.BlogDbContext context)
        {
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
