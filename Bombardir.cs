using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	public class Bombardir : Plane, IComparable<Bombardir>,IEquatable<Plane>
	{
		private bool left;
		private bool right;
        public Color dopColor;

        public string CN()
        {
            return ";" + dopColor.Name;
        }

        public Bombardir(int maxSpeed, int maxCountBomb, double weight, Color color, bool left, bool right, bool v, Color dopColor) : base(maxSpeed, maxCountBomb, weight, color, left, right)
        {
            this.left = left;
            this.right = right;
            this.dopColor = dopColor;
        }

        public Bombardir(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                this.MaxSpeed = Convert.ToInt32(strs[0]);
                this.MaxCountBomb = Convert.ToInt32(strs[1]);
                this.Weight = Convert.ToInt32(strs[2]);
                this.ColorBody = Color.FromName(strs[3]);
                this.dopColor = Color.FromName(strs[4]);

            }
            this.left = false;
            this.right = false;
        }

        public string getInfo()
        {
            return 9999999 + ";" + MaxCountBomb + ";" + Weight + ";" + ColorBody.Name + ";" + dopColor.Name;
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

        public int CompareTo(Bombardir other)
        {
            var res = (this is Plane).CompareTo(other is Plane);
            if (res != 0)
            {
                return res;
            }
            if(left != other.left)
            {
                return left.CompareTo(other.left);
            }
            if (right != other.right)
            {
                return right.CompareTo(other.right);
            }
            if (dopColor != other.dopColor)
            {
                dopColor.Name.CompareTo(other.dopColor.Name);
            }
            return 0;
        }
        public bool Equals(Bombardir other)
        {
            var res = (this is Plane).Equals(other is Plane);

            if (!res)
            {
                return res;
            }
            if (left != other.left)
            {
                return false;
            }
            if (right != other.right)
            {
                return false;
            }
            if (dopColor != other.dopColor)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Bombardir planeobj = obj as Bombardir;
            if (planeobj == null)
            {
                return false;
            }
            else
            {
                return Equals(planeobj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
