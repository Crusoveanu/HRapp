using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.Entity;

namespace hr.Models
{
    [Table("Supliment")]
    public class Supliment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserDetailsId { get; set; }
        //public UserDetails Users { get; set; }
        public int CourseId { get; set; }
        public bool Deleted { get; set; }
        //public Course Course { get; set; }
        public string Seria { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }
        public string Ocupation { get; set; }
        public string Califications { get; set; }
        public string Furnizor { get; set; }
        public string Level { get; set; }
        public string LegalBase { get; set; }
        public string StudyLevel { get; set; }
        public string ProgramType { get; set; }
        public int Hours { get; set; }
        public int Total { get; set; }
        public string TeoreticPreg { get; set; }
        public string PracticPreg { get; set; }
        public string Competences { get; set; }
    }
}
