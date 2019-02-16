using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr.Models
{
    public class ProfileAccess
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int SectionId { get; set; }
        public bool Visible { get; set; }
        public bool Enable { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int InsertUserId { get; set; }
        public int? UpdateUserId { get; set; }

        public Profile Profile { get; set; }
        //public Section Section { get; set; }
    }
}
