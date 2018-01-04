using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	public class Bombardir : Plane
	{
		private bool left;
		private bool right;
        private Color dopColor;


        public Bombardir(int maxSpeed, int maxCountBomb, double weight, Color color, bool left, bool right, bool v, Color dopColor) : base(maxSpeed, maxCountBomb, weight, color, left, right)
        {
            this.left = left;
            this.right = right;
            this.dopColor = dopColor;
        }

        protected override void drawLightBombardir(Graphics g)
		{
            base.drawLightBombardir(g);
 
            Pen pen = new Pen(dopColor);
            Brush br = new SolidBrush(dopColor);
            PointF[] pf1 = new PointF[5];

            pf1[0] = new Point((int)startPosX + 20, (int)startPosY + 23 + 1 + 5);
            pf1[1] = new Point((int)startPosX + 20 + 80, (int)startPosY + 23 + 1 + 5);
            pf1[2] = new Point((int)startPosX + 20 + 80 + 25, (int)startPosY + 23 + 30 + 1 + 5);
            pf1[3] = new Point((int)startPosX + 20 - 25, (int)startPosY + 23 + 30 + 1 + 5);
            pf1[4] = new Point((int)startPosX + 20, (int)startPosY + 23 + 1 + 5);

            g.FillPolygon(br, pf1);
        }

		public void setDopColor(Color color)
		{
			dopColor = color;
		}
	}
}
