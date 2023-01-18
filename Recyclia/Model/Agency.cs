using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Recyclia.Model
{
    public class Agency
    {
        [Key]
        public int agency_id { get; set; }
       
        public string agency_name { get; set; } = String.Empty;
       
        public string agency_address { get; set; } = String.Empty;
       
        public string agency_district { get; set; } = String.Empty;

       
        public string agency_mobile { get; set; } = String.Empty;
        
        public string agency_location { get; set; } = String.Empty;
       
        public string agency_email { get; set; } = String.Empty;
       
        public string agency_username { get; set; } = String.Empty;
        
        public string agency_password { get; set; } = String.Empty;
        [DefaultValue("Not Confirmed")]
        public string agency_status { get; set; }= String.Empty;
    }
}
