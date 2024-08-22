using Common.Model;
using Common.Repositories.Enum;

namespace Common.Repositories
{
    public interface ILoginRepository
    {
        (bool isValid, LoginErrorEnum errorCode, string? errorMessage) TryLogin(UserModel user);
    }
}
