//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Data;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.Marshalling;


class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=-Z3R0-\\SQLEXPRESS;" +
            "Initial Catalog=College;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                int price =600;
                connection.Open();
                Console.WriteLine("Connection successful!");

                string query = "SELECT laptop from laptop where Price =@price";

                using (SqlCommand command = new SqlCommand(query, connection))
                 {   command.Parameters.AddWithValue("@price", price);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //command.Parameters.AddWithValue("@price", price);


                        Console.WriteLine("\nReading data...");

                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["laptop"]}");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        Console.WriteLine("Connection closed.");
        Hyy();
    }

    private static void Hyy()
    {
        Console.WriteLine("Method called");
    }
}
