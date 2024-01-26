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
    public partial class menuForm : Form
    {
        public string username;
        public int rezultat;
        public menuForm(string _user, int _rezultat = 0)
        {
            username = _user;
            rezultat = _rezultat;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (rezultat != 0)
                saveButton.Visible = true;
            label1.Text = "Hello, " + username + " !";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            //choosePlayerMenu = new choosePlayerMenu(username);
            //choosePlayerMenu.Show();

        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            resultsForm ResultsForm = new resultsForm(username);
            ResultsForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
