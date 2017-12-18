using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_v2._0
{
    public partial class Form1 : Form
    {

        Color color;
        Color dopColor;
        int maxSpeed;
        int maxCountPass;
        int weight;
        int might;

        private ITech inter;

        public Form1()
        {
            InitializeComponent();
            color = Color.BlueViolet;
            dopColor = Color.Crimson;
            maxSpeed = 150;
            maxCountPass = 4;
            weight = 1500;
            might = 0;
            button1.BackColor = color;
            button2.BackColor = dopColor;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                button1.BackColor = color;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                button2.BackColor = dopColor;
            }

        }
        private bool checkFields()
        {
            if (!int.TryParse(textBox1.Text, out weight))
            {
                return false;
            }
            if (!int.TryParse(textBox2.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBox3.Text, out maxCountPass))
            {
                return false;
            }
            if (!int.TryParse(textBox4.Text, out might))
            {
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new UFO(maxSpeed, maxCountPass, weight, color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawUFO(gr);
                pictureBox1.Image = bmp;


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inter = new SuperUFO(150, 4, 1000, color, true, might, dopColor);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            inter.drawUFO(gr);
            pictureBox1.Image = bmp;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveUFO(gr);
                pictureBox1.Image = bmp;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
