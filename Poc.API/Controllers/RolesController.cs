using Microsoft.AspNetCore.Mvc;
using Poc.Dal.Interfaces;
using Poc.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Poc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly ICommonRepository<Role> _repository;

        public RolesController(ICommonRepository<Role> repository)
        {
            _repository = repository;
        }

        // GET: api/<RolesController>
        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return _repository.GetAll();
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public Role Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/<RolesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}