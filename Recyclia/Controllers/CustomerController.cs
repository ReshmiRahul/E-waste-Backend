using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recyclia.Data;
using Recyclia.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.ContentModel;
using NuGet.Protocol.Plugins;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using System;

namespace Recyclia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public DataContextClass Customer { get; set; }
        public CustomerController(DataContextClass Customercontext)
        {
            this.Customer = Customercontext;
        }
        [HttpPost("insertCustomer")]

        public async Task<ActionResult> InsertCustomer(Customer cu)

        {

            Customer.tbl_Customer.Add(cu);

            await Customer.SaveChangesAsync();

            return Ok(cu);

        }
        [HttpGet("ViewCustomer")]

        public async Task<List<Customer>> ViewCustomer()

        {

            return Customer.tbl_Customer.ToList();

        }
        [HttpGet("ViewCustomerByid/{id}")]
        public IActionResult ViewCustomerByid(int id)
        {
            return Ok(Customer.tbl_Customer.Find(id));
        }
        [HttpPost("UpdateCustomer")]
        public IActionResult UpdateCustomer(Customer cu)
        {
            Customer.tbl_Customer.Update(cu);
            Customer.SaveChanges();
            return Ok(cu);
        }
        [HttpPost("deleteCustomer")]
        public async Task<ActionResult> deleteCustomer(Customer pu)
        {
            Customer.tbl_Customer.Remove(pu);
            await Customer.SaveChangesAsync();
            return Ok(pu);
        }
        [HttpGet("ViewMyAgency")]
        public async Task<ActionResult> ViewMyAgency(int id)
        {
            var customers = from c in Customer.tbl_Agency
                            join a in Customer.tbl_Customer
                            on c.agency_district equals a.customer_district
                            where a.customer_id == id
                            select c;
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(await customers.ToListAsync());
        }
        [HttpGet("ViewCustomerProfile")]
        public async Task<ActionResult> ViewCustomerProfile(int id)
        {
            var customers = from c in Customer.tbl_Customer

                            where (c.customer_id == id)
                            select c;
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(await customers.ToListAsync());
        }
        [HttpGet("ViewMyWallet")]
        public async Task<ActionResult> ViewMyWallet(int id)
        {
            var customers = from c in Customer.tbl_Customer
                            join a in Customer.tbl_Ewaste
                            on c.customer_id equals a.customer_id
                            where c.customer_id == id
                            select a;
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(await customers.ToListAsync());
        }
        [HttpGet("ViewMyRequests")]
        public async Task<ActionResult> ViewMyRequests(int id)
        {
            var customers = from c in Customer.tbl_Customer
                            join a in Customer.tbl_Ewaste
                            on c.customer_id equals a.customer_id
                            where ((c.customer_id == id )&& (a.ewaste_status== "Not cleaned"))
                            select a;
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(await customers.ToListAsync());
        }
        [HttpGet("ViewMyComplaints")]
        public async Task<ActionResult> ViewMyComplaints(int id)
        {
            var customers = from c in Customer.tbl_Customer
                            join a in Customer.tbl_Complaints
                            on c.customer_id equals a.customer_id
                            where c.customer_id == id
                            select a;
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(await customers.ToListAsync());
        }
    }
}