using Common.Model;
using SharedResourcesLibrary.Repositories;
using SharedResourcesLibrary.Enum;
using Microsoft.Data.SqlClient;

namespace Common.Repositories
{
    public class UserInfoRepository : BaseRepository
    {
        public UserInfoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public UserModel GetUserInfo(string userLogin)
        {
            UserModel userModel = null;
            string query = "SELECT UserLogin, UserName, Department FROM TbUser WHERE UserLogin = @userLogin";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(query, connection);

            using (connection)
            {
                using (command)
                {
                    command.Parameters.AddWithValue("@userLogin", userLogin);
                    connection.Open();

                    using (var reader =  command.ExecuteReader())
                    {
                        userModel = new UserModel();
                        if (reader.Read())
                        {
                            userModel.UserLogin = reader.GetString(0);
                            userModel.UserName = reader.GetString(1);
                            userModel.UserDepartment = (UserDepartmentEnum)reader.GetInt32(2);
                        }
                    }
                }
            }
            return userModel;
        }
    }
}
