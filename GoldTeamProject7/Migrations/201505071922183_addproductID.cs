namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addproductID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "ProductID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "ProductID");
        }
    }
}
