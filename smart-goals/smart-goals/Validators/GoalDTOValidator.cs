using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using smart_goals.DTOs;

namespace smart_goals.Validators
{
    public class GoalDTOValidator : AbstractValidator<GoalDTO>
    {
        public GoalDTOValidator()
        {
            RuleFor(goal => goal.GoalId)
                .GreaterThan(0).WithMessage("GoalId must be greater than 0.");

            RuleFor(goal => goal.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(3, 100).WithMessage("Name must be between 3 and 100 characters.");

            RuleFor(goal => goal.DueDate)
                .GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now))
                .WithMessage("Due date must not be in the past.")
                .When(goal => goal.DueDate != DateOnly.MinValue);


            RuleFor(goal => goal.PriorityLevel)
                .InclusiveBetween(1, 10).WithMessage("PriorityLevel must be between 1 and 10.")
                .When(goal => goal.PriorityLevel != 0);

            //RuleFor(goal => goal.Tags)
            //    .Must(tags => tags == null || tags.All(tag => !string.IsNullOrWhiteSpace(tag)))
            //    .WithMessage("Tags must not contain null or empty strings.");

            RuleFor(goal => goal.GeneralDescription)
                .MaximumLength(500).WithMessage("General description must not exceed 500 characters.")
                .When(goal => !string.IsNullOrWhiteSpace(goal.GeneralDescription));
        }
    }
}
