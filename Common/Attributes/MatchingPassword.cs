using System.ComponentModel.DataAnnotations;

namespace Common.Attributes
{
    /// <summary>
    /// Validation attribute to check if two properties' values match.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    sealed public class MatchingPassword : ValidationAttribute
    {
        /// <summary>
        /// The control that has the text to match with the property's value.
        /// </summary>
        readonly string _comparisonProperty;

        public MatchingPassword(string comparisonProperty)
        {
            _comparisonProperty = comparisonProperty;
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            var property = validationContext.ObjectType.GetProperty(_comparisonProperty);

            if (property == null)
            {
                return new ValidationResult($"Property {_comparisonProperty} not found");
            }

            var comparisonValue = property.GetValue(validationContext.ObjectInstance)?.ToString();

            if (!string.Equals(value.ToString(), comparisonValue))
            {
                return new ValidationResult(ErrorMessage, [validationContext.MemberName]);
            }

            return ValidationResult.Success;
        }
    }
}
