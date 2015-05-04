namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transactiontime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "Created", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "Created", c => c.DateTime());
        }
    }
}
