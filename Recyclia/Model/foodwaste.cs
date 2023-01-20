using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Recyclia.Model
{
    public class foodwaste
    {
        [Key]
        public int fud_id { get; set; }
        public float fud_pay { get; set; } 
        public string dates { get; set; } = string.Empty;
        public int customer_id { get; set; }
        public string customer_name { get; set; } = string.Empty;
        public string customer_district { get; set; } = string.Empty;
        public string customer_phone { get; set; } = string.Empty;
    }
}
