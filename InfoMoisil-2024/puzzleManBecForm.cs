﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoMoisil_2024
{
    public partial class puzzleManBecForm : Form
    {
        bool[] secv = new bool[10] {
            false,
            true,
            true,
            true,
            false,
            false,
            true,
            false,
            false,
            false,
        };

        bool[] buttonsState = new bool[10];

        static Image LoadImage(String name)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string offFile = System.IO.Path.Combine(sCurrentDirectory, $@"..\..\..\Assets\{name}.png");
            string offFilePath = Path.GetFullPath(offFile);
            Image image = Image.FromFile(offFilePath);

            return image;
        }

        Image onImage = LoadImage("BulbOn");
        Image offImage = LoadImage("BulbOff");

        void UpdateButtonVisuals()
        {
            int i = 0;
            foreach (Button button in buttonsPanel.Controls.OfType<Button>())
            {
                button.BackgroundImage = buttonsState[i] ? onImage : offImage;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                i++;
            }
        }

        public puzzleManBecForm()
        {
            InitializeComponent();
            UpdateButtonVisuals();
        }

        private void puzzleManBecForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonsState[0] = !buttonsState[0]; UpdateButtonVisuals();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            buttonsState[1] = !buttonsState[1]; UpdateButtonVisuals();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            buttonsState[2] = !buttonsState[2]; UpdateButtonVisuals();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            buttonsState[3] = !buttonsState[3]; UpdateButtonVisuals();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            buttonsState[4] = !buttonsState[4]; UpdateButtonVisuals();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            buttonsState[5] = !buttonsState[5]; UpdateButtonVisuals();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            buttonsState[6] = !buttonsState[6]; UpdateButtonVisuals();

        }
        private void button8_Click(object sender, EventArgs e)
        {
            buttonsState[7] = !buttonsState[7]; UpdateButtonVisuals();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            buttonsState[8] = !buttonsState[8]; UpdateButtonVisuals();

        }
        private void button10_Click(object sender, EventArgs e)
        {
            buttonsState[9] = !buttonsState[9]; UpdateButtonVisuals();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Validate
            if (IsValid())
            {
                MessageBox.Show("CORRECT");
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

        bool IsValid()
        {
            for (int i = 0; i < 10; i++)
            {
                if (buttonsState[i] != secv[i]) return false;
            }
            return true;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (IsValid())
            {
                MessageBox.Show("Your partner's code is abracadabra.");
            }
            else
            {
                MessageBox.Show("That's not correct !");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            buttonsState[0] = !buttonsState[0]; UpdateButtonVisuals();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            buttonsState[1] = !buttonsState[1]; UpdateButtonVisuals();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            buttonsState[2] = !buttonsState[2]; UpdateButtonVisuals();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            buttonsState[3] = !buttonsState[3]; UpdateButtonVisuals();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            buttonsState[4] = !buttonsState[4]; UpdateButtonVisuals();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            buttonsState[6] = !buttonsState[6]; UpdateButtonVisuals();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            buttonsState[7] = !buttonsState[7]; UpdateButtonVisuals();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            buttonsState[8] = !buttonsState[8]; UpdateButtonVisuals();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            buttonsState[9] = !buttonsState[9]; UpdateButtonVisuals();
        }
    }
}
