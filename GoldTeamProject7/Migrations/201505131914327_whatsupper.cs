namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class whatsupper : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "oldMessages", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "oldMessages");
        }
    }
}
