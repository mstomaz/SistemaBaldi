using Common.Model.Enum;

namespace Common.Views
{
    public interface IRegisterView
    {
        string UserLogin { get; set; }
        string Password { get; set; }
        string PasswordConfirmation { get; set; }
        string UserName { get; set; }
        UserDepartmentEnum? DepartmentCode { get; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }
        TextBox TxtUserLogin { get; set; }
        TextBox TxtPassword { get; set; }
        TextBox TxtConfirmPassword {  get; set; }
        TextBox TxtUserName { get; set; }
        ComboBox CboxDepartment { get; set; }
        ErrorProvider ErrorProvider { get; set; }


        event EventHandler? TryRegister;

        public void ShowMsgBoxError(string errorMessage, string titleMessage,
            MessageBoxButtons msgBoxButtons = MessageBoxButtons.OK, MessageBoxIcon msgBoxIcon = MessageBoxIcon.Error);
        void ClearFields()
        {
            UserLogin = string.Empty;
            Password = string.Empty;
            PasswordConfirmation = string.Empty;
            UserName = string.Empty;
        }
        void Show();
    }
}
