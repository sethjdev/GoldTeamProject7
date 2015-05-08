namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppUserinMessages : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "ProductID", "dbo.Products");
            DropIndex("dbo.Messages", new[] { "ProductID" });
            AddColumn("dbo.Messages", "ApplicationUserID", c => c.String(maxLength: 128));
            AddColumn("dbo.Messages", "Product_ID", c => c.Int());
            AlterColumn("dbo.Messages", "ProductID", c => c.String());
            CreateIndex("dbo.Messages", "ApplicationUserID");
            CreateIndex("dbo.Messages", "Product_ID");
            AddForeignKey("dbo.Messages", "ApplicationUserID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Messages", "Product_ID", "dbo.Products", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.Messages", "ApplicationUserID", "dbo.AspNetUsers");
            DropIndex("dbo.Messages", new[] { "Product_ID" });
            DropIndex("dbo.Messages", new[] { "ApplicationUserID" });
            AlterColumn("dbo.Messages", "ProductID", c => c.Int(nullable: false));
            DropColumn("dbo.Messages", "Product_ID");
            DropColumn("dbo.Messages", "ApplicationUserID");
            CreateIndex("dbo.Messages", "ProductID");
            AddForeignKey("dbo.Messages", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
        }
    }
}
