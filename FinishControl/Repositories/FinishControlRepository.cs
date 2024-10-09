using FinishControl.Model;
using Microsoft.Data.SqlClient;
using SharedResourcesLibrary.Repositories;

namespace FinishControl.Repositories
{
    public class FinishControlRepository : BaseRepository
    {
        public FinishControlRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<FinishControlModel> PopulateFinishControlGrid()
        {
            var gridData = new List<FinishControlModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Prod.ProdOrderNumber, SalesOrderNumber, CustomerName, ItemGroup, ItemName, " +
                    "OrderQuantity, QuantityProduced, EmployeeResponsible, DateAdded, CorrectionTimestamp " +
                    "FROM TbProdOrder Prod " +
                    "JOIN TbQuantityProduced Qty ON Prod.ProdOrderNumber = Qty.ProdOrderNumber";

                using SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
 
                while (reader.Read())
                {
                    var model = new FinishControlModel()
                    {
                        ProdOrderNumber = GetValueOrDefault<int>(reader, "ProdOrderNumber"),
                        SalesOrderNumber = GetValueOrDefault<int>(reader, "SalesOrderNumber"),
                        CustomerName = GetValueOrDefault<string>(reader, "CustomerName"),
                        ItemGroup = GetValueOrDefault<string>(reader, "ItemGroup"),
                        ItemName = GetValueOrDefault<string>(reader, "ItemName"),
                        OrderQuantity = GetValueOrDefault<int>(reader, "OrderQuantity"),
                        QuantityProduced = GetValueOrDefault<int>(reader, "QuantityProduced"),
                        EmployeeResponsible = GetValueOrDefault<string>(reader, "EmployeeResponsible"),
                        DateAdded = GetValueOrDefault<DateTime>(reader, "DateAdded"),
                        CorrectionTimestamp = GetValueOrDefault<DateTime>(reader, "CorrectionTimestamp"),
                    };
                    gridData.Add(model);
                }
            }
            return gridData;
        }

        private static T GetValueOrDefault<T>(SqlDataReader reader, string columnName)
        {
            return reader.IsDBNull(reader.GetOrdinal(columnName)) ? default : (T)reader.GetValue(reader.GetOrdinal(columnName));
        }
    }
}
