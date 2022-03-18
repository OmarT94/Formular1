using Formular1.Server.Data;
using Formular1.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Formular1.Server.Controllers
{
    [Route("api/[controller]")]
    
    public class TeilnehmerController : ControllerBase
    {
        private readonly ApplicationDBContext applicationDBContext;
        public TeilnehmerController(ApplicationDBContext dBContext)
        {
            this.applicationDBContext = dBContext;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var teilnehmer = await applicationDBContext.Teilnehmers.ToListAsync();
            return Ok(teilnehmer);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var teilnehmer = await applicationDBContext.Teilnehmers.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(teilnehmer);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Teilnehmer teilnehmer)
        {
            applicationDBContext.Add(teilnehmer);
            await applicationDBContext.SaveChangesAsync();
            return Ok(teilnehmer.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Teilnehmer teilnehmer)
        {
            applicationDBContext.Entry(teilnehmer).State = EntityState.Modified;
            await applicationDBContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>Delete(int id)
        {
            var teilnehmer = new Teilnehmer { Id = id };
            applicationDBContext.Remove(teilnehmer);
            await applicationDBContext.SaveChangesAsync();
            return NoContent();
        }



    }
}
