using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project2.Entities.DataContracts;
using project2.Entities.Models;
using Microsoft.AspNetCore.Authorization;

namespace project2.Controllers
{

    [Route("api/Users")]
    public class UsersController : Controller
    {
        private readonly AppDbContext _dbContext;

        public UsersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Users
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // POST: api/Users/register
        [HttpPost("register")]
        public void Post([FromBody] RegistrationInfo request)
        {
            Vartotojai vartotojas = new Vartotojai(
                request.Email,
                request.FirstName, 
                request.LastName,
                request.Phone, 
                request.Password
            );

            _dbContext.Vartotojai.Add(vartotojas);
        }
    }
}
