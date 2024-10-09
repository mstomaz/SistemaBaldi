using Common.Model;
using Common.Properties;
using Common.Repositories.Enum;
using Microsoft.Data.SqlClient;
using System.Data;
using SharedResourcesLibrary.Repositories;

namespace Common.Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {

        public LoginRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public (bool isValid, LoginErrorEnum errorCode, string? errorMessage) TryLogin(UserModel user)
        {
            using var connection = new SqlConnection(connectionString);
            string storedProcedure = "ValidateUser";
            var command = new SqlCommand(storedProcedure, connection);

            using (command)
            {
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@login", user.UserLogin));
                command.Parameters.Add(new SqlParameter("@password", user.Password));
                connection.Open();

                var result = command.ExecuteScalar();

                return result switch
                {
                    1 => (true, LoginErrorEnum.None, null ),
                    0 => (false, LoginErrorEnum.UserNotFound, Resources.USER_NOT_FOUND_ERROR),
                    -1 => (false, LoginErrorEnum.WrongPassword, Resources.USER_WRONG_PASSWORD),
                    _ => (false, LoginErrorEnum.Unknown, Resources.USER_LOGIN_UNKNOWN_ERROR)
                };
            }
        }
    }
}
