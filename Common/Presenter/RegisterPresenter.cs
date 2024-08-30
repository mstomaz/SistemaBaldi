using Common.Factory;
using Common.Model;
using Common.Presenter.Common;
using Common.Repositories;
using Common.Validation;
using Common.Views;
using Common.Views.Model;
using Microsoft.Data.SqlClient;

namespace Common.Presenter
{
    public class RegisterPresenter
    {
        private IRegisterView view;
        private IRegisterRepository repository;
        private RegisterControlFactory factory;

        public RegisterPresenter(IRegisterView view, IRegisterRepository repository, RegisterControlFactory factory)
        {
            this.view = view;
            this.repository = repository;
            this.factory = factory;
            view.TryRegister += TryRegister;
            view.Show();
        }

        private void TryRegister(object sender, EventArgs e)
        {
            view.ErrorProvider.Clear();

            var viewModel = new UserViewModel()
            {
                UserLogin = view.UserLogin,
                Password = view.Password,
                UserName = view.UserName,
                ConfirmPassword = view.PasswordConfirmation,
                UserDepartment = view.DepartmentCode
            };

            (view.IsSuccessful, Dictionary<string, string> errors) = ModelDataValidation.Validate(viewModel);
            if (!view.IsSuccessful)
            {
                HandleErrors(errors);
                return;
            }

            var user = new UserModel()
            {
                UserLogin = view.UserLogin,
                Password = view.Password,
                UserName = view.UserName,
                UserDepartment = viewModel.UserDepartment
            };

            try
            {
                repository.TryRegister(user);
                MessageBox.Show("Cadastro realizado com sucesso!");
                view.ClearFields();
            }
            catch (SqlException ex)
            {
                if (SqlServerExceptionValidation.IsUniqueKeyException(ex.Number))
                {
                    view.ShowMsgBoxError($"O nome de usuário '{user.UserLogin}' já está em uso.",
                        "Nome de usuário já em uso");
                    view.UserLogin = string.Empty;
                }
            }
        }

        private void HandleErrors(Dictionary<string, string> errors)
        {
            foreach (var error in errors)
            {
                var control = factory.GetControl(error.Key);
                view.ErrorProvider.SetError(control, error.Value);
            }
        }
    }
}
