using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recyclia.Data;
using Recyclia.Model;

namespace Recyclia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public DataContextClass Product { get; set; }
        public ProductController(DataContextClass Productcontext)
        {
            this.Product = Productcontext;
        }
        [HttpPost("insertproduct")]
        public async Task<ActionResult> InsertProduct(Product cu)
        {

            Product.tbl_Product.Add(cu);

            await Product.SaveChangesAsync();

            return Ok(cu);

        }
      
        [HttpGet("ViewProductByid/{id}")]
        public IActionResult ViewProductByid(int id)
        {
            return Ok(Product.tbl_Product.Find(id));
        }
        [HttpPost("updateProduct")]
        public async Task<ActionResult> UpdateProduct(Product cu)
        {
            Product.tbl_Product.Update(cu);
            await Product.SaveChangesAsync();
            return Ok(cu);
        }
        [HttpGet("ViewProduct")]

        public async Task<List<Product>> ViewProduct()

        {

            return Product.tbl_Product.Where(u => u.product_interest == "NotInterested").ToList();

        }
        [HttpGet("ViewInterestedProduct")]

        public async Task<List<Product>> ViewInterestedProduct()

        {

            return Product.tbl_Product.Where(u => u.product_interest == "interested").ToList();

        }
        [HttpPost("deleteProduct")]
        public async Task<ActionResult> DeleteProduct(Product pu)
        {
            Product.tbl_Product.Remove(pu);
            await Product.SaveChangesAsync();
            return Ok(pu);
        }
    }
}
