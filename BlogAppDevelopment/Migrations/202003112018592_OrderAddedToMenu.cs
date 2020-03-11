namespace BlogAppDevelopment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderAddedToMenu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Order", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "Order");
        }
    }
}
