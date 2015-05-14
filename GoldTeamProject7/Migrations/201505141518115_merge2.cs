namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class merge2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "ApplicationUserID", "dbo.AspNetUsers");
            DropIndex("dbo.Messages", new[] { "ApplicationUserID" });
            AddColumn("dbo.Messages", "TransactionID", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "oldMessages", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "TransactionID", c => c.String(nullable: false));
            AlterColumn("dbo.Messages", "ApplicationUserID", c => c.String());
            DropColumn("dbo.Messages", "RecipientID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "RecipientID", c => c.String());
            AlterColumn("dbo.Messages", "ApplicationUserID", c => c.String(maxLength: 128));
            DropColumn("dbo.Products", "TransactionID");
            DropColumn("dbo.AspNetUsers", "oldMessages");
            DropColumn("dbo.Messages", "TransactionID");
            CreateIndex("dbo.Messages", "ApplicationUserID");
            AddForeignKey("dbo.Messages", "ApplicationUserID", "dbo.AspNetUsers", "Id");
        }
    }
}
