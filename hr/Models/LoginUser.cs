using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr.Models
{
    public class LoginUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Domain { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is Required")]
        public string UserName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }
        public int CountryId { get; set; }
        [Display(Name = "Default Location")]
        public int LocationId { get; set; }

        [Display(Name = "Profile Access")]
        public int ProfileId { get; set; }
        //public string Token { get; set; }

        public bool Deleted { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int InsertUserId { get; set; }
        public int? UpdateUserId { get; set; }

        public Country Country { get; set; }
        public Profile Profile { get; set; }
    }
}
