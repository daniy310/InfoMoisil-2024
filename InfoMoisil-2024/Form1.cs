using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace InfoMoisil_2024
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
        string username = usernameTextbox.Text;
        string password = passwordTextbox.Text;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""" + Path.GetFullPath(@"..\..\InfoMoisilDB.mdf") + @""";Integrated Security=True";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    this.Hide();

                        //choosePlayerMenu = new choosePlayerMenu(username);
                        //choosePlayerMenu.Show();
                    }
                    else
                {
                    MessageBox.Show("Invalid username/password combination !");
                    usernameTextbox.Text = "";
                    passwordTextbox.Text = "";
                }
            }
        }

            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm RegisterForm = new registerForm();
            RegisterForm.Show();
        }
    }
}
