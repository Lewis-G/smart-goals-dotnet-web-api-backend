using Microsoft.AspNetCore.Mvc;
using smart_goals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_goals.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            return Ok();
        }

        [HttpGet("enabled")]
        public ActionResult<IEnumerable<User>> GetAllEnabledUsers()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetUser(int id)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult AddUser([FromBody] User user)
        {
            return Ok();
        }

    }
}
