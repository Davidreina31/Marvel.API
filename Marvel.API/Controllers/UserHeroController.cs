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
    public class UserHeroController : Controller
    {
        private readonly IUserHeroManager _userHeroManager;

        public UserHeroController(IUserHeroManager userHeroManager)
        {
            _userHeroManager = userHeroManager;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User_Hero>>> Get()
        {
            return Ok(await _userHeroManager.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User_Hero>> GetById(Guid id)
        {
            return Ok(await _userHeroManager.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<User_Hero>> Post([FromBody] User_Hero userHero)
        {
            return Ok(await _userHeroManager.Add(userHero));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult<User_Hero>> Put(Guid id, [FromBody] User_Hero userHero)
        {
            if (id != userHero.Id)
                return BadRequest();
            return await _userHeroManager.Update(userHero);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User_Hero>> Delete(Guid id)
        {
            return await _userHeroManager.Delete(id);
        }
    }
}
