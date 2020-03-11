namespace BlogAppDevelopment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsActiveAddedToMenu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "IsActive");
        }
    }
}
