using Common.Repositories.Enum;
using Common.Views;

namespace Common.Validation
{
    public class LoginFieldEmptyValidationRule : ILoginValidationRule
    {
        public (bool isValid, LoginErrorEnum errorCode, string? message) Validate(ILoginView view)
        {
            if (string.IsNullOrWhiteSpace(view.UserLogin))
            {
                return (false, LoginErrorEnum.UserFieldEmpty, LoginResources.USER_FIELD_EMPTY);
            }
            return (true, LoginErrorEnum.None, null);
        }
    }
}
