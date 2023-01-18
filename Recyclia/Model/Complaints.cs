using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Recyclia.Model
{
    public class Complaints
    {
        [Key]
        public int complaint_id { get; set; }
        public int customer_id { get; set; }
        public string dates { get; set; } = string.Empty;

        public string customer_name { get; set; } = string.Empty;

        public string customer_district { get; set; } = string.Empty;


        public string customer_mobile { get; set; } = string.Empty;

        public string complaint_topic { get; set; } = string.Empty;

        public string complaint_description { get; set; } = string.Empty;
       
        [DefaultValue("Not Solved")]

        public string complaint_status { get; set; } = string.Empty;
    }
}
