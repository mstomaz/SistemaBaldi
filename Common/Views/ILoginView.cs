namespace Common.Views
{
    public interface ILoginView
    {

        string UserLogin { get; set; }
        string Password {  get; set; }
        string Message {  get; set; }
        bool IsSuccessful { get; set; }
        TextBox TxtUsername { get; set; }
        TextBox TxtPassword { get; set; }
        ErrorProvider ErrorProvider { get; set; }

        event EventHandler? TryLogin;

        void SetError(Control control, string? errorMessage);
        void Show();
    }
}
