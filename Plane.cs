using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class Plane : Technique
    {
        private bool left;
        private bool right;

        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 1500)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 1000;
                }
            }
        }

        public override int MaxCountBomb
        {
            get
            {
                return base.MaxCountBomb;
            }
            protected set
            {
                if (value > 0 && value < 5)
                {
                    base.MaxCountBomb = value;
                }
                else
                {
                    base.MaxCountBomb = 4;
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

        public Plane(int maxSpeed, int maxCountBomb, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountBomb = maxCountBomb;
            this.ColorBody = color;
            this.Weight = weight;
            this.countBomb = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        public Plane(int maxSpeed, int maxCountBomb, double weight, Color color, bool left, bool right) : this(maxSpeed, maxCountBomb, weight, color)
        {
            this.left = left;
            this.right = right;
        }

        public override void moveBombardir(Graphics g)
        {
            startPosX += (MaxSpeed * 50 / (float)Weight) / (countBomb == 0 ? 1 : countBomb);
            drawBombardir(g);
        }

        public override void moveUpBombardir(Graphics g)
        {
            startPosY -= (MaxSpeed * 50 / (float)Weight) / (countBomb == 0 ? 1 : countBomb);
            drawBombardir(g);
        }

        public override void drawBombardir(Graphics g)
        {
            drawLightBombardir(g);
        }

        protected virtual void drawLightBombardir(Graphics g)
        {
           
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, startPosX + 20, startPosY - 10 + 5, 80, 30);
            Brush br = new SolidBrush(this.ColorBody);
            PointF[] pf = new PointF[7];
           
            pf[0] = new Point((int)startPosX + 20, (int)startPosY + 5);
            pf[1] = new Point((int)startPosX + 100, (int)startPosY + 5);
            pf[5] = new Point((int)startPosX, (int)startPosY + 12 + 5);
            pf[2] = new Point((int)startPosX + 120, (int)startPosY + 12 + 5);
            pf[4] = new Point((int)startPosX + 20, (int)startPosY + 24 + 5);
            pf[3] = new Point((int)startPosX + 100, (int)startPosY + 24 + 5);
            pf[6] = new Point((int)startPosX + 20, (int)startPosY + 5);
            g.FillPolygon(br, pf);
            g.DrawLines(pen, pf);
            g.DrawLine(pen, pf[2], pf[5]);
        }

        public override void moveBomb(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override void giveBomb(Graphics g)
        {
            takeBomb(g);
        }

        protected virtual void takeBomb(Graphics g)
        {

        }

    }

}
