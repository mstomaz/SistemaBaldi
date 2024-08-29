namespace Common.Views
{
    public interface ILoginView
    {

        string UserLogin { get; set; }
        string Password {  get; set; }
        string Message {  get; set; }
        bool IsSuccessful { get; set; }
        TextBox TxtUserLogin { get; set; }
        TextBox TxtPassword { get; set; }
        ErrorProvider ErrorProvider { get; set; }

        event EventHandler? TryLogin;

        void ClearFields();
        void Show();
    }
}
