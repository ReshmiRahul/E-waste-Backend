using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Recyclia.Model
{
    public class Customer
    {
        [Key]
        public int customer_id { get; set; } 
       
        public string customer_name { get; set; } = string.Empty;
       
        public string customer_address { get; set; }= string.Empty;
        
      
        public string customer_mobile { get; set; } = string.Empty;
       
        public string customer_district { get; set; } = string.Empty;
       
        public string customer_email { get; set; } = string.Empty;
       
        public string customer_username { get; set; } = string.Empty;
       
        public string customer_password { get; set; } = string.Empty;

        [DefaultValue("Not Confirmed")]
        public string Customer_status { get; set; } = string.Empty;
        
    }
}
