using Microsoft.Data.SqlClient;

namespace SharedResourcesLibrary.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        protected string connectionString;

        public SqlConnection SqlServerConnect(string connectionString)
        {
            var connection = new SqlConnection(connectionString);
            return connection;
        }

        public SqlCommand SqlServerGetCommand(string storedProcedure, SqlConnection connection)
        {
            var command = new SqlCommand(storedProcedure, connection);
            return command;
        }

        public SqlDataReader SqlServerReader(SqlCommand command)
        {
            var reader = command.ExecuteReader();
            return reader;
        }
    }
}
