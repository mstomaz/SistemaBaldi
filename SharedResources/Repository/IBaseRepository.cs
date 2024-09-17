using Microsoft.Data.SqlClient;

namespace SharedResourcesLibrary.Repositories
{
    public interface IBaseRepository
    {
        SqlConnection SqlServerConnect(string connectionString);
        SqlCommand SqlServerGetCommand(string storedProcedure, SqlConnection connection);
        SqlDataReader SqlServerReader(SqlCommand command);
    }
}
