namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixproductuserid : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "SellerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "SellerID", c => c.String());
        }
    }
}
