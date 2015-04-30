namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactorrelationship : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "ApplicationUser_Id", newName: "ApplicationUserID");
            RenameIndex(table: "dbo.Products", name: "IX_ApplicationUser_Id", newName: "IX_ApplicationUserID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Products", name: "IX_ApplicationUserID", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.Products", name: "ApplicationUserID", newName: "ApplicationUser_Id");
        }
    }
}
