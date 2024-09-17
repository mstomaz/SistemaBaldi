using MainMenu.View;

namespace MainMenu.Presenter
{
    public class MainMenuPresenter
    {
        private readonly IMainMenuView mainMenuView;
        private readonly string connectionString;

        public MainMenuPresenter(IMainMenuView view, string connectionString)
        {
            mainMenuView = view;
            this.connectionString = connectionString;
        }
    }
}
