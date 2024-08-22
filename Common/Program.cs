using Common.Presenter;
using Common.Views;
using System.Configuration;
using SharedResources;
using Common.Repositories;

namespace Common
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IMainView view = new MainView();
            string connectionString = ConnectionConfig.GetConnectionString();
            new MainPresenter(view, connectionString);
            Application.Run((Form)view);
        }
    }
}