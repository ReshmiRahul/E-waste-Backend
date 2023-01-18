using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recyclia.Data;
using Recyclia.Model;

namespace Recyclia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EwasteController : ControllerBase
    {
        public DataContextClass Ewaste { get; set; }
        public EwasteController(DataContextClass Ewastecontext)
        {
            this.Ewaste = Ewastecontext;
        }
        [HttpPost("insertEwaste")]

        public async Task<ActionResult> InsertEwaste(ewaste cu)

        {

            Ewaste.tbl_Ewaste.Add(cu);

            await Ewaste.SaveChangesAsync();

            return Ok(cu);

        }
        [HttpGet("viewEwaste")]

        public async Task<List<ewaste>> ViewEwaste()

        {

            return Ewaste.tbl_Ewaste.Where(u => u.ewaste_status == "Not Cleaned").ToList();

        }
        [HttpGet("ViewDustbinByid/{id}")]
        public IActionResult ViewDustbinByid(int id)
        {
            return Ok(Ewaste.tbl_Ewaste.Find(id));
        }
        [HttpPost("updateDustbin")]
        public async Task<ActionResult> updateDustbin(ewaste cu)
        {
            Ewaste.tbl_Ewaste.Update(cu);
            await Ewaste.SaveChangesAsync();
            return Ok(cu);
        }
        [HttpGet("viewEwasteDetails")]

        public async Task<List<ewaste>> viewEwasteDetails()

        {

            return Ewaste.tbl_Ewaste.Where(u => u.ewaste_status == "Cleaned").ToList();

        }
        [HttpGet("CancelEwasteDetails")]

        public async Task<List<ewaste>> CancelEwasteDetails()

        {

            return Ewaste.tbl_Ewaste.Where(u => u.ewaste_status == "Not Cleaned").ToList();

        }
    }
}
