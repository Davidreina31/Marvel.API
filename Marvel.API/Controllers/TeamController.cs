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
    public class TeamController : Controller
    {
        private readonly ITeamManager _teamManager;

        public TeamController(ITeamManager teamManager)
        {
            _teamManager = teamManager;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> Get()
        {
            return Ok(await _teamManager.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> GetById(Guid id)
        {
            return Ok(await _teamManager.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Team>> Post([FromBody] Team team)
        {
            return Ok(await _teamManager.Add(team));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Team>> Put(Guid id, [FromBody] Team team)
        {
            if (id != team.Id)
                return BadRequest();
            return await _teamManager.Update(team);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Team>> Delete(Guid id)
        {
            return await _teamManager.Delete(id);
        }
    }
}
