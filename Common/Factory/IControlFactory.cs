using Common.Repositories.Enum;

namespace Common.ControlFactory
{
    public interface IControlFactory
    {
        Control GetControl(LoginErrorEnum errorCode);
    }
}
