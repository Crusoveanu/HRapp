using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr.Models
{
    [Table("Exams")]
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public Course Course { get; set; }
        public UserDetails Users { get; set; }
        public DateTime ExamDate { get; set; }
        public string MarkEx { get; set; }
        public int? EliberationNumber { get; set; }
        public DateTime? EliberationDate { get; set; }
        
    }
}
