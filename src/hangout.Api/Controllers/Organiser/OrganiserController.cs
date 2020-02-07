using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hangout.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrganiserController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return " ryan's butt";
        }

        /*[HttpPost]
        public async Task<IActionResult> Create(Guid organiserId, [FromBody] CreateOrganiserDto dto)
        {
            await 
        }*/
    }
}