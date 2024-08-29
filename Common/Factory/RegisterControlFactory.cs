using Common.Attributes;
using Common.Views;
using Common.Views.Model;
using System.Reflection;

namespace Common.Factory
{
    public class RegisterControlFactory
    {
        private readonly IRegisterView view;

        public RegisterControlFactory(IRegisterView view)
        {
            this.view = view;
        }
    
        public Control GetControl(string key)
        {
            var property = typeof(UserViewModel).GetProperty(key);
            if (property != null)
            {
                var attribute = property.GetCustomAttribute<ControlMappingAttribute>();
                if (attribute != null)
                {
                    return (Control)view.GetType().GetProperty(attribute.ControlName).GetValue(view);
                }
            }

            throw new ArgumentException($"Control for key '{key}' not found.");
        }
    }
}
