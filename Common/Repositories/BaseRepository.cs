using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
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
