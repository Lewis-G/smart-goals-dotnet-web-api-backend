using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using smart_goals.DTOs;

namespace smart_goals.Validators
{
    public class GoalListDTOValidator : AbstractValidator<GoalListDTO>
    {
        public GoalListDTOValidator()
        {
            RuleFor(goal => goal.GoalListId)
                .GreaterThan(0).WithMessage("GoalListId must be greater than 0.");

            RuleFor(goal => goal.UserId)
                .GreaterThan(0).WithMessage("UserId must be greater than 0.");

            RuleFor(goal => goal.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

            RuleFor(goal => goal.ColourID)
                .GreaterThan(0).WithMessage("ColourID must be greater than 0.");
        }
    }
}
