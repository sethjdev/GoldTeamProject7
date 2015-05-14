namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Trans2Product : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "TransactionID", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "TransactionID");
        }
    }
}
