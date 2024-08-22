using System.Configuration;

namespace Common.Repositories
{
    public class ConnectionConfig
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        }
    }
}
