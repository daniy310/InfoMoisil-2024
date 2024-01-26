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
	public partial class HelperMan : Form
	{
		Random r = new Random(3);
		char[] chars = "ඉඊඏගඞජටණනළ෦෧෬෭෮෴".ToCharArray();
		char[] indicators = "⚪⚫".ToCharArray();

		Label[] labels;
		public HelperMan()
		{
			InitializeComponent();
			labels = new Label[16];
			for(int i = 0; i < 16; i++)
			{
				var v = r.Next(0,4);
				string str = "";
				switch (v)
				{
					case 0:
						str += "⚪⚪";
						break;
					case 1:
						str += "⚪⚫";
						break;
					case 2:
						str += "⚫⚪";
						break;
					case 3:
						str += "⚫⚫";
						break;
					default:
						break;
				}
				str += chars[i];
				labels[i] = new Label();
				labels[i].Text = str;
				labels[i].AutoSize = true;
				//labels[i].Location = new Point(i / 4 * 119, (i%4) * 37);
				labels[i].Font = new Font("Microsoft Sans Serif", 24);
				labels[i].Dock = DockStyle.Fill;
				tableLayoutPanel1.Controls.Add(labels[i], i / 4, i % 4);
			}

		}

		private void labelCodeTemplate_Click(object sender, EventArgs e)
		{

		}

		private void buttonVerify_Click(object sender, EventArgs e)
		{
			if (textBoxValidare.Text == "abracadabra")
				return;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
