using hr.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace hr
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class AppContext : DbContext
    {
        public AppContext()
            :base("DefaultConnection")
        { }
        public DbSet<UserDetails> Details { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Supliment> Supliments { get; set; }

        public DbSet<LoginUser> LoginUsers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention> ();
        }
    }
}
