using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoMoisil_2024
{
    public partial class resultsForm : Form
    {
        string username;
        public resultsForm(string _username)
        {
            username = _username;
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm MenuForm = new menuForm(username);
            MenuForm.Show();
        }
    }
}
