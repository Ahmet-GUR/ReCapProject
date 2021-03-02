using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var resualt = validator.Validate(context);
            if (!resualt.IsValid)
            {
                throw new ValidationException(resualt.Errors);
            }
        }
    }
}
