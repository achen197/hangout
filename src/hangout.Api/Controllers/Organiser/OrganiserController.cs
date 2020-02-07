using System.Collections.Generic;
using hangout.Domain;
using Microsoft.AspNetCore.Mvc;

namespace hangout.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrganiserController : ControllerBase
    {
        private readonly HangoutDbContext _dbContext;

        public OrganiserController(HangoutDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IEnumerable<Organiser> GetOrganisers()
        {
            return _dbContext.Organiser;
        }

        /*[HttpPost]
        public async Task<IActionResult> Create(Guid organiserId, [FromBody] CreateOrganiserDto dto)
        {
            await 
        }*/
    }
}