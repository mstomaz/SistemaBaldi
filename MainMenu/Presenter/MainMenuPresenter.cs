using MainMenu.Views;
using FinishControl.Views;
using FinishControl.Repositories;
using FinishControl.Presenters;

namespace MainMenu.Presenter
{
    public class MainMenuPresenter
    {
        private IMainMenuView mainMenuView;
        private string connectionString;

        public event EventHandler? OnLogoutClicked;

        public MainMenuPresenter(IMainMenuView view, string connectionString)
        {
            mainMenuView = view;
            this.connectionString = connectionString;
            view.ShowFinishControlModuleMainForm += ShowFinishControlForm;
            view.LogoutClicked += (s, e) =>
            {
                view.DialogResult = DialogResult.OK;   
                OnLogoutClicked.Invoke(this, EventArgs.Empty);
            };
        }

        private void ShowFinishControlForm(object? sender, EventArgs e)
        {
            IFinishControlMainView view = FinishControlMainView.GetInstance((MainMenuView)mainMenuView);
            FinishControlRepository repository = new FinishControlRepository(connectionString);
            new FinishControlPresenter(view, repository);
        }
    }
}