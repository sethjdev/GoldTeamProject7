namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productkeyupdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "UserId", c => c.String());
        }
    }
}
