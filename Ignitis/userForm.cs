using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Ignitis
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm form = new loginForm();
            form.Show();
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            string querry = "SELECT user.group_id, group.house_number, group.discount, utility.name, utility.price FROM `user` JOIN `utilities` ON user.group_id = utilities.group_id JOIN `utility` ON utilities.utility_id = utility.utility_id JOIN `group` ON user.group_id = group.group_id WHERE user.group_id = '" + Auth.AuthorizationUserGroupId(loginForm.LoggedInUsername) + "'";
            utilityList.GetStatus(querry);
            dataGridView1.DataSource = utilityList.dtStatus;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void calculatediscount_Click(object sender, EventArgs e)
        {
            DataBase.msCommand.CommandText = @"SELECT SUM(utility.price * (1 - group.discount / 100)) AS total_price_with_discount FROM `user` JOIN `utilities` ON user.group_id = utilities.group_id JOIN `utility` ON utilities.utility_id = utility.utility_id JOIN `group` ON user.group_id = group.group_id WHERE user.group_id = '" + Auth.AuthorizationUserGroupId(loginForm.LoggedInUsername) + "'";
            Object result = DataBase.msCommand.ExecuteScalar();
            CostWithDiscount.Text = result.ToString();
        }
    }
}
