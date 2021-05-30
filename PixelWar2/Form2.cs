using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelWar2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 oyun = new Form1();
            oyun.ShowDialog();
            this.Dispose();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            label1.Visible = true;
            label1.Text = "ABOUT THE GAME\n    ______________\n\nThere are 7 levels and different enemies for each level.\n" +
                "We have an inventory with 3 differrent skills. \nWe can Attack to enemy with buttons on the form. \nThere is a battery that increases player's health point." +
                "\n\nWe can move with button on the form and W,A,S, and D. \n\nWe can attack with I,J,K, and L.\n\nSelect items with 1,2,3 and 4(For battery).\n\n   Good Luck! ";
                  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            button1.Visible = true;
            button3.Visible = false;
            label1.Visible = false;
            button2.Visible = true;

        }
    }
}
