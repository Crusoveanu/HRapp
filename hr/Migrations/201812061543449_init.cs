namespace hr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Down()
        {
            DropForeignKey("dbo.Supliment", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Supliment", "Users_Id", "dbo.UserDetails");
            DropIndex("dbo.Supliment", new[] { "Course_Id" });
            DropIndex("dbo.Supliment", new[] { "Users_Id" });
            DropTable("dbo.Supliment");
        }
        
        public override void Up()
        {
            CreateTable(
                "dbo.Supliment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserDetailsId = c.Guid(nullable: false),
                        CourseId = c.Guid(nullable: false),
                        Seria = c.String(unicode: false),
                        Type = c.String(unicode: false),
                        Number = c.Int(nullable: false),
                        Ocupation = c.String(unicode: false),
                        Califications = c.String(unicode: false),
                        Furnizor = c.String(unicode: false),
                        Level = c.String(unicode: false),
                        LegalBase = c.String(unicode: false),
                        StudyLevel = c.String(unicode: false),
                        ProgramType = c.String(unicode: false),
                        Hours = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        TeoreticPreg = c.String(unicode: false),
                        PracticPreg = c.String(unicode: false),
                        Competences = c.String(unicode: false),
                        Course_Id = c.Int(),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Supliment", "Users_Id");
            CreateIndex("dbo.Supliment", "Course_Id");
            AddForeignKey("dbo.Supliment", "Users_Id", "dbo.UserDetails", "Id");
            AddForeignKey("dbo.Supliment", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
