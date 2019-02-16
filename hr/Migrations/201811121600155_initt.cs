namespace hr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CourseName", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "CourseName");
        }
    }
}
