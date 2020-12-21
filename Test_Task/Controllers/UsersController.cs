using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Test_Task.Helpers;
using Test_Task.Models;

namespace Test_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        DataRepository repo;
        public UsersController(DataContext context, DataRepository r)
        {
            _context = context;
            repo = r;
        }

        //GET: api/Users
       [HttpGet]
        public ActionResult<IEnumerable<object>> GetUsers()
        {
            return repo.GetUsers();
        }

        // POST: api/Users
        [HttpPost]
        public ActionResult<List<object>> PostData([FromBody] SQLRequest SQLrequest)
        {
            if( SQLrequest == null)
            {
                return BadRequest();
            }
            var response = repo.RequestCheck(SQLrequest);
            return Ok(response);
        }

    }
}
