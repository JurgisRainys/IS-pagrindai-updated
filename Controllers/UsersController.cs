using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project2.Entities.DataContracts;
using project2.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace project2.Controllers
{

    [Route("api/Users")]
    public class UsersController : Controller
    {
        private readonly UserManager<Vartotojai> _userManager;
        private readonly SignInManager<Vartotojai> _signInManager;
        private readonly AppDbContext _dbContext;

        public UsersController(AppDbContext dbContext, UserManager<Vartotojai> userManager, SignInManager<Vartotojai> signInManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
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
        public async Task<IActionResult> Post([FromBody] RegistrationInfo request)
        {
            Vartotojai vartotojas = new Vartotojai(
                request.Email,
                request.FirstName, 
                request.LastName,
                request.Phone,
                request.Password
            );


            VartotojoTipai basicTipas = new VartotojoTipai();
            basicTipas.Name = "basic-vartotojas";

            //_dbContext.VartotojoTipai.Add(basicTipas);

            vartotojas.TipasNavigation = basicTipas;

            var result = await _userManager.CreateAsync(vartotojas, request.Password);

            _dbContext.Vartotojai.Add(vartotojas);

            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
