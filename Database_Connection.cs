using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Connection string (update according to your database)
        string connectionString = "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;";
        
        // SQL query
        string query = "SELECT TOP 5 * FROM YOUR_TABLE_NAME";

        try
        {
            // Establish the connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Database connection established.");

                // Execute the query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Display the data
                        Console.WriteLine("Query Results:");
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write($"{reader.GetName(i)}: {reader[i]}  ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
