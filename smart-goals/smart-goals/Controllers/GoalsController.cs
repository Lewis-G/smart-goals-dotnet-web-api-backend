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

    public class GoalsController : ControllerBase
    {

        [HttpGet("/user/{id}")]
        public ActionResult<IEnumerable<User>> GetAllGoalsByUserID([FromRoute] int id)
        {
            return Ok();
        }

        [HttpGet("/priority/{level}")]
        public ActionResult<IEnumerable<User>> GetAllGoalsByPriorityLevel([FromRoute] int level)
        {
            return Ok();
        }

        [HttpGet("/tags/{tag}")]
        public ActionResult<IEnumerable<User>> GetAllGoalsByTag([FromRoute] string tag)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult AddGoal([FromBody] Goal goal)
        {
            return Ok();
        }

    }
}
