using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recyclia.Data;
using Recyclia.Model;

namespace Recyclia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {
        public DataContextClass Agency { get; set; }
        public AgencyController(DataContextClass Agencycontext)
        {
            this.Agency = Agencycontext;
        }
        [HttpPost("insertAgency")]

        public async Task<ActionResult> InsertAgency(Agency cu)

        {

            Agency.tbl_Agency.Add(cu);

            await Agency.SaveChangesAsync();

            return Ok(cu);

        }
        [HttpGet("viewAgency")]

        public async Task<List<Agency>> ViewAgency()

        {

            return Agency.tbl_Agency.ToList();

        }
        [HttpGet("viewAgencies")]

        public async Task<List<Agency>> ViewAgencies(Agency cu)

        {

            if (cu.agency_status == "Not Confirmed")
            {
                return Agency.tbl_Agency.ToList();
            }
            else
            {
                return Agency.tbl_Agency.ToList();
            }
        }

        [HttpGet("ViewAgencyByid/{id}")]
        public IActionResult ViewProductByid(int id)
        {
            return Ok(Agency.tbl_Agency.Find(id));
        }

        [HttpPost("updateAgency")]
        public async Task<ActionResult> UpdateProduct(Agency cu)
        {
            Agency.tbl_Agency.Update(cu);
            await Agency.SaveChangesAsync();
            return Ok(cu);
        }
        [HttpPost("deleteAgency")]
        public async Task<ActionResult> DeleteAgency(Agency pu)
        {
            Agency.tbl_Agency.Remove(pu);
            await Agency.SaveChangesAsync();
            return Ok(pu);
        }

       

        [HttpGet("ViewMyAgencies")]
        public IActionResult Get(string district)
        {
            var agencies = Agency.tbl_Agency.AsQueryable();

            if (!string.IsNullOrEmpty(district))
            {
                agencies = agencies.Where(a => a.agency_district == district);
            }

            return Ok(agencies.ToList());
        }
        [HttpGet("ViewMyCustomer")]
        public async Task<ActionResult> ViewMyCustomer(int id)
        {
            var customers = from c in Agency.tbl_Agency
                                   join a in Agency.tbl_Customer
                                   on c.agency_district equals a.customer_district
                                   where c.agency_id == id
                                   select a;
            if(customers == null)
            {
                return NotFound();
            }
            return Ok(await customers.ToListAsync());
        }
        [HttpGet("ViewMyCustomerRequests")]
        public async Task<ActionResult> ViewMyCustomerRequests(int id)
        {
            var customers = from c in Agency.tbl_Agency
                            join a in Agency.tbl_Ewaste
                            on c.agency_district equals a.customer_district
                            where ((c.agency_id == id) && (a.ewaste_status == "Not Cleaned"))
                            select a;
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(await customers.ToListAsync());
        }
        [HttpGet("ViewMyCustomerComplaints")]
        public async Task<ActionResult> ViewMyCustomerComplaints(int id)
        {
            var customers = from c in Agency.tbl_Agency
                            join a in Agency.tbl_Complaints
                            on c.agency_district equals a.customer_district
                            where ((c.agency_id == id)&&(a.complaint_status=="Not Solved"))
                            select a;
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(await customers.ToListAsync());
        }
        [HttpGet("ViewAgencyProfile")]
        public async Task<ActionResult> ViewAgencyProfile(int id)
        {
            var customers = from c in Agency.tbl_Agency
                          
                            where (c.agency_id == id) 
                            select c;
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(await customers.ToListAsync());
        }
        [HttpGet("ViewMyCustomerFoodWasteRequests")]
        public async Task<ActionResult> ViewMyCustomerFoodWasteRequests(int id)
        {
            var customers = from c in Agency.tbl_Agency
                            join a in Agency.tbl_foodwaste
                            on c.agency_district equals a.customer_district
                            where c.agency_id == id
                            select a;
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(await customers.ToListAsync());
        }
    }

}


