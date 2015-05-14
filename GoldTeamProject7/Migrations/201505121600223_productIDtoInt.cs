namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productIDtoInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.messages", "ProductID", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "ProductID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductID", c => c.String());
            AlterColumn("dbo.messages", "ProductID", c => c.String());
        }
    }
}
