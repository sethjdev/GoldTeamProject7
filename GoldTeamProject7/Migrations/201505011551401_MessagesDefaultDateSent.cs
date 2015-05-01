namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessagesDefaultDateSent : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Messages ADD CONSTRAINT C_Messages_DateSent DEFAULT GETDATE() FOR DateSent");
        }
        
        public override void Down()
        {
        }
    }
}
