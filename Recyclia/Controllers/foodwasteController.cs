using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recyclia.Data;

namespace Recyclia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class foodwasteController : ControllerBase
    {
        public DataContextClass Ewaste { get; set; }
        public foodwasteController(DataContextClass foodwastecontext)
        {
            this.Ewaste = foodwastecontext;
        }
    }
}
