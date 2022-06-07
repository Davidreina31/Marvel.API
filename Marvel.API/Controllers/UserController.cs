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
    public class UserController : Controller
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            return Ok(await _userManager.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(Guid id)
        {
            return Ok(await _userManager.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User user)
        {
            return Ok(await _userManager.Add(user));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> Put(Guid id, [FromBody] User user)
        {
            if (id != user.Id)
                return BadRequest();
            return await _userManager.Update(user);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete(Guid id)
        {
            return await _userManager.Delete(id);
        }
    }
}
