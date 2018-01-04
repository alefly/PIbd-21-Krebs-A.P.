using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication4
{
    public abstract class Technique : ITechnique
    {
        protected int weight;
        protected int maxSpeed;
        protected Color colorBody;
        protected float startPosX;
        protected float startPosY;
        protected int countPassengers;
        public virtual int MaxCountPassengers
        {
            protected set;
            get;
        }

        public virtual int MaxSpeed
        {
            protected set;
            get;
        }

        public Color ColorBody
        {
            protected set;
            get;
        }

        public virtual double Weight
        {
            protected set;
            get;
        }


        public abstract void moveUFO(Graphics g);

        public abstract void drawUFO(Graphics g);

        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public void loadPassenger(int count)
        {
            if (countPassengers + count < MaxCountPassengers)
            {
                countPassengers += count;
            }
        }

        public int getPassenger()
        {
            int count = countPassengers;
            countPassengers = 0;
            return count;
        }

    }
}
