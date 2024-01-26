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

        private void resultsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infoMoisilDBDataSet.Results' table. You can move, or remove it, as needed.
            this.resultsTableAdapter.Fill(this.infoMoisilDBDataSet.Results);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultsTableAdapter.FillBy(this.infoMoisilDBDataSet.Results);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultsTableAdapter.FillBy1(this.infoMoisilDBDataSet.Results);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultsTableAdapter.FillBy2(this.infoMoisilDBDataSet.Results);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultsTableAdapter.FillBy1(this.infoMoisilDBDataSet.Results);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
