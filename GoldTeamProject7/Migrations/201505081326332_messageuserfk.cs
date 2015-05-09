namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messageuserfk : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "BuyerID", "dbo.AspNetUsers");
            DropIndex("dbo.Products", new[] { "BuyerID" });
            AddColumn("dbo.Messages", "ApplicationUserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Messages", "ApplicationUserID");
            AddForeignKey("dbo.Messages", "ApplicationUserID", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Messages", "SenderID");
            DropColumn("dbo.Products", "BuyerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "BuyerID", c => c.String(maxLength: 128));
            AddColumn("dbo.Messages", "SenderID", c => c.String());
            DropForeignKey("dbo.Messages", "ApplicationUserID", "dbo.AspNetUsers");
            DropIndex("dbo.Messages", new[] { "ApplicationUserID" });
            DropColumn("dbo.Messages", "ApplicationUserID");
            CreateIndex("dbo.Products", "BuyerID");
            AddForeignKey("dbo.Products", "BuyerID", "dbo.AspNetUsers", "Id");
        }
    }
}
