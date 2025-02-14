using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
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

    public class UsersController : ControllerBase
    {

        private IValidator<UserDTO> _validator;

        public UsersController(IValidator<UserDTO> validator)
        {
            _validator = validator;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetAllUsers()
        {
            return Ok();
        }

        [HttpGet("enabled")]
        public ActionResult<IEnumerable<UserDTO>> GetAllEnabledUsers()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetUser(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> AddUser([FromBody] UserDTO user)
        {
            ValidationResult result = await _validator.ValidateAsync(user);

            if (!result.IsValid)
            {
                var formattedErrors = ValidationHelper.FormatValidationErrors(result.Errors);
                return BadRequest(formattedErrors);
            }
            return Ok($"Username: {user.Username}");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser([FromBody] UserDTO user)
        {
            ValidationResult result = await _validator.ValidateAsync(user);
            if (!result.IsValid)
            {
                var formattedErrors = ValidationHelper.FormatValidationErrors(result.Errors);
                return BadRequest(formattedErrors);
            }
            return Ok($"Username: {user.Username}");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            return Ok();
        }

    }
}
