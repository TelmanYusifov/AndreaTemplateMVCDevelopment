namespace BlogAppDevelopment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "UserId", "dbo.AppUsers");
            DropIndex("dbo.Comments", new[] { "UserId" });
            AddColumn("dbo.Comments", "Name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Comments", "WebSite", c => c.String());
            AddColumn("dbo.Comments", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "Text", c => c.String(nullable: false));
            DropColumn("dbo.Comments", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Comments", "Text", c => c.String());
            DropColumn("dbo.Comments", "Email");
            DropColumn("dbo.Comments", "WebSite");
            DropColumn("dbo.Comments", "Name");
            CreateIndex("dbo.Comments", "UserId");
            AddForeignKey("dbo.Comments", "UserId", "dbo.AppUsers", "Id", cascadeDelete: true);
        }
    }
}
