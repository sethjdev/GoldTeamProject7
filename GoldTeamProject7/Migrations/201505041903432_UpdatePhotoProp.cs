namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePhotoProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "MainPhoto", c => c.Binary());
            DropColumn("dbo.Products", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Photo", c => c.String());
            DropColumn("dbo.Products", "MainPhoto");
        }
    }
}
