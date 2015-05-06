namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductIDToMessages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "ProductID", c => c.Int(nullable: false));
            CreateIndex("dbo.Messages", "ProductID");
            AddForeignKey("dbo.Messages", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "ProductID", "dbo.Products");
            DropIndex("dbo.Messages", new[] { "ProductID" });
            DropColumn("dbo.Messages", "ProductID");
        }
    }
}
