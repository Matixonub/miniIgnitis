using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ignitis
{
    internal class DataBase
    {
        static string DBConnect = "server = localhost; user = root; password = nub123; database = ignitisv3";
        static public MySqlDataAdapter msDataAdapter;
        static MySqlConnection msConnect;
        static public MySqlCommand msCommand;

        public static bool ConnectionDB()
        {
            try
            {
                msConnect = new MySqlConnection(DBConnect);
                msConnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = msConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch
            {
                MessageBox.Show("Error connecting to DataBase");
                return false;
            }
        }


        public static void CloseDB()
        {
            msConnect.Close();
        }

        public MySqlConnection GetConnection()
        {
            return msConnect;
        }



    }
}
