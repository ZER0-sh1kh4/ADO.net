//namespace mvc_ado.net.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using global::mvc_ado.net.Models;
using Microsoft.Extensions.Configuration;


namespace mvc_ado.net.Data
{
    public class StudentRepository
    {
        private readonly string _connectionString;

        public StudentRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public List<Product> GetAllStudents()
        {
            List<Product> students = new List<Product>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Title , Author, Code  FROM BookMaster";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        Id = (int)reader["Id"],
                        Title = reader["Title"].ToString(),
                        Author = reader["Author"].ToString(),
                        Code = reader["Code"].ToString()
                    });
                }
            }

            return students;
        }
    }
}
