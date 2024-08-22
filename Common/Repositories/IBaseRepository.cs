using Microsoft.Data.SqlClient;

namespace Common.Repositories
{
    public interface IBaseRepository
    {
        SqlConnection SqlServerConnect(string connectionString);
        SqlCommand SqlServerGetCommand(string storedProcedure, SqlConnection connection);
        SqlDataReader SqlServerReader(SqlCommand command);
    }
}
