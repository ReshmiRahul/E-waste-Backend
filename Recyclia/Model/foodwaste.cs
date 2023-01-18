using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Recyclia.Model
{
    public class foodwaste
    {
        [Key]
        public int fud_id { get; set; }
        public float fud_pay { get; set; }
    }
}
