using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Common.Model.Enum;

namespace Common.Model
{
    public class UserModel
    {
        [Required(ErrorMessage = "O campo 'Login' é obrigatório")]
        [Key]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo 'Login' deve ter entre 3 e 50 caracteres")]
        [RegularExpression(@"^[\d\w]*$", ErrorMessage = "Use somente dígitos alfanuméricos")]
        public string? UserLogin { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "O campo 'Senha' deve ter 4 caracteres")]
        [RegularExpression(@"^\d*$", ErrorMessage = "Use somente dígitos numéricos")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O campo 'Nome' deve ter entre 3 e 100 caracteres")]
        public string? UserName { get; set; }


        [Required(ErrorMessage = "O campo 'Setor' é obrigatório")]
        public UserDepartmentEnum UserDepartment { get; set; }

        [Required(ErrorMessage = "O campo 'Administrador?' é obrigatório")]
        public bool IsAdmin { get; set; }
    }
}
