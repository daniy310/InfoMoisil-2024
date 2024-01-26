using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoMoisil_2024
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (usernameTextbox.Text.Length < 5)
            {
                MessageBox.Show("Username is too short !");
                return;
            }
            if (passwordTextbox.Text.Length < 6)
            {
                MessageBox.Show("Password is too short !");
                return;
            }

            if (passwordTextbox.Text != passwordConfirmationTextbox.Text)
            {
                MessageBox.Show("Passwords do not match !");
                return;
            }

            string parola = passwordTextbox.Text;
            string username = usernameTextbox.Text;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@"..\..\InfoMoisilDB.mdf;") + @"Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username is already used !");
                        return;
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", parola);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully !");
                }
            }

            this.Close();
            loginForm LoginForm = new loginForm();
            LoginForm.Show();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm LoginForm = new loginForm();
            LoginForm.Show();
        }
    }
}
