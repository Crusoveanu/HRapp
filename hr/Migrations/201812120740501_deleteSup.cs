namespace hr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteSup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supliment", "Deleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Supliment", "Deleted");
        }
    }
}
