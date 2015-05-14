namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messages : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "Product_ID", "dbo.Products");
            DropIndex("dbo.Messages", new[] { "Product_ID" });
            DropColumn("dbo.Messages", "Product_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "Product_ID", c => c.Int());
            CreateIndex("dbo.Messages", "Product_ID");
            AddForeignKey("dbo.Messages", "Product_ID", "dbo.Products", "ID");
        }
    }
}
