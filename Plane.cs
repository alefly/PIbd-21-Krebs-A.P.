using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_v2._0
{
    class UFO : Vehicle
    {
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 300)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 150;
                }
            }
        }
        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }
            protected set
            {
                if (value > 0 && value < 5)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 4;
                }
            }
        }

        public override double Weight
        {
            get
            {
                return base.Weight;
            }
            protected set
            {
                if (value > 500 && value < 1500)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 1000;
                }
            }
        }

        public UFO(int maxSpeed, int maxCountPassenger, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassenger;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }
        public override void moveUFO(Graphics g)
        {
            startPosX += (MaxSpeed * 50 / (float)Weight) / (countPassengers == 0 ? 1 : countPassengers);
            drawUFO(g);
        }

        public override void drawUFO(Graphics g)
        {
            drawSuperUFO(g);
        }
        protected virtual void drawSuperUFO(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, startPosX + 20, startPosY - 10, 80, 30);
            Brush br = new SolidBrush(ColorBody);
            PointF[] pf = new PointF[7];
            pf[0] = new Point((int)startPosX + 20, (int)startPosY);
            pf[1] = new Point((int)startPosX + 100, (int)startPosY);
            pf[5] = new Point((int)startPosX, (int)startPosY + 12);
            pf[2] = new Point((int)startPosX + 120, (int)startPosY + 12);
            pf[4] = new Point((int)startPosX + 20, (int)startPosY + 24);
            pf[3] = new Point((int)startPosX + 100, (int)startPosY + 24);
            pf[6] = new Point((int)startPosX + 20, (int)startPosY);
            g.FillPolygon(br, pf);
            g.DrawLines(pen, pf);
            g.DrawLine(pen, pf[2], pf[5]);
            
        }


    }
}
