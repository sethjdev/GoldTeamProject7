namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productuser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Photo");
        }
    }
}
