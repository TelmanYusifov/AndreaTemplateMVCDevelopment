namespace BlogAppDevelopment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorDetailsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorName", c => c.String());
            AddColumn("dbo.Authors", "AuthorSurname", c => c.String());
            AddColumn("dbo.Authors", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Description");
            DropColumn("dbo.Authors", "AuthorSurname");
            DropColumn("dbo.Authors", "AuthorName");
        }
    }
}
