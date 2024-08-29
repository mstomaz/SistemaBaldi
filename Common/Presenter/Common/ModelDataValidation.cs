using System.ComponentModel.DataAnnotations;

namespace Common.Presenter.Common
{
    public class ModelDataValidation
    {
        public static (bool isValid, Dictionary<string, string>) Validate(object model)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(model);
            var errors = new Dictionary<string, string>();

            bool isValid = Validator.TryValidateObject(model, context, results, true);
            
            if (!isValid)
            {
                foreach (var result in results)
                {
                    var memberName = result.MemberNames.First();
                    errors[memberName] = result.ErrorMessage;
                }
            }

            return (isValid, errors);
        }
    }
}
