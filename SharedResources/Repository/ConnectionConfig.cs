using System.Configuration;

namespace SharedResourcesLibrary.Repositories
{
    public class ConnectionConfig
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        }
    }
}
