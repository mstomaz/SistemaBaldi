using Common.ControlFactory;
using Common.Model;
using Common.Repositories;
using Common.Repositories.Enum;
using Common.Validation;
using Common.Views;
using Common.Validation.Model;

namespace Common.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly ILoginRepository repository;
        private readonly IEnumerable<ILoginValidationRule> loginValidationRules;
        private readonly IControlFactory controlFactory;
        private readonly IMainView mainView;

        private event EventHandler LoginSucessful;

        public LoginPresenter(ILoginView view, ILoginRepository repository, IEnumerable<ILoginValidationRule> loginValidationRules,
            IControlFactory controlFactory, IMainView mainView)
        {
            this.view = view;
            this.repository = repository;
            this.loginValidationRules = loginValidationRules;
            this.controlFactory = controlFactory;
            this.mainView = mainView;
            this.view.TryLogin += TryLogin;
            LoginSucessful += OnLoginSucessful;
            this.view.Show();
        }

        private void TryLogin(object? sender, EventArgs e)
        {
            view.ErrorProvider.Clear();

            LoginErrorEnum errorCode;

            var (isValid, errors) = ValidateEmptyFields();

            if (!isValid)
            {
                ShowEmptyValidationErrors(errors);
                return;
            }

            var viewModel = new UserModelValidation()
            {
                UserLogin = view.UserLogin,
                Password = view.Password
            };

            var model = new UserModel()
            {
                UserLogin = viewModel.UserLogin,
                Password = viewModel.Password
            };

            (view.IsSuccessful, errorCode, view.Message) = repository.TryLogin(model);

            if (!view.IsSuccessful)
            {
                HandleLoginError(errorCode, view.Message);
                return;
            }

            OnLoginSucessful(this, null);
        }

        private (bool isValid, List<(LoginErrorEnum errorCode, string message)> errors) ValidateEmptyFields()
        {
            var errors = new List<(LoginErrorEnum, string)>();

            foreach (var rule in loginValidationRules)
            {
                var (isValid, errorCode, message) = rule.Validate(view);
                if (!isValid && !errorCode.Equals(LoginErrorEnum.None) && message != null)
                {
                    errors.Add((errorCode, message));
                }
            }
            
            return (errors.Count == 0, errors);
        }

        private void ShowEmptyValidationErrors(List<(LoginErrorEnum errorCode, string message)> errors)
        {
            foreach (var (errorCode, message) in errors)
            {
                var control = controlFactory.GetControl(errorCode);
                view.ErrorProvider.SetError(control, message);
            }
        }

        private void HandleLoginError(LoginErrorEnum errorCode, string? message)
        {
            CallErrorProvider(errorCode, message);
            ClearPasswordField();
        }

        private void CallErrorProvider(LoginErrorEnum errorCode, string? errorMessage)
        {
            var control = controlFactory.GetControl(errorCode);
            view.ErrorProvider.SetError(control, errorMessage);
        }

        private void ClearPasswordField()
        {
            view.Password = string.Empty;
        }

        private void OnLoginSucessful(object? sender, EventArgs e)
        {
            mainView.DialogResult = DialogResult.OK;
        }
    }
}
