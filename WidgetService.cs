using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace AboutMeWebsite
{
    public class WidgetService
    {
        private readonly string _connectionString;

        public WidgetService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MyDatabase");
        }

        public void InsertWidget(string name, string manufacturer, string description, int cost)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO dbo.Widgets (Name, Manufacturer, Description, Cost) VALUES (@Name, @Manufacturer, @Description, @Cost)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Cost", cost);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateWidget(int id, string name, string manufacturer, string description, int cost)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = "UPDATE dbo.Widgets SET Name = @Name, Manufacturer = @Manufacturer, Description = @Description, Cost = @Cost WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Cost", cost);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                   
                }
            }
        }
    }
}
