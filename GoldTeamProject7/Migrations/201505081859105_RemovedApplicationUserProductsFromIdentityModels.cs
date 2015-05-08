namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedApplicationUserProductsFromIdentityModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "ApplicationUserProducts_ID", "dbo.Products");
            DropIndex("dbo.AspNetUsers", new[] { "ApplicationUserProducts_ID" });
            DropColumn("dbo.AspNetUsers", "ApplicationUserProducts_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "ApplicationUserProducts_ID", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "ApplicationUserProducts_ID");
            AddForeignKey("dbo.AspNetUsers", "ApplicationUserProducts_ID", "dbo.Products", "ID");
        }
    }
}
