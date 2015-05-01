namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeDateSentNotNull : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Messages ALTER COLUMN DateSent DATETIME NOT NULL");
        }
        
        public override void Down()
        {
        }
    }
}
