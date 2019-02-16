namespace hr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class suplimentA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
    "dbo.Supliment",
    c => new
    {
        Id = c.Int(nullable: false, identity: true),
        UserDetailsId = c.Int(nullable: false),
        CourseId = c.Int(nullable: false),
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
                    //Course_Id = c.Int(),
                    //Users_Id = c.Int(),
                })
    .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
        }
    }
}
