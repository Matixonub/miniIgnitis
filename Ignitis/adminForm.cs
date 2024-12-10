using Microsoft.IdentityModel.Tokens;
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
    public partial class adminForm : Form
    {
        private string currentTableName = "";
        private HashSet<int> editedRows = new HashSet<int>();
        private DBHelper dbHelper;


        private void LoadDataIntoDataGridView(string tableName)
        {
            try
            {
                DataTable dataTable = dbHelper.GetData(tableName);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Add the edited row index to the set
            int rowIndex = e.RowIndex;
            editedRows.Add(rowIndex);
        }

        public adminForm()
        {
            InitializeComponent();
            dbHelper = new DBHelper();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm form = new loginForm();
            form.Show();
        }

        private void UserTableMainButton_Click(object sender, EventArgs e)
        {
            currentTableName = "user";
            LoadDataIntoDataGridView("user");  // Show Users table
        }

        private void UtilityTableMainButton_Click(object sender, EventArgs e)
        {
            currentTableName = "utility";
            LoadDataIntoDataGridView("utility");
        }

        private void GroupTableMainButton_Click(object sender, EventArgs e)
        {
            currentTableName = "group";
            LoadDataIntoDataGridView("`group`");
        }

        private void UtilitiesTableMainButton_Click(object sender, EventArgs e)
        {
            currentTableName = "utilities";
            LoadDataIntoDataGridView("`utilities`");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string primaryKeyColumn = dataGridView1.Columns[0].Name;
                    object primaryKeyValue = selectedRow.Cells[0].Value;

                    if (primaryKeyValue == null || primaryKeyValue == DBNull.Value)
                    {
                        MessageBox.Show("The selected row does not have a valid primary key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    };
                    bool isDeleted = dbHelper.DeleteRow(currentTableName, primaryKeyColumn, Convert.ToInt32(primaryKeyValue));

                    if (isDeleted)
                    {
                        MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataIntoDataGridView(currentTableName);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a table is currently selected
                if (string.IsNullOrEmpty(currentTableName))
                {
                    MessageBox.Show("No table selected. Please select a table first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Collect user input for the new row (this could be a form or custom logic)
                string[] newRowValues = GetRowInputFromUser();

                if (newRowValues == null)
                {
                    MessageBox.Show("Operation cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Add the new row to the table
                bool isInserted = dbHelper.InsertRow(currentTableName, newRowValues);

                if (isInserted)
                {
                    MessageBox.Show("Row added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView
                    LoadDataIntoDataGridView(currentTableName);
                }
                else
                {
                    MessageBox.Show("Failed to add the row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string[] GetRowInputFromUser()
        {
            List<string> inputs = new List<string>();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Enter value for {column.HeaderText}:",
                    "Add New Row",
                    ""
                );

                if (string.IsNullOrEmpty(input)) return null; // atsaukta
                inputs.Add(input);
            }

            return inputs.ToArray();
        }

       
    }

}
