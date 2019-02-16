namespace hr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Supliment",
                c => new
                    {
                        Id = c.Guid(nullable: false),
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.UserDetails", t => t.UserDetailsId, cascadeDelete: true)
                .Index(t => t.UserDetailsId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StartDate = c.DateTime(nullable: false, precision: 0),
                        EndDate = c.DateTime(nullable: false, precision: 0),
                        Duration = c.Int(nullable: false),
                        Ocupation = c.String(unicode: false),
                        COR = c.Int(nullable: false),
                        OrganizedBy = c.String(unicode: false),
                        LocationCounty = c.String(unicode: false),
                        County = c.String(unicode: false),
                        RegistrationNumber = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ExamDate = c.DateTime(nullable: false, precision: 0),
                        MarkEx = c.String(unicode: false),
                        EliberationNumber = c.Int(),
                        EliberationDate = c.DateTime(precision: 0),
                        Course_Id = c.Guid(),
                        Users_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .ForeignKey("dbo.UserDetails", t => t.Users_Id)
                .Index(t => t.Course_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CNP = c.String(unicode: false),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        FullName = c.String(unicode: false),
                        BirthDay = c.DateTime(nullable: false, precision: 0),
                        City = c.String(unicode: false),
                        County = c.String(unicode: false),
                        Country = c.String(unicode: false),
                        FatherName = c.String(unicode: false),
                        MotherName = c.String(unicode: false),
                        Gender = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                        Email = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Signatures",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SignaturePath = c.String(unicode: false),
                        SignatureType = c.String(unicode: false),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        FullName = c.String(unicode: false),
                        Course_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CountryName = c.String(unicode: false),
                        CountryCode = c.String(unicode: false),
                        LanguageId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false, precision: 0),
                        UpdateDate = c.DateTime(precision: 0),
                        InsertUserId = c.Int(nullable: false),
                        UpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Language", t => t.LanguageId, cascadeDelete: true)
                .Index(t => t.LanguageId);
            
            CreateTable(
                "dbo.Language",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LanguageName = c.String(unicode: false),
                        LanguageCode = c.String(unicode: false),
                        Deleted = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false, precision: 0),
                        UpdateDate = c.DateTime(precision: 0),
                        InsertUserId = c.Int(nullable: false),
                        UpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LoginUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Domain = c.String(unicode: false),
                        UserName = c.String(nullable: false, unicode: false),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        FullName = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        CountryId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        ProfileId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false, precision: 0),
                        UpdateDate = c.DateTime(precision: 0),
                        InsertUserId = c.Int(nullable: false),
                        UpdateUserId = c.Int(),
                        Country_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Country", t => t.Country_Id)
                .ForeignKey("dbo.Profile", t => t.ProfileId, cascadeDelete: true)
                .Index(t => t.ProfileId)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfileName = c.String(unicode: false),
                        Deleted = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false, precision: 0),
                        UpdateDate = c.DateTime(precision: 0),
                        InsertUserId = c.Int(nullable: false),
                        UpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfileAccess",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfileId = c.Int(nullable: false),
                        SectionId = c.Int(nullable: false),
                        Visible = c.Boolean(nullable: false),
                        Enable = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false, precision: 0),
                        UpdateDate = c.DateTime(precision: 0),
                        InsertUserId = c.Int(nullable: false),
                        UpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profile", t => t.ProfileId, cascadeDelete: true)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Section",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionName = c.String(unicode: false),
                        Deleted = c.Boolean(nullable: false),
                        InsertDate = c.DateTime(nullable: false, precision: 0),
                        UpdateDate = c.DateTime(precision: 0),
                        InsertUserId = c.Int(nullable: false),
                        UpdateUserId = c.Int(),
                        ProfileAccesses_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProfileAccess", t => t.ProfileAccesses_Id)
                .Index(t => t.ProfileAccesses_Id);
            
            CreateTable(
                "dbo.UserDetailsCourse",
                c => new
                    {
                        UserDetails_Id = c.Guid(nullable: false),
                        Course_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserDetails_Id, t.Course_Id })
                .ForeignKey("dbo.UserDetails", t => t.UserDetails_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.UserDetails_Id)
                .Index(t => t.Course_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Section", "ProfileAccesses_Id", "dbo.ProfileAccess");
            DropForeignKey("dbo.LoginUser", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.ProfileAccess", "ProfileId", "dbo.Profile");
            DropForeignKey("dbo.LoginUser", "Country_Id", "dbo.Country");
            DropForeignKey("dbo.Country", "LanguageId", "dbo.Language");
            DropForeignKey("dbo.Supliment", "UserDetailsId", "dbo.UserDetails");
            DropForeignKey("dbo.Supliment", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Signatures", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Exams", "Users_Id", "dbo.UserDetails");
            DropForeignKey("dbo.UserDetailsCourse", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.UserDetailsCourse", "UserDetails_Id", "dbo.UserDetails");
            DropForeignKey("dbo.Exams", "Course_Id", "dbo.Courses");
            DropIndex("dbo.UserDetailsCourse", new[] { "Course_Id" });
            DropIndex("dbo.UserDetailsCourse", new[] { "UserDetails_Id" });
            DropIndex("dbo.Section", new[] { "ProfileAccesses_Id" });
            DropIndex("dbo.ProfileAccess", new[] { "ProfileId" });
            DropIndex("dbo.LoginUser", new[] { "Country_Id" });
            DropIndex("dbo.LoginUser", new[] { "ProfileId" });
            DropIndex("dbo.Country", new[] { "LanguageId" });
            DropIndex("dbo.Signatures", new[] { "Course_Id" });
            DropIndex("dbo.Exams", new[] { "Users_Id" });
            DropIndex("dbo.Exams", new[] { "Course_Id" });
            DropIndex("dbo.Supliment", new[] { "CourseId" });
            DropIndex("dbo.Supliment", new[] { "UserDetailsId" });
            DropTable("dbo.UserDetailsCourse");
            DropTable("dbo.Section");
            DropTable("dbo.ProfileAccess");
            DropTable("dbo.Profile");
            DropTable("dbo.LoginUser");
            DropTable("dbo.Language");
            DropTable("dbo.Country");
            DropTable("dbo.Signatures");
            DropTable("dbo.UserDetails");
            DropTable("dbo.Exams");
            DropTable("dbo.Courses");
            DropTable("dbo.Supliment");
        }
    }
}
