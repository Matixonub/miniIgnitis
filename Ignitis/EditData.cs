using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignitis
{
    internal class EditData
    {
        static public DataTable dtStatus = new DataTable();

        static public bool EditColumn(string table_name, string column_name, string data, string key_column, string key_name)
        {
            try
            {
                DataBase.msCommand.CommandText = $"UPDATE `{table_name}` SET {column_name} = @data WHERE {key_column} = @key_name";
                DataBase.msCommand.Parameters.Clear();

                DataBase.msCommand.Parameters.AddWithValue("@data", int.Parse(data));
                DataBase.msCommand.Parameters.AddWithValue("@key_name", key_name);

                if (DataBase.msCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully changed the value.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Error when changing the value.");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Error while editing the value!");
                return false;
            }
        }

    }
}
