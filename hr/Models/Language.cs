using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr.Models
{
    public class Language
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string LanguageName { get; set; }
        public string LanguageCode { get; set; }
        public bool Deleted { get; set; }

        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int InsertUserId { get; set; }
        public int? UpdateUserId { get; set; }
    }
}
