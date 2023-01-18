
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Recyclia.Model
{
    public class ewaste
    {
        [Key]
        public int ewaste_id { get; set; }
        public int customer_id { get; set; }
        public string customer_name { get; set; } = string.Empty;
        public string customer_district { get; set; } = string.Empty;
        public string customer_phone { get; set; } = string.Empty;
        public string ewaste_type { get; set; } = string.Empty;
        public string ewaste_description { get; set; } = string.Empty;
        [DefaultValue("Not Cleared")]
        public string ewaste_status { get; set; } = string.Empty;
        [DefaultValue(0.00)]
        public float ewaste_perkilo_Rs { get; set; }
        [DefaultValue(0.00)]
        public float ewaste_kilo { get; set; }
        [DefaultValue(0.00)]
        public float ewaste_wallet { get; set; }
        public string dates {get;set;}=string.Empty;
              

    }
}
