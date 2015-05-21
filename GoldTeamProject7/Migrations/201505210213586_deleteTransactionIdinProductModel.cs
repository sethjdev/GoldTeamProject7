namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteTransactionIdinProductModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "TransactionID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "TransactionID", c => c.String(nullable: false));
        }
    }
}
