namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBuyerIDToProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "BuyerID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Products", "BuyerID");
            AddForeignKey("dbo.Products", "BuyerID", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "BuyerID", "dbo.AspNetUsers");
            DropIndex("dbo.Products", new[] { "BuyerID" });
            DropColumn("dbo.Products", "BuyerID");
        }
    }
}
