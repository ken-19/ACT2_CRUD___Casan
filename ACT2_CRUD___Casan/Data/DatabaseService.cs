using System.Data.SqlClient;
using System.Data;

namespace ACT2_CRUD___Casan.Data
{
    public class DatabaseService
    {
        private readonly string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=DB_Ordering_Food_Transaction_Casan_IT13;Trusted_Connection=True;";

        public async Task<List<FoodItem>> GetFoodItemsAsync()
        {
            List<FoodItem> foodItems = new List<FoodItem>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand("SELECT * FROM FoodItems", connection);
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        foodItems.Add(new FoodItem
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2),
                            Price = reader.GetDecimal(3)
                        });
                    }
                }
            }
            return foodItems;
        }

        public async Task AddFoodItemAsync(FoodItem foodItem)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand("INSERT INTO FoodItems (Name, Description, Price) VALUES (@Name, @Description, @Price)", connection);
                command.Parameters.AddWithValue("@Name", foodItem.Name);
                command.Parameters.AddWithValue("@Description", foodItem.Description);
                command.Parameters.AddWithValue("@Price", foodItem.Price);
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task UpdateFoodItemAsync(FoodItem foodItem)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand("UPDATE FoodItems SET Name = @Name, Description = @Description, Price = @Price WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", foodItem.Id);
                command.Parameters.AddWithValue("@Name", foodItem.Name);
                command.Parameters.AddWithValue("@Description", foodItem.Description);
                command.Parameters.AddWithValue("@Price", foodItem.Price);
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task DeleteFoodItemAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand("DELETE FROM FoodItems WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
