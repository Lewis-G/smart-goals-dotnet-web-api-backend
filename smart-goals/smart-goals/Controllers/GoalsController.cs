using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using smart_goals.DTOs;
using smart_goals.Validators;
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

        private IValidator<GoalDTO> _validator;

        public GoalsController(IValidator<GoalDTO> validator)
        {
            _validator = validator;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GoalDTO>> GetAllGoals()
        {
            return Ok();
        }

        [HttpGet("/priority/{level}")]
        public ActionResult<IEnumerable<GoalDTO>> GetAllGoalsByPriorityLevel([FromRoute] int level)
        {
            return Ok();
        }

        [HttpGet("/tags/{tag}")]
        public ActionResult<IEnumerable<GoalDTO>> GetAllGoalsByTag([FromRoute] string tag)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> AddGoal([FromBody] GoalDTO goal)
        {
            ValidationResult result = await _validator.ValidateAsync(goal);

            if (!result.IsValid)
            {
                var formattedErrors = ValidationHelper.FormatValidationErrors(result.Errors);
                return BadRequest(formattedErrors);
            }
            return Ok($"Username: {goal.Name}");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateGoal([FromBody] GoalDTO goal)
        {
            ValidationResult result = await _validator.ValidateAsync(goal);
            if (!result.IsValid)
            {
                var formattedErrors = ValidationHelper.FormatValidationErrors(result.Errors);
                return BadRequest(formattedErrors);
            }
            return Ok($"Name: {goal.Name}");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteGoal(int id)
        {
            return Ok();
        }

    }
}
