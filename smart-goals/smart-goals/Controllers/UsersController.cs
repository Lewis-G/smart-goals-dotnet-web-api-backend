using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using smart_goals.Models;
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

        private IValidator<User> _validator;

        public UsersController(IValidator<User> validator)
        {
            _validator = validator;
        }

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
        public async Task<ActionResult> AddUser([FromBody] User user)
        {
            ValidationResult result = await _validator.ValidateAsync(user);

            if (!result.IsValid)
            {
                var formattedErrors = ValidationHelper.FormatValidationErrors(result.Errors);
                return BadRequest(formattedErrors);
            }
            return Ok($"Username: {user.Username}");
        }

    }
}
