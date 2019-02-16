namespace hr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class liviu1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "RegistrationNumber", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "RegistrationNumber", c => c.Int(nullable: false));
        }
    }
}
