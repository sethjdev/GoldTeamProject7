namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmessages : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "ApplicationUserID", "dbo.AspNetUsers");
            DropIndex("dbo.messages", new[] { "ApplicationUserID" });
            AlterColumn("dbo.messages", "ApplicationUserID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.messages", "ApplicationUserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.messages", "ApplicationUserID");
            AddForeignKey("dbo.Messages", "ApplicationUserID", "dbo.AspNetUsers", "Id");
        }
    }
}
