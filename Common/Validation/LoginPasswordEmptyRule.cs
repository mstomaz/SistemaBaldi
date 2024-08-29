using Common.Repositories.Enum;
using Common.Views;

namespace Common.Validation
{
    public class LoginPasswordEmptyRule : ILoginValidationRule
    {
        public (bool isValid, LoginErrorEnum errorCode, string? message) Validate(ILoginView view)
        {
            if (string.IsNullOrWhiteSpace(view.Password))
            {
                return (false, LoginErrorEnum.PasswordFieldEmpty, LoginResources.PASSWORD_FIELD_EMPTY);
            }
            return (true, LoginErrorEnum.None, null);
        }
    }
}
