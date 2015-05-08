namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class senderreceiver : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "SenderID", c => c.String());
            AddColumn("dbo.Messages", "RecipientID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "RecipientID");
            DropColumn("dbo.Messages", "SenderID");
        }
    }
}
