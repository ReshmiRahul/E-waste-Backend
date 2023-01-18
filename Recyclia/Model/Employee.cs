using System.ComponentModel.DataAnnotations;

namespace Recyclia.Model
{
    public class Employee
    {
        [Key]
        public int employee_id { get; set; }
        [Required(ErrorMessage = "Please enter Name")]
        [StringLength(100)]
        public string employee_name { get; set; }
        [Required(ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Mobile Number")]

        [Phone]
        public string employee_mobile { get; set; }
        [Required(ErrorMessage = "Please enter email address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string employee_email { get; set; }
        [Required(ErrorMessage = "Choose Agency Name")]
        
        public string agency_name { get; set; }
        [Required(ErrorMessage = "Please enter Username")]
        [StringLength(100)]
        public string employee_username { get; set; }
        [Required(ErrorMessage = "Please enter Password")]
        [DataType(DataType.Password)]
        public string employee_password { get; set; }
    }
}
