using Common.Model;

namespace Common.Views
{
    public interface IMainView
    {
        UserModel UserInfo { get; set; }
        DialogResult DialogResult { get; set; }
        event EventHandler ShowLoginForm;
        event EventHandler ShowRegisterForm;
        event EventHandler? Closed;
        event System.ComponentModel.CancelEventHandler? Closing;

        void Dispose();
        DialogResult ShowDialog();
    }
}
