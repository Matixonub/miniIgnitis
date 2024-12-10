using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignitis
{
    internal class DBHelper
    {
        private string connectionString = "server = localhost; user = root; password = nub123; database = ignitisv3";

        public DataTable GetData(string tableName)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT * FROM {tableName}";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    dataAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dataTable;
        }
        public bool DeleteRow(string tableName, string primaryKeyColumn, int primaryKeyValue)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"DELETE FROM {tableName} WHERE {primaryKeyColumn} = @PrimaryKeyValue";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DeleteRow: " + ex.Message);
                return false;
            }
        }
        public bool InsertRow(string tableName, string[] values)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string placeholders = string.Join(", ", values.Select((_, i) => $"@param{i}"));
                    string query = $"INSERT INTO {tableName} VALUES ({placeholders});";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        for (int i = 0; i < values.Length; i++)
                        {
                            command.Parameters.AddWithValue($"@param{i}", values[i]);
                        }
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in InsertRow: " + ex.Message);
                return false;
            }
        }

        }
}
