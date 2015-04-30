namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsellid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SellerID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "SellerID");
        }
    }
}
