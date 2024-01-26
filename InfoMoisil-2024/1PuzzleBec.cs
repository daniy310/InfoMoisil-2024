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
    public partial class _1PuzzleBec : Form
    {
        bool[] buttonsState = new bool[10];

        public _1PuzzleBec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { buttonsState[0] = !buttonsState[0]; }
        private void button2_Click(object sender, EventArgs e) { buttonsState[1] = !buttonsState[1]; }
        private void button3_Click(object sender, EventArgs e) { buttonsState[2] = !buttonsState[2]; }
        private void button4_Click(object sender, EventArgs e) { buttonsState[3] = !buttonsState[3]; }
        private void button5_Click(object sender, EventArgs e) { buttonsState[4] = !buttonsState[4]; }
        private void button6_Click(object sender, EventArgs e) { buttonsState[5] = !buttonsState[5]; }
        private void button7_Click(object sender, EventArgs e) { buttonsState[6] = !buttonsState[6]; }
        private void button8_Click(object sender, EventArgs e) { buttonsState[7] = !buttonsState[7]; }
        private void button9_Click(object sender, EventArgs e) { buttonsState[8] = !buttonsState[8]; }
        private void button10_Click(object sender, EventArgs e) { buttonsState[9] = !buttonsState[9]; }
    }
}
