namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transaction : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "Messages_ID", "dbo.Messages");
            DropIndex("dbo.Transactions", new[] { "Messages_ID" });
            //CreateIndex("dbo.Messages", "TransactionID");
            //AddForeignKey("dbo.Messages", "TransactionID", "dbo.Transactions", "ID", cascadeDelete: true);
            DropForeignKey("dbo.Messages", "TransactionID", "dbo.Transactions");
            DropColumn("dbo.Transactions", "MessageID");
            DropColumn("dbo.Transactions", "Messages_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Messages_ID", c => c.Int());
            AddColumn("dbo.Transactions", "MessageID", c => c.Int(nullable: false));
            DropIndex("dbo.Messages", new[] { "TransactionID" });
            CreateIndex("dbo.Transactions", "Messages_ID");
            AddForeignKey("dbo.Transactions", "Messages_ID", "dbo.Messages", "ID");
        }
    }
}
