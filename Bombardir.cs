using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class Bombardir : Plane
    {
        private bool magic;
        private int might;
        private Color dopColor;
        private Color color;
        public Bombardir(int maxSpeed, int maxCountPassenget, double weight, Color color, bool magic, int might, Color dopColor) : base(maxSpeed, maxCountPassenget, weight, color)
        {
            this.left = left;
            this.right = right;
            this.dopColor = dopColor;
            this.color = color;
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
      }
 
 		public void setDopColor(Color color)
 		{
 			dopColor = color;
 		}
 	}
  }
