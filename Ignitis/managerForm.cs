using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ignitis
{
    public partial class managerForm : Form
    {
        private void RefreshDataGrid()
        {
            string querry = "select * from `utility`";
            utilityList.GetStatus(querry);
            Utility.DataSource = utilityList.dtStatus;
        }
        private void RefreshGroupDataGrid()
        {
            string query = "select * from `group`";
            discount_list.GetStatus(query);
            Group.DataSource = discount_list.dtStatus;
        }
        public managerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm form = new loginForm();
            form.Show();
        }

        private void managerForm_Load(object sender, EventArgs e)
        {
            string utilityQuery = "select * from `utility`";
            utilityList.GetStatus(utilityQuery);
            Utility.DataSource = utilityList.dtStatus;

            string groupQuery = "select * from `group`";
            discount_list.GetStatus(groupQuery);
            Group.DataSource = discount_list.dtStatus;
        }

        private void managerForm_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        static public string EditName1, EditNum1;
        private void ChangePriceButton_Click(object sender, EventArgs e)
        {
            EditName1 = Utility.CurrentRow.Cells[1].Value.ToString();
            EditNum1 = Utility.CurrentRow.Cells[2].Value.ToString();

            changePricePanel.Visible = true;

            EditPriceTextBox.Text = EditNum1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveNewPriceButton_Click(object sender, EventArgs e)
        {

            if (EditPriceTextBox.Text == EditNum1) // jei textobxas toks pats kaip ir sena informacija
            {
                if (EditPriceTextBox.Text != "") // jei textboxe yra informacija
                {
                    EditData.EditColumn("utility", "price", EditPriceTextBox.Text, "name", EditName1);
                    utilityList.GetStatus("select * from `utility`");
                    RefreshDataGrid();
                    changePricePanel.Visible = false;
                    EditPriceTextBox.Text = "";
                }
                else // jei textbox tuscias
                {
                    MessageBox.Show("Please fill the box!");
                }
            }
            else // jei informacija textboxe kitokia nei sena
            {
                string querry = @"select utility_id from `utility` where price = '" + EditPriceTextBox + "'";
                DataBase.msCommand.CommandText = querry;
                Object result = DataBase.msCommand.ExecuteScalar();

                if (EditPriceTextBox.Text != "")
                {
                    EditData.EditColumn("utility", "price", EditPriceTextBox.Text, "name", EditName1);
                    utilityList.GetStatus("select * from `utility`");
                    RefreshDataGrid();
                    changePricePanel.Visible = false;
                    EditPriceTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Please fill the box!");
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            changePricePanel.Visible = false;
        }
        static public string EditName2, EditNum2;

        private void changeDiscountButton_Click(object sender, EventArgs e)
        {
            EditName2 = Group.CurrentRow.Cells[0].Value.ToString();
            EditNum2 = Group.CurrentRow.Cells[2].Value.ToString();

            changeDiscountPanel.Visible = true;

            discountTextBox.Text = EditNum2;
        }

        private void HideButton2_Click(object sender, EventArgs e)
        {
            changeDiscountPanel.Visible = false;

        }

        private void saveDiscountButton_Click(object sender, EventArgs e)
        {
            if (discountTextBox.Text == EditNum2) // jei textobxas toks pats kaip ir sena informacija
            {
                if (discountTextBox.Text != "") // jei textboxe yra informacija
                {
                    EditData.EditColumn("group", "discount", discountTextBox.Text, "group_id", EditName2);
                    discount_list.GetStatus("select * from `group`");
                    RefreshGroupDataGrid();
                    changeDiscountPanel.Visible = false;
                    discountTextBox.Text = "";
                }
                else // jei textbox tuscias
                {
                    MessageBox.Show("Please fill the box!");
                }
            }
            else // jei informacija textboxe kitokia nei sena
            {
                string querry = @"select group_id from `group` where discount = '" + discountTextBox + "'";
                DataBase.msCommand.CommandText = querry;
                Object result = DataBase.msCommand.ExecuteScalar();

                if (discountTextBox.Text != "")
                {
                    EditData.EditColumn("group", "discount", discountTextBox.Text, "group_id", EditName2);
                    discount_list.GetStatus("select * from `group`");
                    RefreshGroupDataGrid();
                    changeDiscountPanel.Visible = false;
                    discountTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Please fill the box!");
                }

            }
        }

        private void Group_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
