namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messageprodFK3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Messages_ID", "dbo.Messages");
            DropIndex("dbo.Products", new[] { "Messages_ID" });
            DropColumn("dbo.Products", "Messages_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Messages_ID", c => c.Int());
            CreateIndex("dbo.Products", "Messages_ID");
            AddForeignKey("dbo.Products", "Messages_ID", "dbo.Messages", "ID");
        }
    }
}
