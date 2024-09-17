using Common.Presenter;
using Common.Views;
using MainMenu;

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
                StartMainMenu();
        }

        private void StartMainMenu()
        {
            var mainMenu = new formMenu();
            mainMenu.FormClosed += OnFormClosed;
            mainMenu.FormClosing += OnFormClosing;
            mainMenu.Show();
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
        }

        private void OnFormClosing(object? sender, EventArgs e)
        {
        }
    }
}
