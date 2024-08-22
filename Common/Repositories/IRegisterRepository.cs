using Common.Model;
using Common.Model.Enum;

namespace Common.Repositories
{
    public interface IRegisterRepository
    {
        void TryRegister(UserModel user);
    }
}
