namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "DateSent", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "DateSent", c => c.DateTime(nullable: false));
        }
    }
}