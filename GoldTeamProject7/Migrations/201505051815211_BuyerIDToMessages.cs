namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BuyerIDToMessages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "BuyerID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Messages", "BuyerID");
            AddForeignKey("dbo.Messages", "BuyerID", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "BuyerID", "dbo.AspNetUsers");
            DropIndex("dbo.Messages", new[] { "BuyerID" });
            DropColumn("dbo.Messages", "BuyerID");
        }
    }
}
