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
	public partial class roleSelectForm : Form
	{
		public roleSelectForm()
		{
			InitializeComponent();
			FakeButton.Select();
		}
		private void buttonLeft_Click(object sender, EventArgs e)
		{
			FakeButton.Focus();
			this.Hide();
			puzzleManBecForm PuzzleManBecForm = new puzzleManBecForm();
			PuzzleManBecForm.Show();
		}
		private void buttonRight_Click(object sender, EventArgs e)
		{
			FakeButton.Focus();
		}

	}
}
