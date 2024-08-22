using Common.Repositories.Enum;
using Common.Views;

namespace Common.ControlFactory
{
    public class LoginControlFactory : IControlFactory
    {
        private readonly ILoginView view;
        private readonly Dictionary<LoginErrorEnum, TextBox> controlMapping;

        public LoginControlFactory(ILoginView view)
        {
            this.view = view;

            controlMapping = new Dictionary<LoginErrorEnum, TextBox>
            {
                { LoginErrorEnum.UserFieldEmpty, view.TxtUsername },
                { LoginErrorEnum.UserNotFound, view.TxtUsername },
                { LoginErrorEnum.PasswordFieldEmpty, view.TxtPassword },
                { LoginErrorEnum.WrongPassword, view.TxtPassword }
            };
        }
        public Control GetControl(LoginErrorEnum errorCode)
        {
            if (controlMapping.TryGetValue(errorCode, out var control))
            {
                return control;
            }
            throw new ArgumentOutOfRangeException(nameof(errorCode), LoginResources.UNKNOWN_ERROR);
        }
    }
}
