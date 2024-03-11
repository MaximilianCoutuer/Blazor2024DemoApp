using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Xml.Linq;

namespace Blazor2024DemoApp.Components.Pages
{
    public class NameValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(
            object? value,
            ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Name is blank");
            }
            var name = value.ToString();
            return (name.StartsWith("A")
                ? null
                : new ValidationResult("Must start with A"));
        }
    }
}
