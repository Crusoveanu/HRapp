using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr.Models
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public bool Deleted { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public string Ocupation { get; set; }
        public int COR { get; set; }
        public string OrganizedBy { get; set; }
        public string LocationCounty { get; set; }
        public string County { get; set; }
        public int? RegistrationNumber { get; set; }
        public ICollection<UserDetails> Users { get; set; }
        public ICollection<Exam> Exams { get; set; }
        public ICollection<Signature> Signs { get; set; }
    }
}
