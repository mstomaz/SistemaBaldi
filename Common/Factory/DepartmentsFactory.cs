using Common.Model.Enum;

namespace Common.Factory
{
    public static class DepartmentsFactory
    {
        public static Dictionary<UserDepartmentEnum, string> departmentMapping { get; } = new()
        {
            { UserDepartmentEnum.Expedition, "Expedição" },
            { UserDepartmentEnum.ProdControl, "Controle de produção" }
        };

        public static string[] GetDepartmentValues()
        {
            string[] departments = new string[departmentMapping.Count];
            for (int i = 0; i < departmentMapping.Count; i++)
            {
                departments[i] = departmentMapping.Values.ElementAt(i);
            }

            return departments;
        }

        public static UserDepartmentEnum GetDepartmentKey(string departmentName)
        {
            return departmentName switch
            {
                "Expedição" => UserDepartmentEnum.Expedition,
                "Controle de produção" => UserDepartmentEnum.ProdControl,
                _ => throw new System.Runtime.CompilerServices.SwitchExpressionException()
            };
        }
    }
}
