using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	public interface ITechnique
	{
		void moveBombardir(Graphics g);

    void moveBomb(Graphics g);

		void setPosition(int x, int y);

    void drawBombardir(Graphics gr);

		void setMainColor(Color color);
    }
}
