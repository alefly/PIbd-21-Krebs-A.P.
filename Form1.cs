using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        Parking parking;

        public Form1()
        {
            InitializeComponent();
            parking = new Parking(15);
            Draw();
        }
        /// <summary>
        /// Метод для отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBox1.Image = bmp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
            private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var car = new Plane(100, 4, 1000, dialog.Color);
                int place = parking.PutPlaneInParking(car);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var car = new Bombardir(100, 4, 1000, dialog.Color, true, true, true, dialogDop.Color);
                    int place = parking.PutPlaneInParking(car);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }

            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")

            {
                var car = parking.GetPlaneInParking(Convert.ToInt32(maskedTextBox1.Text));
                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBoxTakeCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.setPosition(5, 5);
                car.drawCar(gr);
                pictureBoxTakeCar.Image = bmp;
                Draw();
            }
        }

    }
}


