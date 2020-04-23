namespace BlogAppDevelopment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentDateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "CommentDate", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "CommentDate");
        }
    }
}
