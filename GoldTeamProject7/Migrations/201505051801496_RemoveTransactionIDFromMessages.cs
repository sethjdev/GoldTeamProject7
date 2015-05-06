namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTransactionIDFromMessages : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "TransactionID", "dbo.Transactions");
            DropIndex("dbo.Messages", new[] { "TransactionID" });
            DropColumn("dbo.Messages", "TransactionID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "TransactionID", c => c.Int(nullable: false));
            CreateIndex("dbo.Messages", "TransactionID");
            AddForeignKey("dbo.Messages", "TransactionID", "dbo.Transactions", "ID", cascadeDelete: true);
        }
    }
}
