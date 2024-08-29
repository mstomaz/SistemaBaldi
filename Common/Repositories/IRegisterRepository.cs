using Common.Model;

namespace Common.Repositories
{
    public interface IRegisterRepository
    {
        void TryRegister(UserModel user);
    }
}
