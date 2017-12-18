using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_v2._0
{
    class SuperUFO : UFO
    {
        private bool magic;
        private int might;
        private Color dopColor;
        private Color color;
        public SuperUFO(int maxSpeed, int maxCountPassenget, double weight, Color color, bool magic, int might, Color dopColor) : base(maxSpeed, maxCountPassenget, weight, color)
        {
            this.magic = magic;
            this.might = might;
            this.dopColor = dopColor;
            this.color = color;
        }
        protected override void drawSuperUFO(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            base.drawSuperUFO(g);
            Brush br2 = new SolidBrush(dopColor);
            PointF[] pf = new PointF[5];
            pf[0] = new Point((int)startPosX + 20, (int)startPosY + 6);
            pf[1] = new Point((int)startPosX + 26, (int)startPosY + 12);
            pf[2] = new Point((int)startPosX + 20, (int)startPosY + 18);
            pf[3] = new Point((int)startPosX + 14, (int)startPosY + 12);
            pf[4] = new Point((int)startPosX + 20, (int)startPosY + 6);
            g.FillPolygon(br2, pf);
            g.DrawLines(pen, pf);

            pf[0] = new Point((int)startPosX + 40, (int)startPosY + 6);
            pf[1] = new Point((int)startPosX + 46, (int)startPosY + 12);
            pf[2] = new Point((int)startPosX + 40, (int)startPosY + 18);
            pf[3] = new Point((int)startPosX + 34, (int)startPosY + 12);
            pf[4] = new Point((int)startPosX + 40, (int)startPosY + 6);
            g.FillPolygon(br2, pf);
            g.DrawLines(pen, pf);

            pf[0] = new Point((int)startPosX + 60, (int)startPosY + 6);
            pf[1] = new Point((int)startPosX + 66, (int)startPosY + 12);
            pf[2] = new Point((int)startPosX + 60, (int)startPosY + 18);
            pf[3] = new Point((int)startPosX + 54, (int)startPosY + 12);
            pf[4] = new Point((int)startPosX + 60, (int)startPosY + 6);
            g.FillPolygon(br2, pf);
            g.DrawLines(pen, pf);

            pf[0] = new Point((int)startPosX + 80, (int)startPosY + 6);
            pf[1] = new Point((int)startPosX + 86, (int)startPosY + 12);
            pf[2] = new Point((int)startPosX + 80, (int)startPosY + 18);
            pf[3] = new Point((int)startPosX + 74, (int)startPosY + 12);
            pf[4] = new Point((int)startPosX + 80, (int)startPosY + 6);
            g.FillPolygon(br2, pf);
            g.DrawLines(pen, pf);

            pf[0] = new Point((int)startPosX + 100, (int)startPosY + 6);
            pf[1] = new Point((int)startPosX + 106, (int)startPosY + 12);
            pf[2] = new Point((int)startPosX + 100, (int)startPosY + 18);
            pf[3] = new Point((int)startPosX + 94, (int)startPosY + 12);
            pf[4] = new Point((int)startPosX + 100, (int)startPosY + 6);
            g.FillPolygon(br2, pf);
            g.DrawLines(pen, pf);

            if (might > 0) {
                Brush br3 = new SolidBrush(Color.LightCyan);
                PointF[] pf1 = new PointF[5];
                pf1[0] = new Point((int)startPosX + 20, (int)startPosY + 25);
                pf1[1] = new Point((int)startPosX + 100, (int)startPosY + 25);
                pf1[2] = new Point((int)startPosX + 150 + might, (int)startPosY + 60);
                pf1[3] = new Point((int)startPosX - 30 - might, (int)startPosY + 60);
                pf1[4] = new Point((int)startPosX + 20, (int)startPosY + 25);
                g.FillPolygon(br3, pf1);
                g.DrawLines(pen, pf1);

            }

        }
    }
}
