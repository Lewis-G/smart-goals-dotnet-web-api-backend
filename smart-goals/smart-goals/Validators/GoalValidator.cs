using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using smart_goals.Models;

namespace smart_goals.Validators
{
    public class GoalValidator : AbstractValidator<Goal>
    {
        public GoalValidator()
        {
            RuleFor(goal => goal.GoalID)
                .GreaterThan(0).WithMessage("GoalID must be greater than 0.");

            RuleFor(goal => goal.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(3, 100).WithMessage("Name must be between 3 and 100 characters.");

            RuleFor(goal => goal.Date)
                .GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now))
                .WithMessage("Date must not be in the past.");

            RuleFor(goal => goal.TierLevel)
                .InclusiveBetween(1, 5).WithMessage("TierLevel must be between 1 and 5.");

            RuleFor(goal => goal.PriorityLevel)
                .InclusiveBetween(1, 10).WithMessage("PriorityLevel must be between 1 and 10.");

            RuleFor(goal => goal.Tags)
                .Must(tags => tags == null || tags.All(tag => !string.IsNullOrWhiteSpace(tag)))
                .WithMessage("Tags must not contain null or empty strings.");

            RuleFor(goal => goal.Description)
                .MaximumLength(500).WithMessage("Description must not exceed 500 characters.");
        }
    }
}
