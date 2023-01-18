using System.ComponentModel.DataAnnotations;

namespace Recyclia.Model
{
    public class Product
    {
     
            [Key]
            public int product_id { get; set; }
        
        public string customer_name { get; set; } = String.Empty;
            public string customer_address { get; set; } = String.Empty;
            public string customer_mobile { get; set; } = String.Empty;
            public string product_name { get; set; } = String.Empty;
            public string product_description { get; set; }= String.Empty;
            public string product_price { get; set; } = String.Empty;
        public string product_photo { get; set; } = String.Empty;

        public string product_interest { get; set; } = String.Empty;
            public string product_rply { get; set; } = String.Empty;

    }
}
