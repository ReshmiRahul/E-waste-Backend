using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recyclia.Data;
using Recyclia.Model;

namespace Recyclia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class foodwasteController : ControllerBase
    {
        public DataContextClass foodwaste { get; set; }
        public foodwasteController(DataContextClass foodwastecontext)
        {
            this.foodwaste = foodwastecontext;
        }
        [HttpPost("insertFoodWaste")]

        public async Task<ActionResult> insertFoodWaste(foodwaste cu)

        {

            foodwaste.tbl_foodwaste.Add(cu);

            await foodwaste.SaveChangesAsync();

            return Ok(cu);

        }
        [HttpGet("viewfoodwaste")]

        public async Task<List<foodwaste>> Viewfoodwaste()

        {

            return foodwaste.tbl_foodwaste.ToList();

        }
        [HttpGet("ViewfoodwasteByid/{id}")]
        public IActionResult ViewfoodwasteByid(int id)
        {
            return Ok(foodwaste.tbl_foodwaste.Find(id));
        }
        [HttpPost("deleteFoodwaste")]
        public async Task<ActionResult> deleteCustomer(foodwaste pu)
        {
            foodwaste.tbl_foodwaste.Remove(pu);
            await foodwaste.SaveChangesAsync();
            return Ok(pu);
        }
    }
}
