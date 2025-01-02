using Microsoft.AspNetCore.Mvc.ModelBinding;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_goals.Validators
{
    public static class ValidationHelper
    {
        public static object FormatValidationErrors(IEnumerable<FluentValidation.Results.ValidationFailure> errors)
        {
            return errors.Select(error => new
            {
                PropertyName = error.PropertyName,
                ErrorMessage = error.ErrorMessage,
                AttemptedValue = error.AttemptedValue
            });
        }
    }
}
