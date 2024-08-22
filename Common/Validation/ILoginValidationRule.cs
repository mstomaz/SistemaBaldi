using Common.Repositories.Enum;
using Common.Views;

namespace Common.Validation
{
    public interface ILoginValidationRule
    {
        (bool isValid, LoginErrorEnum errorCode, string? message) Validate(ILoginView view);
    }
}
