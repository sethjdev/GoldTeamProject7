namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transactionId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "TransactionID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "TransactionID");
        }
    }
}
