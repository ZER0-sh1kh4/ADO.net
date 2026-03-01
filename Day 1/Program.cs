////// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");

//using System.Data;
//using System.Data.SqlClient;
//using System.Reflection.PortableExecutable;
//using System.Runtime.InteropServices.Marshalling;


//class Program
//{
//    static void Main()
//    {
//        string connectionString =
//            "Data Source=-Z3R0-\\SQLEXPRESS;" +
//            "Initial Catalog=Library;" +
//            "Integrated Security=True;" +
//            "Connect Timeout=30;" +
//            "Encrypt=True;" +
//            "TrustServerCertificate=True;";

//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            try
//            {
//                connection.Open();
//                Console.WriteLine("Connection successful!");


//                using (SqlCommand command = new SqlCommand("sp_filterStudents", connection))
//                {
//                    command.CommandType = CommandType.StoredProcedure;
//                    command.Parameters.AddWithValue("@Gender", "Male");
//                    command.Parameters.AddWithValue("@Department", "BCA");
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        //command.Parameters.AddWithValue("@price", price);


//                        Console.WriteLine("\nReading data...");

//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Department"]}");
//                        }
//                    }
//                }
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }
//        }

//        Console.WriteLine("Connection closed.");
//        Hyy();
//        Console.ReadLine();
//    }

//    private static void Hyy()
//    {
//        Console.WriteLine("Method called");
//    }
//}
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using System.Data;
//using System.Data.SqlClient;
//using System.Reflection.PortableExecutable;
//using System.Runtime.InteropServices.Marshalling;


//class Program
//{
//    static void Main()
//    {
//        string connectionString =
//            "Data Source=-Z3R0-\\SQLEXPRESS;" +
//            "Initial Catalog=Library;" +
//            "Integrated Security=True;" +
//            "Connect Timeout=30;" +
//            "Encrypt=True;" +
//            "TrustServerCertificate=True;";

//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            try
//            {
//                connection.Open();
//                Console.WriteLine("Connection successful!");


//                using (SqlCommand command = new SqlCommand("sp_CountGender", connection))
//                {
//                    SqlParameter outputParam = new SqlParameter("@TotalCount", SqlDbType.Int);
//                    outputParam.Direction = ParameterDirection.Output;
//                    command.Parameters.Add(outputParam);   // FIXED (command, not cmd)

//                    command.ExecuteNonQuery();

//                    Console.WriteLine("Total Students: " + outputParam.Value); ader = command.ExecuteReader())
//                    //{
//                    //    //command.Parameters.AddWithValue("@price", price);


//                    //    Console.WriteLine("\nReading data...");

//                    //    while (reader.Read())
//                    //    {
//                    //        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Department"]}");
//                    //    }
//                    //}
//                }
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }
//        }

//        Console.WriteLine("Connection closed.");
//        Hyy();
//        Console.ReadLine();
//    }

//    private static void Hyy()
//    {
//        Console.WriteLine("Method called");
//    }
//}
//using System;
//using System.Data;
//using System.Data.SqlClient;

//class Program
//{
//    static void Main()
//    {
//        string connectionString =
//            "Data Source=-Z3R0-\\SQLEXPRESS;" +
//            "Initial Catalog=Library;" +
//            "Integrated Security=True;" +
//            "Connect Timeout=30;" +
//            "Encrypt=True;" +
//            "TrustServerCertificate=True;";
//            using (SqlConnection con = new SqlConnection(connectionString))
//            {
//                con.Open();

//                SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM Hostels", con);
//                int total = (int)countCmd.ExecuteScalar();

//                Console.WriteLine("Total Students: " + total);

//                if (total > 5)
//                {
//                    SqlCommand deleteCmd = new SqlCommand(
//                        "DELETE FROM Hostels WHERE [Room no] > 120", con);

//                    int rows = deleteCmd.ExecuteNonQuery();
//                    Console.WriteLine(rows + " records deleted");
//                }
//            //Console.ReadLine();
//                else
//                {
//                    SqlCommand readCmd = new SqlCommand(
//                        "SELECT id, Name, [Room no] FROM Hostels", con);

//                    SqlDataReader reader = readCmd.ExecuteReader();

//                    while (reader.Read())
//                    {
//                        Console.WriteLine(
//                            reader["id"] + " " +
//                            reader["Name"] + " " +
//                            reader["Room no"]);
//                    }

//                    reader.Close();
//                Console.ReadLine();
//                }
//            }
//        }
//    }


//using System;
//using System.Data;
//using System.Data.SqlClient;

//class Program
//{
//    static void Main()
//    {
//        string connectionString =
//            "Data Source=-Z3R0-\\SQLEXPRESS;" +
//            "Initial Catalog=Library;" +
//            "Integrated Security=True;" +
//            "Connect Timeout=30;" +
//            "Encrypt=True;" +
//            "TrustServerCertificate=True;";

//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            try
//            {
//                connection.Open();
//                Console.WriteLine("Connection successful!");

//                string query = "select dbo.Sqauare(@num)";

//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    command.CommandType = CommandType.Text;
//                    command.Parameters.AddWithValue("@num", 5);

//                    int square = Convert.ToInt32(command.ExecuteScalar());
//                    Console.WriteLine("Square: " + square);
//                }
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }
//        }

//        Console.WriteLine("Connection closed.");
//        Hyy();
//        Console.ReadLine();
//    }

//    private static void Hyy()
//    {
//        Console.WriteLine("Method called");
//    }
//}
using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source= 10.150.121.42,1433;" +
            "Initial Catalog=Library;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        DataSet ds = new DataSet();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection successful!");

                using (SqlCommand command = new SqlCommand("usp_getstudentname3", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds, "CollegeMaster");
                }

                Console.WriteLine("Student details:");

                // Correct way to read DataSet
                foreach (DataRow row in ds.Tables["CollegeMaster"].Rows)
                {
                    foreach (var col in row.ItemArray)
                    {
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        Console.WriteLine("Connection closed.");
        Hyy();
        Console.ReadLine();
    }

    private static void Hyy()
    {
        Console.WriteLine("Method called");
    }
}

//using System;
//using System.Data;
//using System.Data.SqlClient;

//class Program
//{
//    static void Main()
//    {
//        string connectionString =
//            "Data Source= 10.150.121.42;" +
//            "Initial Catalog=Library;" +
//            "Integrated Security=True;" +
//            "Connect Timeout=30;" +
//            "Encrypt=True;" +
//            "TrustServerCertificate=True;";

//        DataSet ds = new DataSet();

//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            try
//            {
//                connection.Open();
//                Console.WriteLine("Connection successful!");

//                using (SqlConnection con = new SqlConnection(connectionString))
//                {
//                    con.Open();
//                    SqlDataAdapter da = new SqlDataAdapter("usp_getstudentname3", con);
//                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

//                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
//                    DataTable dt = ds.Tables["Hostels"];
//                    da.Fill(ds, "Hostels");


//                    // CREATE
//                    DataRow newRow = dt.NewRow();
//                    newRow["Name"] = "Arun";
//                    newRow["Room no"] = 200;
//                    dt.Rows.Add(newRow);

//                    // UPDATE
//                    dt.Rows[0]["Room no"] = 100;

//                    // DELETE
//                    if (dt.Rows.Count > 1)
//                        dt.Rows[1].Delete();

//                    da.Update(dt);
//                }

//                Console.WriteLine("CRUD operations completed successfully");
//            }


//        }

//        Console.WriteLine("Connection closed.");
//        Hyy();
//        Console.ReadLine();
//    }

//    private static void Hyy()
//    {
//        Console.WriteLine("Method called");
//    }
//}
