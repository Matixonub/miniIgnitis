using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ignitis
{
    internal class utilityList
    {
        static public DataTable dtStatus = new DataTable();

        static public void GetStatus(string querry)
        {
            try
            {
                DataBase.msCommand.CommandText = querry;
                dtStatus.Clear();
                DataBase.msDataAdapter.SelectCommand = DataBase.msCommand;
                DataBase.msDataAdapter.Fill(dtStatus);
            }
            catch
            {
                MessageBox.Show("Error getting information about utilities!");
            }
            
        }

    }
}
