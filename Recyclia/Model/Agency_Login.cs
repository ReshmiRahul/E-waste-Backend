using System.ComponentModel.DataAnnotations;

namespace Recyclia.Model
{
    public class Agency_Login
    {
         [Key]
        public int Id { get; set; }
        public string agency_username { get; set; }=String.Empty;
        public string agency_password { get; set; } = String.Empty;   
    }
}
