using SharedResourcesLibrary.Enum;

namespace MainMenu.Model
{
    public class UserModel
    {
        public string? UserLogin { get; set; }
        public string? UserName { get; set; }
        public UserDepartmentEnum UserDepartment { get; set; }
        public bool IsAdmin { get; set; }
    }
}
