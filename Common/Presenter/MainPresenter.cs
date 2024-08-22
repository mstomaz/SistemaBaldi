using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.ControlFactory;
using Common.Repositories;
using Common.Validation;
using Common.Views;

namespace Common.Presenter
{
    public class MainPresenter
    {
        private IMainView mainView;
        private string connectionString;

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
            ILoginRepository repository = new LoginRepository(connectionString);
            IEnumerable<ILoginValidationRule> loginValidationRules =
            [
                new LoginFieldEmptyValidationRule(),
                new PasswordFieldEmptyValidationRule()
            ];
            IControlFactory controlFactory = new LoginControlFactory(view);
            new LoginPresenter(view, repository, loginValidationRules, controlFactory);
        }

        private void ShowRegisterForm(object sender, EventArgs args)
        {
            IRegisterView view = RegisterView.GetInstance((MainView)mainView);
            IRegisterRepository repository = new RegisterRepository(connectionString);
            new RegisterPresenter(view, repository);
        }
    }
}
