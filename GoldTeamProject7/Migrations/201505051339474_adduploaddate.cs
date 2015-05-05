namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adduploaddate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "UploadDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "UploadDate");
        }
    }
}
