namespace Common.Views
{
    public interface IRegisterView
    {
        string UserLogin { get; set; }
        string Password { get; set; }
        string UserName { get; set; }
        int DepartmentIndex { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }
        TextBox TxtUserLogin { get; set; }
        TextBox TxtPassword { get; set; }
        TextBox TxtUserName { get; set; }

        event EventHandler? TryRegister;
        void Show();
    }
}
