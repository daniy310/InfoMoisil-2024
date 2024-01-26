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
	public partial class HelperMan2 : Form
	{
		Random r = new Random(3);
		char[] chars = "౫ஐ௳ఇఎ಄ஃౚ౮లడఠಠరగ౦".ToCharArray();
		Label[] labels = new Label[16];
		Panel[] panels = new Panel[16];
		public HelperMan2()
		{
			InitializeComponent();
			labels = new Label[16];
			for (int i = 0; i < 16; i++)
			{
				var v = r.Next(-5, 6);
				string str = (v>0?"+":"")+v.ToString();
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
	}
}
