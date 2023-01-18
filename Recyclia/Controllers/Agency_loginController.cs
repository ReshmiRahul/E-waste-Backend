using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using Recyclia.Data;
using Recyclia.Model;

namespace Recyclia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Agency_loginController : ControllerBase
    {
        public DataContextClass UserLogin { get; set; }
        public Agency_loginController(DataContextClass logincontext)
        {
            this.UserLogin = logincontext;
        }
        [HttpPost("login")]
        public IActionResult Login(Agency us)
        {
            var userAvailable = UserLogin.tbl_Agency.Where(u => u.agency_username == us.agency_username && u.agency_password == us.agency_password && u.agency_status=="Confirmed").FirstOrDefault();
            if (userAvailable != null)
            {
                return Ok(userAvailable);
            }
            return Ok("Failed");
        }
        [HttpPost("logincustomer")]
        public IActionResult Logincustomer(Customer us)
        {
            var userAvailable = UserLogin.tbl_Customer.Where(u => u.customer_username == us.customer_username && u.customer_password == us.customer_password && u.Customer_status == "Confirmed").FirstOrDefault();
            if (userAvailable != null)
            {
                return Ok(userAvailable);
            }
            return Ok("Failed");
        }
        [HttpGet("GetAgencyId")]
        public async Task<ActionResult> GetAgencyId(string username)
        {
            var agency=UserLogin.tbl_Agency.Where(c=>c.agency_name.Equals(username)).First();
            return Ok(agency);
        }
        [HttpGet("GetCustomerId")]
        public async Task<ActionResult> GetCustomerId(string username)
        {
            var customer = UserLogin.tbl_Customer.Where(c => c.customer_name.Equals(username)).First();
            return Ok(customer);
        }
    }
}
