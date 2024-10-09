using System.ComponentModel;

namespace MainMenu.Views
{
    public interface IMainMenuView
    {
        DialogResult DialogResult { get; set; }

        event EventHandler? LogoutClicked;
        event EventHandler? ShowFinishControlModuleMainForm;
        event EventHandler? ShowPickingModuleMainForm;
        event EventHandler? Closed;
        event CancelEventHandler? Closing;

        void Close();
        void Show();
    }
}
