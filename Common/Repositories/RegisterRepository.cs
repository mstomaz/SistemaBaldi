using Common.Model;
using Microsoft.Data.SqlClient;
using System.Data;
using SharedResourcesLibrary.Repositories;

namespace Common.Repositories
{
    public class RegisterRepository : BaseRepository, IRegisterRepository
    {

        public RegisterRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void TryRegister(UserModel user)
        {
            using var connection = SqlServerConnect(connectionString);
            string storedProcedure = "CreateUser";
            var command = SqlServerGetCommand(storedProcedure, connection);

            using (command)
            {
                command.Connection = connection;
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar)).Value = user.UserLogin;
                command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar)).Value = user.Password;
                command.Parameters.Add(new SqlParameter("@userName", SqlDbType.NVarChar)).Value = user.UserName;
                command.Parameters.Add(new SqlParameter("@department", SqlDbType.Int)).Value = (int)user.UserDepartment;
                command.Parameters.Add(new SqlParameter("isAdmin", SqlDbType.Bit)).Value = 0;

                connection.Open();


                command.ExecuteNonQuery();
            }
        }

    }
}
