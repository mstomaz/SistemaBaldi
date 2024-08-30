using Common.Attributes;
using Common.Model.Enum;
using System.ComponentModel.DataAnnotations;

namespace Common.Views.Model
{
    public class UserViewModel
    {
        [Key]
        [Required(ErrorMessage = "O campo 'Login' é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo 'Login' deve ter entre 3 e 50 caracteres")]
        [RegularExpression(@"^([a-zA-z])([\w])*$", ErrorMessage = "Use somente letras ou números, começando com uma letra")]
        [ControlMapping("TxtUserLogin")]
        public string? UserLogin { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "O campo 'Senha' deve ter 4 caracteres")]
        [RegularExpression(@"^\d*$", ErrorMessage = "Use somente dígitos numéricos")]
        [ControlMapping("TxtPassword")]

        public string? Password { get; set; }

        [Required(ErrorMessage = "O campo 'Confirmação de Senha' é obrigatório")]
        [ControlMapping("TxtConfirmPassword")]
        [MatchingPassword("Password", ErrorMessage = "As senhas não coincidem")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O campo 'Nome' deve ter entre 3 e 100 caracteres")]
        [RegularExpression(@"^([a-zA-z])([a-zA-z]|\s)*$", ErrorMessage = "Use somente letras e espaços, começando com uma letra")]
        [ControlMapping("TxtUserName")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "O campo 'Setor' é obrigatório")]
        [ControlMapping("CboxDepartment")]
        public UserDepartmentEnum? UserDepartment { get; set; }

        public bool IsAdmin { get; set; }
    }
}