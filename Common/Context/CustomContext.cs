using Common.Presenter;
using Common.Views;
using MainMenu;
using MainMenu.Presenter;
using MainMenu.Views;

namespace Common.Context
{
    public class CustomContext : ApplicationContext
    {
        private DateTime lastTimeLogged;
        private readonly string connectionString = SharedResourcesLibrary.Repositories.ConnectionConfig.GetConnectionString();

        public CustomContext()
        {
            Application.ApplicationExit += OnApplicationExit;

            if (lastTimeLogged.ToShortDateString() != DateTime.Now.ToShortDateString())
                StartLoginMenu(new MainView());                
            else
            {

            }
        }

        private void StartLoginMenu(IMainView view)
        {
            new MainPresenter(view, connectionString);
            view.Closed += OnFormClosed;
            view.Closing += OnFormClosing;
            view.ShowDialog();
            if (view.DialogResult == DialogResult.OK)
            {
                StartMainMenu(new MainMenuView(new MainMenu.Model.UserModel()
                {
                    UserLogin = view.UserInfo.UserLogin,
                    UserName = view.UserInfo.UserName,
                    UserDepartment = view.UserInfo.UserDepartment
                }));
            }
        }

        private void StartMainMenu(IMainMenuView view)
        {
            var mainMenuPresenter = new MainMenuPresenter(view, connectionString);
            view.Closed += OnFormClosed;
            view.Closing += OnFormClosing;
            mainMenuPresenter.OnLogoutClicked += (s, e) =>
            {
                view.Close();
                StartLoginMenu(new MainView());
            };
            view.Show();
        }

        private void OnApplicationExit(object? sender, EventArgs e)
        {
        }

        private void OnFormClosed(object? sender, EventArgs e)
        {
            if ((DialogResult)sender.GetType().GetProperty("DialogResult").GetValue(sender) != DialogResult.OK)
            {
                Application.Exit();
            }
            ((Form)sender).Dispose();
        }

        private void OnFormClosing(object? sender, EventArgs e)
        {
        }

        private void OnMouseClick(object? sender, EventArgs e)
        {
            
                        
        }
    }
}
