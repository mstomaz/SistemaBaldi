using Common.ControlFactory;
using Common.Factory;
using Common.Repositories;
using Common.Validation;
using Common.Views;

namespace Common.Presenter
{
    public class MainPresenter
    {
        private IMainView mainView;
        private string connectionString;
        private RegisterPresenter _registerInstance;
        private LoginPresenter _loginInstance;

        public MainPresenter(IMainView mainView, string connectionString)
        {
            this.mainView = mainView;
            this.connectionString = connectionString;
            this.mainView.ShowLoginForm += ShowLoginForm;
            this.mainView.ShowRegisterForm += ShowRegisterForm;
        }

        private void ShowLoginForm(object sender, EventArgs args)
        {
            ILoginView view = LoginView.GetInstance((MainView)mainView);
            view.ClearFields();
            if (_loginInstance == null)
            {
                ILoginRepository repository = new LoginRepository(connectionString);
                IEnumerable<ILoginValidationRule> loginValidationRules =
                [
                    new LoginFieldEmptyValidationRule(),
                new LoginPasswordEmptyRule()
                ];
                IControlFactory controlFactory = new LoginControlFactory(view);
                _loginInstance = new LoginPresenter(view, repository, loginValidationRules, controlFactory);
            }
        }

        private void ShowRegisterForm(object sender, EventArgs args)
        {
            IRegisterView view = RegisterView.GetInstance((MainView)mainView);
            view.ClearFields();
            if (_registerInstance == null)
            {
                IRegisterRepository repository = new RegisterRepository(connectionString);
                var factory = new RegisterControlFactory(view);
                _registerInstance = new RegisterPresenter(view, repository, factory);
            }

        }
    }
}
