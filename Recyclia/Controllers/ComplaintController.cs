using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Recyclia.Data;
using Recyclia.Model;

namespace Recyclia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintController : ControllerBase
    {

        public DataContextClass Complaints { get; set; }
        public ComplaintController(DataContextClass Complaintscontext)
        {
            this.Complaints = Complaintscontext;
        }
        [HttpPost("insertComplaints")]

        public async Task<ActionResult> InsertComplaints(Complaints cu)

        {

            Complaints.tbl_Complaints.Add(cu);

            await Complaints.SaveChangesAsync();

            return Ok(cu);

        }
        [HttpGet("viewComplaints")]

        public IActionResult viewComplaints()

        {
            var cu = Complaints.tbl_Complaints.Where(u => u.complaint_status == "Not Solved").ToList();

            return Ok(cu);

        }
        [HttpGet("ViewComplaintsByid/{id}")]
        public IActionResult ViewComplaintsByid(int id)
        {
            return Ok(Complaints.tbl_Complaints.Find(id));
        }

        [HttpPost("updateComplaints")]
        public async Task<ActionResult> UpdateComplaints(Complaints cu)
        {
            Complaints.tbl_Complaints.Update(cu);
            await Complaints.SaveChangesAsync();
            return Ok(cu);
        }

    }
}
    

