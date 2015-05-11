namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetransactionview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductID");
        }
    }
}
