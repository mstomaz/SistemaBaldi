namespace Common.Attributes
{
    /// <summary>
    /// Maps the control name to the property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ControlMappingAttribute : Attribute
    {
        public string ControlName { get; }

        public ControlMappingAttribute(string controlName)
        {
            ControlName = controlName;
        }
    }
}
