using System.Collections.Generic;
using AlloyTraining.Models.Pages;
using EPiServer.Validation;

namespace AlloyTraining.Business.Validation
{
    public class DemoPageValidator : IValidate<DemoPage>
    {
        public IEnumerable<ValidationError> Validate(DemoPage instance)
        {
            var errors = new List<ValidationError>();

            if ((instance.Name.Length < 5) || (instance.Name.Length > 65))
            {
                errors.Add(new ValidationError
                {
                    ErrorMessage = "The name is too short.",
                    Severity = ValidationErrorSeverity.Warning
                });
            }

            if (instance.Name.ToUpper().Contains("BAD"))
            {
                errors.Add(new ValidationError
                {
                    ErrorMessage = "No BAD words allowed.",
                    Severity = ValidationErrorSeverity.Error
                });
            }

            if (instance.MyContentArea.Items.Count > 0)
            {
                errors.Add(new ValidationError
                {
                    ErrorMessage = $"The content area contains references to {instance.MyContentArea}",
                    Severity = ValidationErrorSeverity.Warning
                });
            }

            return errors;
        }
    }
}