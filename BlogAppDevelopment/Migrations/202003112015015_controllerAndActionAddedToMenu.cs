namespace BlogAppDevelopment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class controllerAndActionAddedToMenu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "ControllerName", c => c.String(nullable: false));
            AddColumn("dbo.Menus", "ActionName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "ActionName");
            DropColumn("dbo.Menus", "ControllerName");
        }
    }
}
