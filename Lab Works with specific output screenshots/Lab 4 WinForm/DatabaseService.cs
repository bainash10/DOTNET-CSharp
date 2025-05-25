using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Inheritance_Form.Models;
using Npgsql;

namespace Inheritance_Form
{
    public class DatabaseService
    {
        private readonly string _connectionString;
        public DatabaseService()
        {
            this._connectionString = "Server=localhost;Port=5432;User Id=root;Password=root;Database=postgres";
        }
        public string Load_register(RegisterForm register)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var cmd = new NpgsqlCommand(
                        @"INSERT INTO register (name, age, province, district)
                        VALUES (@name, @age, @province, @district)", connection))
                    {
                        cmd.Parameters.AddWithValue("@name", register.Name ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@age", register.Age ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@province", register.Province ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@district", register.District ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Registration Successful.";
            }
            catch (NpgsqlException ex)
            {
                return $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"An error occured: {ex.Message}";
            }
        }
    }
}
