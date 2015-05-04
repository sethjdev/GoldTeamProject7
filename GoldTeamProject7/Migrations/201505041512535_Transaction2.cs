namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Transaction2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MessageID = c.Int(nullable: false),
                        Created = c.DateTime(),
                        BuyerID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Messages_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Messages", t => t.Messages_ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.Messages_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Transactions", "Messages_ID", "dbo.Messages");
            DropIndex("dbo.Transactions", new[] { "Messages_ID" });
            DropIndex("dbo.Transactions", new[] { "ProductID" });
            DropTable("dbo.Transactions");
        }
    }
}
