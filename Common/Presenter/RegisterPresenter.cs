using Common.Views;
using Common.Repositories;
using Common.Model;
using Common.Model.Enum;

namespace Common.Presenter
{
    public class RegisterPresenter
    {
        public IRegisterView view;
        public IRegisterRepository repository;

        public RegisterPresenter(IRegisterView view, IRegisterRepository repository)
        {
            this.view = view;
            this.repository = repository;
            view.TryRegister += TryRegister;
            view.Show();
        }

        private void TryRegister(object sender, EventArgs e)
        {
            var user = new UserModel
            {
                UserLogin = view.UserLogin,
                Password = view.Password,
                UserName = view.UserName,
                UserDepartment = (UserDepartmentEnum)view.DepartmentIndex
            };
            repository.TryRegister(user);
        }
    }
}
