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

    public class GoalListsController : ControllerBase
    {

        private IValidator<GoalListDTO> _validator;

        public GoalListsController(IValidator<GoalListDTO> validator)
        {
            _validator = validator;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GoalListDTO>> GetAllGoalLists()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetGoalList(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> AddGoalList([FromBody] GoalListDTO goalList)
        {
            ValidationResult result = await _validator.ValidateAsync(goalList);
            if (!result.IsValid)
            {
                var formattedErrors = ValidationHelper.FormatValidationErrors(result.Errors);
                return BadRequest(formattedErrors);
            }
            return Ok($"Name: {goalList.Name}");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateGoalList([FromBody] GoalListDTO goalList)
        {
            ValidationResult result = await _validator.ValidateAsync(goalList);
            if (!result.IsValid)
            {
                var formattedErrors = ValidationHelper.FormatValidationErrors(result.Errors);
                return BadRequest(formattedErrors);
            }
            return Ok($"Name: {goalList.Name}");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteGoalList(int id)
        {
            return Ok();
        }

    }
}
