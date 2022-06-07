using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marvel.BLL.Interfaces.Managers;
using Marvel.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Marvel.API.Controllers
{
    [Route("api/[controller]")]
    public class HeroController : Controller
    {
        private readonly IHeroManager _heroManager;

        public HeroController(IHeroManager heroManager)
        {
            _heroManager = heroManager;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hero>>> Get()
        {
            return Ok(await _heroManager.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hero>> GetById(Guid id)
        {
            return Ok(await _heroManager.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Hero>> Post([FromBody] Hero hero)
        {
            return Ok(await _heroManager.Add(hero));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Hero>> Put(Guid id, [FromBody] Hero hero)
        {
            if (id != hero.Id)
                return BadRequest();
            return await _heroManager.Update(hero);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hero>> Delete(Guid id)
        {
            return await _heroManager.Delete(id);
        }
    }
}
