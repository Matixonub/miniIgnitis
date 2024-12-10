using System.Data;
using System.Windows.Forms;
using Azure.Core;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Ignitis
{
    public partial class loginForm : Form
    {
        static public string LoggedInUsername { get; set; }
        static public string loginActive; 
        public loginForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            TryToLogin();
        }

        private void TryToLogin()
        {
            DataBase.ConnectionDB();
            Auth.Authorization(txtUsername.Text, txtPassword.Text);
            LoggedInUsername = txtUsername.Text;
            switch (Auth.category_id)
            {
                case null:
                    {
                        MessageBox.Show("Incorrect username or password!");
                        break;
                    }
                case "3":
                    {
                        MessageBox.Show("Logged in as Administrator");
                        adminForm form = new adminForm();
                        this.Hide();
                        form.Show();
                        break;
                    }
                case "2":
                    {
                        MessageBox.Show("Logged in as Manager");
                        managerForm form = new managerForm();
                        this.Hide();
                        form.Show();
                        break;
                    }
                case "1":
                    {
                        MessageBox.Show("Logged in as User id " + Auth.AuthorizationUserId(LoggedInUsername) + "");
                        userForm form = new userForm();
                        this.Hide();
                        form.Show();
                        break;
                    }
            }
        }


        private void clearUsernameButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
        }

        private void clearPasswordButton_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TryToLogin();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TryToLogin();
            }
        }
    }
}
